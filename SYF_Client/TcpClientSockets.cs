using log4net;
using SYF_Client.Misc;
using SYF_Client.Properties;
using SYF_Server.Messages;
using System;
using System.Drawing;
using System.Net.Sockets;

namespace SYF_Client
{
  public class TcpClientSockets
  {
    // logging
    private static readonly ILog log =
                        LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    // open new Tcp network stream
    TcpClient client;
    NetworkStream stream;

    public void Initialize()
    {
      client = new TcpClient(Settings.Default.ServerIp, Settings.Default.ServerPort);
      stream = client.GetStream();      
    }

    public string FaceMessage(string user, Byte[] bmp)
    {
      FaceImageMessage msg = new FaceImageMessage()
      {
        FaceImage = bmp,
        Username = user,
        Type = MessageType.FaceImage
      };

     return JsonHelper.Deserialize<String>(WriteMessage(JsonHelper.Serialize<FaceImageMessage>(msg)));
    }

    public string FingerMessage(string user, Bitmap bmp)
    {
      FingerprintMessage msg = new FingerprintMessage()
      {
        Fingerprint = bmp,
        Username = user,
        Type = MessageType.Fingerprint
      };

      return JsonHelper.Deserialize<String>(WriteMessage(JsonHelper.Serialize<FingerprintMessage>(msg)));
    }

    public string PasswordMessage(string user, string password)
    {
      TextMessage msg = new TextMessage()
      {
        Text = password,
        Type = MessageType.Fingerprint
      };

      return JsonHelper.Deserialize<String>(WriteMessage(JsonHelper.Serialize<TextMessage>(msg)));
    }

    // write/read messages
    private string WriteMessage(String msg)
    {
      try
      {
        Initialize();

        String responseData = String.Empty;
        Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
        Int32 bytes;

        // Write Stream
        stream.Write(data, 0, data.Length);

        // Read Result
        data = new Byte[32];
        bytes = stream.Read(data, 0, data.Length);
        responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

        // Close everything.
        stream.Close();
        client.Close();

        return responseData;
      }
      catch (Exception ex)
      {
        log.Debug(string.Format("Message failed:  {0}", ex.Data));
        return ex.Message;
      }   
    }
  }
}

