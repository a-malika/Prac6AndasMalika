using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class Section
    {
        public string SectionName { get; set; }
        public string SectionContent { get; set; }
        public Section() { }
        public Section(string sectionName, string sectionContent)
        {
            SectionName = sectionName;
            SectionContent = sectionContent;
        }
    }
}
