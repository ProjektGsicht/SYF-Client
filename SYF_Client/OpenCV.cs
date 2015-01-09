using Emgu.CV;
using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

    bool draw = true; // falls sich größe von fenster verändert
    private const int Framerate = 30;
    private const int Framewidth = 1920;
    private const int Frameheight = 1080;

    delegate void DelUpdateImage(Bitmap bmp);

    public void Initialize(PictureBox pictureBox)
    {
      picBox = pictureBox;
      InitializeComponents();
    }

    public void InitializeComponents()
    {
      cap = new Capture(0);

      picBox.SizeMode = PictureBoxSizeMode.Zoom;
      
      CaptureThread = new Thread(CapThreadFunction);
      cap.ImageGrabbed += new EventHandler(imageGrabbed);

      CaptureThread.Start();
    }

    void UpdateImage(Bitmap bmp)
    {
      if (draw)
      {
        picBox.Image = bmp;
        cap.Stop();
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

    public Byte[] CreateBmp()
    {
      try
      {
        using (var frame = cap.RetrieveBgrFrame().Copy())
        {
          using (Bitmap bmp = frame.ToBitmap())
          {
            picBox.Image = bmp;
            picBox.Refresh();

            //cap.ImageGrabbed -= new EventHandler(imageGrabbed);
            //CaptureThread.Suspend(); // new one doesn't work!
            MemoryStream m = new MemoryStream();
            bmp.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);

            CloseCam();
            //string location = "C:\\Users\\dsalmer.DRGT\\Desktop\\test.bmp";
            //bmp.Save(location);

            return m.ToArray();
          }
        }
      }
      catch (Exception ex)
      {
        log.Debug(ex);
        return new Byte[0];
      }
    }

    public void CloseCam()
    {
      cap.Stop();
      cap.ImageGrabbed -= new EventHandler(imageGrabbed);
      //CaptureThread.Abort();
      cap.Dispose();
    }
    #endregion
  }
}
