using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriver
{
    public class MessageSender
    {
        public EMesasgeType MessageType { get; set; }
        public string Message { get; set; }
        public void OutputMesasge(string message, EMesasgeType messageType)
        {
            Console.WriteLine("触发得到一个消息,消息体：" + message + ";消息类型：" + messageType.ToString());
            this.Message = message;
            this.MessageType = messageType;
        }
    }
    public enum EMesasgeType
    {
        Info,
        Error,
        Warn
    }
}
