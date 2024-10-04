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
            ReportStyle style = new ReportStyle("yellow", "blue", 16);

            // Создаем текстовый отчет
            ReportDirector director = new ReportDirector();
            IReportBuilder textBuilder = new TextReportBuilder();
            director.ConstructReport(textBuilder, style);
            Report textReport = director.GetReport();
            textReport.Export("text");

            // Создаем HTML отчет
            IReportBuilder htmlBuilder = new HtmlReportBuilder();
            director.ConstructReport(htmlBuilder, style);
            Report htmlReport = director.GetReport();
            htmlReport.Export("html");

            // Создаем PDF отчет
            IReportBuilder pdfBuilder = new PdfReportBuilder();
            director.ConstructReport(pdfBuilder, style);
            Report pdfReport = director.GetReport();
            pdfReport.Export("pdf");
        }
    }

}
