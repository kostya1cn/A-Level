class Program
{
    static void Main()
    {
        Logger logger = Logger.Instance;
        logger.LogLevel = LogLevel.Warning;

        Starter.Run(10);
        logger.LogToFile("log.txt");
    }
}