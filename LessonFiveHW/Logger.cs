public class Logger
{
    private static Logger? instance;
    public List<Result> logList;
    private LogLevel logLevel;

    private Logger()
    {
        logList = new List<Result>();
    }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    public LogLevel LogLevel
    {
        get { return logLevel; }
        set { logLevel = value; }
    }

    public void Log(Result result)
    {
        if (result.Status == logLevel)
        {
            logList.Add(result);
            Console.WriteLine($"{result.DateTime}: {result.Status}: {result.Message}");
        }
    }

    public void LogToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Result result in logList)
            {
                writer.WriteLine($"{result.DateTime}: {result.Status}: {result.Message}");
            }
        }
    }
}