using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace SYF_Client.Controls
{
  public partial class UserEnrollment : UserControl
  {
    private static readonly ILog log =
                        LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    public MainWindow MainWindow { get; set; }

    public int counter = 5;

    public UserEnrollment(MainWindow mainwindow)
    {
      MainWindow = mainwindow;
      InitializeComponent();
    }

    public void StartWebcam()
    {
      picBox.StartWebcam();
    }

    private void btnSendEnrollment_Click(object sender, EventArgs e)
    {
      SYF_Server.Messages.Message response = MainWindow.Runtime.SendEnrollment(tbUsername.Text, tbPassword.Text, picBox.takePic());
      
      counter = counter - 1;

      if (false)//response.success
      {
        lblInfo.Text = string.Format("Noch {0} Bilder", counter);
      }
      else
      {
        counter = counter + 1;
        var messageControl = new MainMessage(SYF_Server.Messages.MessageType.EnrollmentError);
        MainWindow.ShowMessage(messageControl);
      }

      if (counter == 0)
      {
        var messageControl = new MainMessage(SYF_Server.Messages.MessageType.EnrollmentSuccess);
        MainWindow.ShowMessage(messageControl);
      }

      
      Update();
    }
  }
}
