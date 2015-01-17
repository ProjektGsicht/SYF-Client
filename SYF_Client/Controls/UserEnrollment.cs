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

    private void btnSendEnrollment_Click(object sender, EventArgs e)
    {
      SYF_Server.Messages.Message response = MainWindow.Runtime.SendEnrollment(tbUsername.Text, tbPassword.Text, MainWindow.picBox.takePic());
      
      counter = counter - 1;
#warning server response
      if (true)//response.success
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
        counter = 5;
        var messageControl = new MainMessage(SYF_Server.Messages.MessageType.EnrollmentSuccess);
        MainWindow.ShowMessage(messageControl);
      }

      Update();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
      MainWindow.ChangeToVerification();
    }

    private void CheckTextBox()
    {
      if (String.IsNullOrWhiteSpace(tbUsername.Text) || String.IsNullOrWhiteSpace(tbPassword.Text))
      {
        btnSendEnrollment.Enabled = false;
      }
      else
      {
        btnSendEnrollment.Enabled = true;
      }
    }

    private void tbPassword_TextChanged(object sender, EventArgs e)
    {
      CheckTextBox();
    }

    private void tbUsername_TextChanged(object sender, EventArgs e)
    {
      CheckTextBox();
    }
  }
}
