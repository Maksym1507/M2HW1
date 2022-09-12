namespace M2HW1
{
    public class Starter
    {
        static Starter()
        {
            Logger = Logger.Instance;
        }

        private static Logger Logger { get; }

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                var randomValue = new Random().Next(1, 4);

                Result result = randomValue switch
                {
                    1 => new Actions().InfoMethod(),
                    2 => new Actions().WarningMethod(),
                    3 => new Actions().ErrorMethod(),
                    _ => null
                };

                if (!result.Status)
                {
                    Logger.WriteLog(LogType.Error, $"Action failed by a reason: {result.ErrorMessage}");
                }
            }

            Logger.WriteLogsToFile();
        }
    }
}
