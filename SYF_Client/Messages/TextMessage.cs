﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace SYF_Server.Messages
{
    [DataContractAttribute]
    public class TextMessage : Message
    {
        public TextMessage()
        {
            this.Type = MessageType.Text;
        }

        [DataMemberAttribute]
        public string Text;
    }
}
