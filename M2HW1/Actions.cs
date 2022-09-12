namespace M2HW1
{
    public class Actions
    {
        static Actions()
        {
            Logger = Logger.Instance;
        }

        private static Logger Logger { get; }

        public Result InfoMethod()
        {
            Logger.WriteLog(LogType.Info, $"Start method {nameof(InfoMethod)}");

            return new () { Status = true };
        }

        public Result WarningMethod()
        {
            Logger.WriteLog(LogType.Warning, $"Skipped logic in method {nameof(WarningMethod)}");

            return new () { Status = true };
        }

        public Result ErrorMethod()
        {
            return new () { ErrorMessage = "I broke a logic" };
        }
    }
}
