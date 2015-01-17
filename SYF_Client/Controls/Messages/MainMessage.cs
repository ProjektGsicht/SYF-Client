using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SYF_Client.Controls.Messages;
using SYF_Server.Messages;
using log4net;

namespace SYF_Client.Controls
{
  public partial class MainMessage : UserControl
  {
    // logging
    private static readonly ILog log =
                        LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    public string Password;
    public MessageType Type;

    public event MessageOkHandler MessageOk;
    public event MessageCancelHandler MessageCancel;

    protected virtual void OnOk()
    {
      MessageOkHandler handler = MessageOk;
      if (handler != null) handler(this);
    }
    
    protected virtual void OnCancel()
    {
      MessageCancelHandler handler = MessageCancel;
      if (handler != null) handler(this);
    }

    public MainMessage(MessageType type)
    {
      InitializeComponent();
      Type = type;

      // reset mainMessage
      btnCancel.Text = "Abbrechen";
      tlpMainMessage.RowStyles[2].Height = 0;
      tbPassword.Visible = false;
      btnSend.Visible = false;

      // set messagetype 
      switch (type)
      {
        case MessageType.FaceImage:
          lblMessage.Text = "Einen moment Geduld ihr Bild wird überprüft.";
          break;
        case MessageType.Fingerprint:
          lblMessage.Text = "Bitte fahren Sie mit dem Finger über den Sensor.";
          break;
        case MessageType.Text:
          lblMessage.Text = "Geben Sie nun Ihr Password ein.";
          this.tlpMainMessage.RowStyles[2].Height = 35;
          tbPassword.Visible = true;
          btnSend.Visible = true;
          break;
        case MessageType.Error:
          lblMessage.Text = "Authentifizierung fehlgeschlagen";
          btnCancel.Text = "Ok";
          break;
        case MessageType.EnrollmentSuccess:
          lblMessage.Text = "Verifizieren Sie sich nun über die Webcam!";
          btnCancel.Text = "OK";
          break;
        default:
          lblMessage.Text = "Bitte einen moment Geduld";
          break;
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      OnCancel();
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
      Password = tbPassword.Text;
      OnOk();
    }
  }
}
