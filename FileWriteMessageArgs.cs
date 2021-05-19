namespace EventExercise
{
    public class FileWriteMessageArgs
    {
        public string Content { get; set; }
        public FileWriteMessageArgs(string content)
        {
            Content = content;
        }
    }
}