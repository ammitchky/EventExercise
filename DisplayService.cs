using System;

namespace EventExercise
{
    public class DisplayService
    {
        public DisplayService(FileWriter writer)
        {
            writer.FileWriteComplete += this.WriteCompleteEventHandler;
        }

        private void WriteCompleteEventHandler(object sender, FileWriteMessageArgs args)
        {
            Console.WriteLine("File Write Completed");
            Console.WriteLine($"Appended Text: {args.Content}");
        }
    }
}