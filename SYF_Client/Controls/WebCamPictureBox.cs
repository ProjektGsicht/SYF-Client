using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SYF_Client.Controls
{
  public class WebCamPictureBox : PictureBox
  {
    Capture cap;
    Thread CaptureThread;

    Bitmap secureBmp;
    bool draw; // falls sich größe von fenster verändert
    private const int Framerate = 30;
    private const int Framewidth = 1920;
    private const int Frameheight = 1080;

    private Object synclock = new Object();

    delegate void DelUpdateImage(Bitmap bmp);

    public void StartWebcam()
    {
      draw = true;
      cap = new Capture(0);

      SizeMode = PictureBoxSizeMode.Zoom;

      CaptureThread = new Thread(CapThreadFunction);
      cap.ImageGrabbed += new EventHandler(imageGrabbed);

      CaptureThread.Start();
    }

    public void StopWebcam()
    {
      draw = false;
      cap.ImageGrabbed -= new EventHandler(imageGrabbed);
      cap.Stop();
      CaptureThread.Suspend();
    }

    public Byte[] takePic()
    {
      MemoryStream m = new MemoryStream();
      lock (synclock)
      {
        // Thread.Sleep(1000);
        secureBmp.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
        m.Close();
      }
      return m.ToArray();
    }

    void UpdateImage(Bitmap bmp)
    {
      if (draw)
      {
        Image = bmp;

        cap.Stop();
        Refresh();
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
            lock (synclock)
            {
              secureBmp = (Bitmap)bmp.Clone();
              if (InvokeRequired)
              {
                Invoke(new DelUpdateImage(UpdateImage), bmp);
              }
              else
              {
                UpdateImage(bmp);
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        
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
  }
}
