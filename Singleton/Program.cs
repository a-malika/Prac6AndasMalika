using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            logger.SetLogLevel(LogLevel.INFO);
            logger.SetLogFilePath("C:/Users/malik/OneDrive/Рабочий стол/test_prac.txt.txt");
            logger.LoadConfiguration();

            Thread thread1 = new Thread(() => LogMessages(LogLevel.INFO));
            Thread thread2 = new Thread(() => LogMessages(LogLevel.ERROR));
            Thread thread3 = new Thread(() => LogMessages(LogLevel.WARNING));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            logger.ReadLogs(LogLevel.WARNING, new DateTime(2024, 10, 4, 19, 57, 35), new DateTime(2024, 10, 4, 20, 3, 0));
            logger.SaveConfiguration();
        }
        public static void LogMessages(LogLevel level)
        {
            Logger logger = Logger.Instance;
            for (int i = 0; i < 5; i++)
            {
                logger.Log($"Message {i} from thread {Thread.CurrentThread.ManagedThreadId}", level);
            }
        }
    }

}
