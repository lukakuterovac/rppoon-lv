using System;
using System.IO;

namespace ChainOfResponsibility
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLineAsync($"{type} - {DateTime.Now}: {message}");
            }
        }
    }
}