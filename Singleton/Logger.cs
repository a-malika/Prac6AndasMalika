using iTextSharp.text.log;
using iTextSharp.text.pdf.parser.clipper;
using System;
using System.IO;
using System.Text.Json;
using System.Xml;

namespace Practice6
{
    public class Data
    {
        public LogLevel Variable1 { get; set; }
        public string Variable2 { get; set; }
    }
    public enum LogLevel
    {
        INFO, WARNING, ERROR
    }
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _instanceLock = new object();
        private LogLevel _level;
        private string filePath = "C:/Users/malik/OneDrive/Рабочий стол/test_prac.txt.txt";
        private string configurationFile = "C:/Users/malik/OneDrive/Рабочий стол/test_prac_config.json";
        private Logger()
        {
            Console.WriteLine("Экземпляр создан");
        }
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            _instance = new Logger();
                    }
                }
                return _instance;
            }
        }
        public void Log(string message, LogLevel level)
        {
            if (_level == null || _level <= level)
            {
                lock (_instanceLock)
                {
                    File.AppendAllText(filePath, $"{level}: [{DateTime.Now}] {message}\n");
                }
            }
            else
            {
                lock (_instanceLock)
                {
                    File.AppendAllText(filePath, $"{_level}: [{DateTime.Now}] {message}\n");
                }
            }
        }
        public void SetLogLevel(LogLevel level)
        {
            _level = level;
        }
        public void SetLogFilePath(string path)
        {
            filePath = path;
        }
        public void SaveConfiguration()
        {
            Data data = new Data
            {
                Variable1 = _level,
                Variable2 = filePath
            };
            string jsonString = JsonSerializer.Serialize(data);
            File.WriteAllText(configurationFile, jsonString);
            Console.WriteLine("Конфигурация записана.");
        }
        public void LoadConfiguration()
        {
            string jsonString = File.ReadAllText(configurationFile);
            Data data = JsonSerializer.Deserialize<Data>(jsonString);
            _level = data.Variable1;
            filePath = data.Variable2;
            Console.WriteLine("Конфигурация загружена.");
        }
        public void ReadLogs(LogLevel? logLevel = null, DateTime? startTime = null, DateTime? endTime = null)
        {
            lock (_instanceLock)
            {
                string[] logLines = File.ReadAllLines(filePath);

                foreach (string logLine in logLines)
                {
                    string[] parts = logLine.Split(new[] { ": [", "] " }, StringSplitOptions.None);
                    LogLevel logLineLevel;
                    if (!Enum.TryParse(parts[0], out logLineLevel)) continue;
                    if (logLevel.HasValue && logLineLevel != logLevel.Value) continue;
                    string dateTimeString = parts[1];
                    DateTime logDateTime;
                    if (!DateTime.TryParse(dateTimeString, out logDateTime)) continue;
                    if (startTime.HasValue && logDateTime < startTime.Value) continue;
                    if (endTime.HasValue && logDateTime > endTime.Value) continue;
                    Console.WriteLine(logLine);
                }
            }
        }
    }
}
