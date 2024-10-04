using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class Report
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }
        public List<Section> Sections { get; set; } = new List<Section>();
        public ReportStyle Style { get; set; }
        public string StyleString { get; set; }
        public void Export(string format)
        {
            switch (format.ToLower())
            {
                case "text":
                    using (StreamWriter writer = new StreamWriter("report.txt"))
                    {
                        writer.WriteLine(Header);
                        writer.WriteLine(Content);
                        foreach (var section in Sections)
                        {
                            writer.WriteLine(section.SectionName);
                            writer.WriteLine(section.SectionContent);
                        }
                        writer.WriteLine(Footer);
                    }
                    Console.WriteLine("Text report has been generated: report.txt");
                    break;

                case "html":
                    using (StreamWriter writer = new StreamWriter("report.html"))
                    {
                        writer.WriteLine("<html><head>");
                        writer.WriteLine($"<style>{StyleString}</style>");
                        writer.WriteLine("</head><body>");
                        writer.WriteLine(Header);
                        writer.WriteLine(Content);
                        foreach (var section in Sections)
                        {
                            writer.WriteLine(section.SectionName);
                            writer.WriteLine(section.SectionContent);
                        }
                        writer.WriteLine(Footer);
                        writer.WriteLine("</body></html>");
                    }
                    Console.WriteLine("HTML report has been generated: report.html");
                    break;

                case "pdf":
                    // Логика экспорта для pdf формата
                    Console.WriteLine("ЗВА report has been generated: report.html");
                    break;

                default:
                    Console.WriteLine("Unsupported format.");
                    break;
            }
        }
    }
}
