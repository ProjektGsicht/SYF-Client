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

namespace SYF_Client
{
  public partial class MainWindow : Form
  {
    //Logging
    private const string Log4NetConfigFileName = "log4net.conf.xml";
    private static readonly ILog log =
                            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    public Runtime Runtime { get; set; }

    private UserControl MessageControl { get; set; }
    private Message Message { get; set; }

    private NotifyIcon notifyIcon = new NotifyIcon();
 
    public MainWindow()
    {
      InitializeLogging(Settings.Default.LogFilePath);

      InitializeComponent();
      //this.notifyIcon.Icon = ((System.Drawing.Icon)(Resources.ResourceManager.GetObject("logo_header.png")));
      this.notifyIcon.Icon = SystemIcons.Application;
      //notifyIcon.DoubleClick += new EventHandler(NotifyIconDoubleClick);
      
      // No Borders
      //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      //this.WindowState = FormWindowState.Maximized;
      //this.Bounds = Screen.FromControl(this).Bounds;

      // Initialize Runtime
      Runtime = new Runtime();
      Runtime.InitializeRuntime();
      //Runtime.OpenCV.Initialize(picBox);

      //new
      picBox.StartWebcam();

      ContextMenue();
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

    // unlock windows
    private void UnlockWindows(string response)
    {
      HideMessage();
      
      if (string.IsNullOrEmpty(response))
      {
       // unlock windows
        picBox.StopWebcam();
        picBox.Dispose();
        
        WindowState = FormWindowState.Minimized;
      }
      else
      {
        var messageControl = new MainMessage(SYF_Server.Messages.MessageType.Error);
      }
    }

    // start verification with fingerprint
    private void btnFingerprint_Click(object sender, EventArgs e)
    {
      // start fingerprint
      var messageControl = new MainMessage(SYF_Server.Messages.MessageType.Fingerprint);
      ShowMessage(messageControl);

      Update();

    }

    // start verification with faceimage
    private void btnPic_Click(object sender, EventArgs e)
    {
      var messageControl = new MainMessage(SYF_Server.Messages.MessageType.FaceImage);
      ShowMessage(messageControl);

      Update();

      UnlockWindows(Runtime.VerifiyUserByPic(picBox.takePic()));
    }

    // start verification with password
    private void btnPassword_Click(object sender, EventArgs e)
    {
      var messageControl = new MainMessage(SYF_Server.Messages.MessageType.Text);
      ShowMessage(messageControl);
    }

    // close current message
    public void HideMessage()
    {
      if (MessageControl != null)
      {
        Controls.Remove(MessageControl);
        MessageControl = null;

        //Update();
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
      msg.Top = this.ClientSize.Height - msg.Height;

      msg.BringToFront();
      msg.Focus();

      // close webcam
      if (msg.Type != SYF_Server.Messages.MessageType.FaceImage)
      {
        //Runtime.OpenCV.CloseCam();
      }
    }

    // MessageOk handler only for password verification 
    void msg_MessageOk(object sender)
    {
      HideMessage();

      var mainMessage = (MainMessage)sender;
      UnlockWindows(Runtime.VerifiyUserByPassword(mainMessage.Password));

      var messageControl = new MainMessage(0);
      ShowMessage(messageControl);
    }

    void msg_MessageCancel(object sender)
    {
      //Controls.Remove(MessageControl);
      //MessageControl = null;

      //// restart webcam
      //Runtime.OpenCV.InitializeComponents();

      HideMessage();
      //Runtime = new Runtime();
      //Runtime.InitializeRuntime();
      //Runtime.OpenCV.Initialize(picBox);
    }

    // form to tray notification
    private void MainWindow_Resize(object sender, EventArgs e)
    {
      if (FormWindowState.Minimized == this.WindowState)
      {
        notifyIcon.Visible = true;
        //notifyIcon.ShowBalloonTip(500);
        this.Hide();
      }
      else if (FormWindowState.Normal == this.WindowState || FormWindowState.Maximized == this.WindowState)
      {
        notifyIcon.Visible = false;
        picBox = new WebCamPictureBox();
        picBox.StartWebcam();

        //picBox.StartWebcam();
        // Runtime.OpenCV.InitializeComponents();
      }
    }

    private void ContextMenue()
    {
      ContextMenu cm = new ContextMenu();
      MenuItem item = new MenuItem();

      item.Text = "Webpage";
      item.Index = 1;
      item.Click += new EventHandler(item_Click);
      cm.MenuItems.Add(item);

      notifyIcon.ContextMenu = cm;
      notifyIcon.DoubleClick += new EventHandler(NotifyIconDoubleClick);
    }

    void item_Click(object sender, EventArgs e)
    {
      Process.Start("http://google.com");
    }

    void NotifyIconDoubleClick(object sender, EventArgs e)
    {
      if (this.IsDisposed)
      { 
        
      }

      // Activate the form.
      this.Show();
      //this.BringToFront();
      //this.Update();
      //Activate();
      //this.WindowState = FormWindowState.Maximized;
    }

    private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
    {
      notifyIcon.Icon = null;
    }
  }
}
