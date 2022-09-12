using System.Text;

namespace M2HW1
{
    public class Logger
    {
        static Logger()
        {
            Instance = new Logger();
        }

        private Logger()
        {
            Logs = new StringBuilder();
        }

        public static Logger Instance { get; }

        private StringBuilder Logs { get; set; }

        public void WriteLog(LogType logType, string message)
        {
            var log = $"{DateTime.UtcNow:HH:mm:ss}: {logType}: {message}";

            WriteLogToConsole(log);
            Logs.AppendLine(log);
        }

        public void WriteLogsToFile()
        {
            File.WriteAllText("log.txt", Logs.ToString());
        }

        private void WriteLogToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
