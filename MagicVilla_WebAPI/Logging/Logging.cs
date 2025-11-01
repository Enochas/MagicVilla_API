namespace MagicVilla_WebAPI.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.WriteLine("Error_" + message);
            }
            {
                Console.WriteLine(message);
            }
        }
    }
}
