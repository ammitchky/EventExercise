using System;
using System.IO;
using System.Threading;

namespace EventExercise
{
    public class FileWriter
    {
        public event EventHandler<FileWriteMessageArgs> FileWriteComplete;

        public void WriteToFile(string content, string path) {
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine(content);
            }
            OnRaiseWriteCompleteEvent(new FileWriteMessageArgs(content));
        }

        protected virtual void OnRaiseWriteCompleteEvent(FileWriteMessageArgs args) 
        {
            if (this.FileWriteComplete != null) this.FileWriteComplete.Invoke(this, args);
        }
    }
}