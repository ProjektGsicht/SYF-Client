using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using System.Xml;
using System.Reflection;
using SYF_Client.Properties;
using System.IO;
using log4net.Repository;
using log4net.Appender;
using Emgu.CV;
using System.Threading;


namespace SYF_Client
{
  public partial class MainWindow : Form
  {
    //Logging
    private const string Log4NetConfigFileName = "log4net.conf.xml";
    private static readonly ILog log =
                            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    public Runtime Runtime { get; set; }

    public MainWindow()
    {
      InitializeLogging(Settings.Default.LogFilePath);

      InitializeComponent();

      Runtime = new Runtime();

      Runtime.SingleInstance();
      Runtime.InitializeRuntime();
      Runtime.OpenCV.Initialize(picBox);

    }

    //Logging
    public static void InitializeLogging(string logDirectory)
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileInfo fInfo = new FileInfo(Log4NetConfigFileName);
      log4net.Config.XmlConfigurator.Configure();

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

    private void button1_Click(object sender, EventArgs e)
    {
      
    }

  }
}
