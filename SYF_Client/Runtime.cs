using log4net;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using SYF_Server.Messages;

namespace SYF_Client
{
  public class Runtime
  {
    //Logging
    private static readonly ILog log =
                      LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    public TcpClientSockets TcpSockets;

    public String UserName;

    public void InitializeRuntime()
    { 
      TcpSockets = new TcpClientSockets();

      // get current username
      UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

      SingleInstance();
    }

    public ValidationResponseMessage SendEnrollment(string username, string password, Byte[] bmt)
    {
      return TcpSockets.UserMessage(username, password, UserName, bmt);
    }

    // verify user by fingerprint
    public string VerifiyUserByFinger()
    {
      //return TcpSockets.FingerMessage(UserName, );
      return "nananana batman";
    }

    // verify user by faceImage
    public ValidationResponseMessage VerifiyUserByPic(byte[] pic)
    {
      //return TcpSockets.FaceMessage(UserName, OpenCV.CreateBmp());
      return TcpSockets.FaceMessage(UserName, pic);
    }

    // verify by password
    public ValidationResponseMessage VerifiyUserByPassword(string password)
    {
      return TcpSockets.PasswordMessage(UserName, password);
    }

    // check for multi Instance
    private void SingleInstance()
    {
      try
      {
        if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
        {
          log.Debug("2nd instance found");
          System.Diagnostics.Process.GetCurrentProcess().Kill();
          log.Debug("2nd instance killed");
        }
      }
      catch (Exception)
      {
        log.Debug("2nd instance killing isn't possible");
      }
    }
  }
}
