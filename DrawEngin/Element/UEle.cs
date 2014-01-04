using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Style;

namespace DrawEngin.Element
{
    class UEle : EleBase
    {
        public UEle()
        {
            this.Tag = "u";
            this.Style = new StyleInfo(Display.Block, FontStyle.Underline);
        }
    }
}
