using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class PdfReportBuilder : IReportBuilder
    {
        private Report report = new Report();
        public void SetHeader(string header)
        {
            report.Header = header;
        }
        public void SetContent(string content)
        {
            report.Content = content;
        }
        public void SetFooter(string footer)
        {
            report.Footer = footer;
        }
        public void AddSection(string sectionName, string sectionContent)
        {
            report.Sections.Add(new Section(sectionName, sectionContent));
        }
        public void SetStyle(ReportStyle style)
        {
            report.Style = style;
        }
        public Report GetReport()
        {
            return report;
        }
    }
}
