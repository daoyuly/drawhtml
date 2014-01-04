using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Style;

namespace DrawEngin.Element
{
    class BEle:EleBase
    {
        public BEle()
        {
            this.Tag = "b";
            this.Style = new StyleInfo(Display.Inline, FontStyle.Blod);
        }
    }
}
