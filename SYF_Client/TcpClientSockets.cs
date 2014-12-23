using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using SYF_Client.Properties;
using System.Windows.Forms;
using log4net;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Security.Authentication;
using CERTENROLLLib;
using System.Drawing;

namespace SYF_Client
{
  public class TcpClientSockets
  {
    private static readonly ILog log =
                        LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    #region SslTcpClient

    private static Hashtable certificateErrors = new Hashtable();

    // The following method is invoked by the RemoteCertificateValidationDelegate.
    public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
      if (sslPolicyErrors == SslPolicyErrors.None)
      {
        log.Debug("Certificate OK");
        return true;
      }
      log.DebugFormat("Certificate error: {0}", sslPolicyErrors);

      return false;
    }

    public static void RunSslStream(string serverName)
    {
      // Create a TCP/IP client socket.
      IPHostEntry ipHostInfo = Dns.GetHostEntry(Settings.Default.ServerIp);

      using (TcpClient client = new TcpClient(ipHostInfo.HostName, Settings.Default.ServerPort))
      {
        SslStream sslStream = new SslStream(client.GetStream(), false, new RemoteCertificateValidationCallback(ValidateServerCertificate), null);

        // The server name must match the name on the server certificate.
        try
        {
          sslStream.AuthenticateAsClient(serverName);
        }
        catch (AuthenticationException e)
        {
          log.DebugFormat("Exception: {0}", e.Message);
          if (e.InnerException != null)
          {
            log.DebugFormat("Inner exception: {0}", e.InnerException.Message);
          }
          log.DebugFormat("Authentication failed - closing the connection.");
          client.Close();
          
          return;
        }

        // Encode a test message into a byte array.
        // Signal the end of the message using the "<EOF>".
        byte[] messsage = Encoding.UTF8.GetBytes("Hello from the client.<EOF>");

        // Send hello message to the server. 
        sslStream.Write(messsage);
        sslStream.Flush();

        // Read message from the server.
        string serverMessage = ReadMessage(sslStream);
        log.DebugFormat("Server says: {0}", serverMessage);

        // Close the client connection.
        client.Close();
        log.DebugFormat("Client closed.");
      }
    }

    static string ReadMessage(SslStream sslStream)
    {
      String msg;

      using (StreamReader reader = new StreamReader(sslStream))
      {
        msg = reader.ReadLine();
        reader.Close();
        reader.Dispose();
      }
      return msg; 
    }

    static void WriteMessage(Bitmap bmp)
    { 
      byte[]pic = ImageToByte(bmp);


      //using (StreamWriter writer = new StreamWriter(pic))
      //{
      
      //}
    }

    public static byte[] ImageToByte(Image img)
    {
      ImageConverter converter = new ImageConverter();
      return (byte[])converter.ConvertTo(img, typeof(byte[]));
    }

    #endregion


    public void CheckCertificate()
    {
      var certName = Settings.Default.CertificateName;
      var store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
      
      store.Open(OpenFlags.ReadWrite);

      var existingCert = store.Certificates.Find(X509FindType.FindBySubjectName, certName, false);
      
      if (existingCert.Count == 0)
      {
        //anfordern des Zertifikates 
        //var cert = CreateSelfSignedCertificate(certName);
        //store.Add(cert);
        CheckCertificate();
      }
      else
      {
        X509Certificate2 cert2 = new X509Certificate2(existingCert[0]);
        
        DateTime expireDate = DateTime.Parse(cert2.GetExpirationDateString());
        DateTime today = DateTime.Today;

        if (expireDate < today)
        {
          //anfordern des Zertifikates 
          CheckCertificate();
        }
        else
        {
          TcpClientSockets.RunSslStream(cert2.IssuerName.ToString());
        }
      }
      store.Close();
    }

    public void Initialize()
    {
      CheckCertificate();
    }

    #region TcpClient


    #endregion
  }
}
