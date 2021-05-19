using System;

namespace EventExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileWriter = new FileWriter();
            var displayService = new DisplayService(fileWriter);

            fileWriter.WriteToFile($"Test message > Time - {DateTime.Now}", "text.txt");
        }
    }
}
