using Emgu.CV;
using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SYF_Client
{
  public class OpenCV
  {
    private static readonly ILog log =
                        LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    #region face recognition

    Capture cap;
    Thread CaptureThread;
    PictureBox picBox; // picBox Mainwindow
    
    bool draw = true;
    private const int Framerate = 30;
    private const int Framewidth = 1920;
    private const int Frameheight = 1080;

    delegate void DelUpdateImage(Bitmap bmp);

    public void Initialize(PictureBox pictureBox)
    {
      picBox = pictureBox;
      startWebcam();
    }

    void UpdateImage(Bitmap bmp)
    {
      if (draw)
      {
        picBox.Image = bmp;
        picBox.Refresh();
      }
    }

    void imageGrabbed(Object sender, EventArgs e)
    {
      try
      {
        using (var frame = ((Capture)sender).RetrieveBgrFrame().Copy())
        {
          using (Bitmap bmp = frame.ToBitmap())
          {
            if (picBox.InvokeRequired)
            {
              picBox.Invoke(new DelUpdateImage(UpdateImage), bmp);
            }
            else
            {
              UpdateImage(bmp);
            }
          }
        }
      }
      catch (Exception ex)
      {
        log.Debug(ex);
      }
    }

    private void CapThreadFunction()
    {
      cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_COUNT, Framerate);
      cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, Framewidth);
      cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, Frameheight);

      cap.Start();

      while (true)
      {
        cap.Grab();
        Thread.Sleep(1000 / Framerate);
      }
    }

    public void startWebcam()
    {
      cap = new Capture(0);

      picBox.SizeMode = PictureBoxSizeMode.Zoom;

      cap.ImageGrabbed += new EventHandler(imageGrabbed);

      CaptureThread = new Thread(CapThreadFunction);
      CaptureThread.Start();
    }
    #endregion
  }
}
