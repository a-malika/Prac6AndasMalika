using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class ReportDirector
    {
        private IReportBuilder _reportBuilder;
        public void ConstructReport(IReportBuilder builder, ReportStyle style)
        {
            _reportBuilder = builder;
            Console.WriteLine("Write the header:");
            _reportBuilder.SetHeader(Console.ReadLine());
            Console.WriteLine("Write the content:");
            _reportBuilder.SetContent(Console.ReadLine());
            Console.WriteLine("Write the footer:");
            _reportBuilder.SetFooter(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Do you want to add a section?");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("Write section's name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write section's content:");
                    string content = Console.ReadLine();
                    _reportBuilder.AddSection(name, content);
                }
                else break;
            }
            _reportBuilder.SetStyle(style);
        }
        public Report GetReport()
        {
            return _reportBuilder.GetReport();
        }
    }
}
