using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SYF_Client
{
  public class Runtime
  {
    //Logging
    private static readonly ILog log =
                      LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    public OpenCV OpenCV;
    public TcpClientSockets TcpSockets;

    public void InitializeRuntime()
    { 
      OpenCV = new OpenCV();
      TcpSockets = new TcpClientSockets();

      TcpSockets.Initialize(); 
    }

    public void saveBitmap(Bitmap bmp)
    { 
      
    }


    public void SingleInstance()
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
