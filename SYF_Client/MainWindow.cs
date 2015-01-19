using System;
using System.Linq;
using System.Windows.Forms;
using log4net;
using System.Reflection;
using SYF_Client.Properties;
using System.IO;
using log4net.Repository;
using log4net.Appender;
using SYF_Client.Controls;
using System.Drawing;
using System.Diagnostics;
using Microsoft.Win32;
using SYF_Server.Messages;


namespace SYF_Client
{
  public partial class MainWindow : Form
  {
    //Logging
    private const string Log4NetConfigFileName = "log4net.conf.xml";
    private static readonly ILog log =
                            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    public Runtime Runtime { get; set; }
    public Verification Verification { get; set; }
    public UserEnrollment UserEnrollment { get; set; }

    private UserControl MessageControl { get; set; }
    private System.Windows.Forms.Message Message { get; set; }

    private NotifyIcon notifyIcon = new NotifyIcon();
    private bool isActive;

    delegate void ChangeContentCallback(UserControl content);

    readonly KeyboardFilter kbFilter = new KeyboardFilter(new Keys[] 
        { 
          //Keys.Control | Keys.Shift | Keys.Escape,
          //Keys.Alt | Keys.Tab,
          //Keys.LWin | Keys.D,
          //Keys.RWin | Keys.D, 
          //Keys.LWin | Keys.X, 
          //Keys.RWin | Keys.X,
          //Keys.Alt | Keys.F4,
        });

    public MainWindow()
    {
      InitializeLogging(Settings.Default.LogFilePath);
      isActive = true;
      SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
      InitializeComponent();
      Autostart();

      // No Borders
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.WindowState = FormWindowState.Maximized;
      //this.Bounds = Screen.FromControl(this).Bounds;
      //this.TopMost = true;
      //this.ShowInTaskbar = false;

      InitializeControls();

      // Initialize Runtime
      Runtime = new Runtime();
      Runtime.InitializeRuntime();

      ValidationResponseMessage msg = Runtime.TcpSockets.UserMessage("", "", Runtime.UserName, null);
#warning server response
      if (msg.Success)
      {
        ChangeToVerification();
      }
      else
      {
        ChangeToUserEnrollment();
      }
      picBox.StartWebcam();
      ContextMenue();
    }

    #region Initialize
    public void InitializeControls()
    {
      Verification = new Verification(this);
      Verification.Dock = DockStyle.Fill;
      Verification.Visible = true;

      UserEnrollment = new UserEnrollment(this);
      UserEnrollment.Dock = DockStyle.Fill;
      UserEnrollment.Visible = true;
    }

    // logging
    public static void InitializeLogging(string logDirectory)
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileInfo fInfo = new FileInfo(Log4NetConfigFileName);
      log4net.Config.XmlConfigurator.Configure();

      // get properties
      log4net.GlobalContext.Properties["assembly"] = assembly.GetName().Name;
      log4net.GlobalContext.Properties["version"] = assembly.GetName().Version;
      log4net.GlobalContext.Properties["os"] = System.Environment.OSVersion.VersionString;

      log4net.Config.XmlConfigurator.ConfigureAndWatch(fInfo);

      //get the current logging repository for this application 
      ILoggerRepository repository = LogManager.GetRepository();

      //get all of the appenders for the repository 
      IAppender[] appenders = repository.GetAppenders();

      //only change the file path on the 'FileAppenders' 
      foreach (IAppender appender in (from iAppender in appenders
                                      where iAppender is FileAppender
                                      select iAppender))
      {
        FileAppender fileAppender = appender as FileAppender;
        //set the path to your logDirectory using the original file name defined 
        //in configuration 
        fileAppender.File = Path.Combine(logDirectory, Path.GetFileName(fileAppender.File));
        //make sure to call fileAppender.ActivateOptions() to notify the logging 
        //sub system that the configuration for this appender has changed. 
        fileAppender.ActivateOptions();
      }
    }

    // session watch
    void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
    {
      if (isActive)
      {
        // Application.Restart();
        if (e.Reason == SessionSwitchReason.SessionLock)
        {
          log.Debug("SessionLock");
        }
        if (e.Reason == SessionSwitchReason.SessionUnlock)
        {
          this.Show();
          this.WindowState = FormWindowState.Maximized;
          this.TopMost = true;
          log.Debug("SessionUnlock");
        }
      }
    }
    #endregion Initialize

    #region Autostart

    private void Autostart()
    {
      //var sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SYF_Client.appref-ms";
      //var destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\SYF_Client.appref-ms";

      //if (File.Exists(destinationPath))
      //{
      //  File.Delete(destinationPath);
      //}

      //if (!File.Exists(sourcePath))
      //{
      //  CreateShortcutOnDesktop();
      //}
      //File.Copy(sourcePath, destinationPath);
    }

