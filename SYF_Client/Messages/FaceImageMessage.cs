using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace SYF_Server.Messages
{
    [DataContractAttribute]
    public class FaceImageMessage : Message
    {
        public FaceImageMessage()
        {
            this.Type = MessageType.FaceImage;
        }

        [DataMemberAttribute]
        public string Username;

        public Byte[] FaceImage
        {
            get
            {
              return InternalData;
            }
            set
            {
              InternalData = value;
              //MemoryStream ms = new MemoryStream(value);
              //Image returnImage = Image.FromStream(ms);
            }
        }

        [DataMemberAttribute]
        private byte[] InternalData;
    }
}
