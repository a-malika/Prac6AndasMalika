using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class HtmlReportBuilder : IReportBuilder
    {
        private Report report = new Report();
        public void SetHeader(string header)
        {
            report.Header = $"<h1>{header}</h1>";
        }
        public void SetContent(string content)
        {
            report.Content = $"<p>{content}</p>";
        }
        public void SetFooter(string footer)
        {
            report.Footer = $"<footer>{footer}</footer>";
        }
        public void AddSection(string sectionName, string sectionContent)
        {
            report.Sections.Add(new Section($"<h2>{sectionName}</h2>", $"<p>{sectionContent}</p>"));
        }
        public void SetStyle(ReportStyle style)
        {
            report.Style = style;
            report.StyleString = $"body {{ background-color: {style.BackgroundColor}; font-size: {style.FontSize}px; color: {style.FontColor}; }}";
        }
        public Report GetReport()
        {
            return report;
        }
    }
}
