using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class ReportStyle
    {
        public string BackgroundColor { get; set; }
        public string FontColor { get; set; }
        public int FontSize { get; set; }
        public ReportStyle() { }
        public ReportStyle(string backgroundColor, string fontColor, int fontSize)
        {
            BackgroundColor = backgroundColor;
            FontColor = fontColor;
            FontSize = fontSize;
        }
    }
}