    private static void CreateShortcutOnDesktop()
    {
      Assembly code = Assembly.GetExecutingAssembly();

      AssemblyDescriptionAttribute asdescription = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(code,
                                                    typeof(AssemblyDescriptionAttribute));

      AssemblyCompanyAttribute ascompany = (AssemblyCompanyAttribute)Attribute.GetCustomAttribute(code,
                                            typeof(AssemblyCompanyAttribute));

      string description = asdescription.Description;
      string company = ascompany.Company;
      string desktopPath = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                                      "\\", description, ".appref-ms");

      string shortcutName = string.Empty;
      shortcutName = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Programs),
          "\\", company, "\\", description, ".appref-ms");

      File.Copy(shortcutName, desktopPath, true);
    }
    #endregion

    #region ContentChanger
    public void ChangeContent(UserControl content)
    {
      if (pnContent.InvokeRequired)
      {
        ChangeContentCallback c = new ChangeContentCallback(ChangeContent);
        Invoke(c, content);
      }
      else
      {
        pnContent.Controls.Clear();
        pnContent.Controls.Add(content);
      }
    }

    public void ChangeToUserEnrollment()
    { 
      ChangeContent(UserEnrollment);
    }

    public void ChangeToVerification()
    {
      ChangeContent(Verification);
    }
#endregion

    #region Messages
    // close current message
    public void HideMessage()
    {
      if (MessageControl != null)
      {
        Controls.Remove(MessageControl);
        MessageControl = null;

        Update();
      }
    }

    // show message
    public void ShowMessage(MainMessage msg)
    {
      MessageControl = msg;
      Controls.Add(msg);

      msg.MessageCancel += msg_MessageCancel;
      msg.MessageOk += msg_MessageOk;

      msg.Left = (this.ClientSize.Width - msg.Width) / 2;
      msg.Top = this.ClientSize.Height - msg.Height - 20;

      msg.BringToFront();
      msg.Focus();
    }

    // MessageOk handler only for password verification 
    void msg_MessageOk(object sender)
    {
      HideMessage();

      var mainMessage = (MainMessage)sender;

      if (mainMessage.Type == MessageType.Text)
      {
        UnlockWindows(Runtime.VerifiyUserByPassword(mainMessage.Password));
      }
    }

    void msg_MessageCancel(object sender)
    {
      HideMessage();

      var mainMessage = (MainMessage)sender;

      if (mainMessage.Type == MessageType.EnrollmentSuccess)
      {
        ChangeContent(Verification);
      }
    }
    #endregion

    #region Context Menu

    private void ContextMenue()
    {
      this.notifyIcon.Icon = SystemIcons.Application;

      ContextMenu cm = new ContextMenu();

      MenuItem stateItem = new MenuItem();
      MenuItem webpageItem = new MenuItem();
      MenuItem closeItem = new MenuItem();

      stateItem.Text = "Deaktivieren";
      stateItem.Index = 0;
      stateItem.Click += stateItem_Click;
      cm.MenuItems.Add(stateItem);

      webpageItem.Text = "Webpage";
      webpageItem.Index = 1;
      webpageItem.Click += webpage_Click;
      cm.MenuItems.Add(webpageItem);

      closeItem.Text = "Close";
      closeItem.Index = 3;
      closeItem.Click += closeItem_Click;

      notifyIcon.ContextMenu = cm;
      notifyIcon.DoubleClick += new EventHandler(NotifyIconDoubleClick);
    }

    void stateItem_Click(object sender, EventArgs e)
    {
      MenuItem stateItem = sender as MenuItem;

      if (isActive)
      {
        stateItem.Text = "Aktivieren";

        isActive = false;
      }
      else
      {
        stateItem.Text = "Deaktivieren";
        isActive = true;
      }
    }

    void webpage_Click(object sender, EventArgs e)
    {
      Process.Start(Settings.Default.Webpage);
    }

    void closeItem_Click(object sender, EventArgs e)
    {
      notifyIcon.Icon = null;
      this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
      this.Close();
    }

    void NotifyIconDoubleClick(object sender, EventArgs e)
    {
      this.Show();
      this.WindowState = FormWindowState.Maximized;
    }
    #endregion

    // unlock windows
    public void UnlockWindows(ValidationResponseMessage response)
    {
      HideMessage();

      if (response.Success)
      {
        picBox.StopWebcam();
        WindowState = FormWindowState.Minimized;
        log.Debug("Windows Unlocked");
      }
      else
      {
        var messageControl = new MainMessage(SYF_Server.Messages.MessageType.Error);
        ShowMessage(messageControl);
        log.DebugFormat("Windows locked. ServerResponse :{0}", response);
      }
    }

    // form to tray notification
    private void MainWindow_Resize(object sender, EventArgs e)
    {
      if (FormWindowState.Minimized == this.WindowState)
      {
        KeyboardFilter.isMinimized = true;
        notifyIcon.Visible = true;
        //picBox.StopWebcam();
        this.Hide();
      }
      else if (FormWindowState.Normal == this.WindowState || FormWindowState.Maximized == this.WindowState)
      {
       // picBox.StartWebcam();
        notifyIcon.Visible = false;
        KeyboardFilter.isMinimized = false;
      }
    }

    private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
    }
  }
}
