using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public interface IReportBuilder
    {
        void SetHeader(string header);
        void SetContent(string content);
        void SetFooter(string footer);
        void AddSection(string sectionName, string sectionContent);
        void SetStyle(ReportStyle style);
        Report GetReport();
    }
}