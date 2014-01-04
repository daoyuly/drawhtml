using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Style;

namespace DrawEngin.Element
{
    class IEle : EleBase
    {
        public IEle()
        {
            this.Tag = "i";
            this.Style = new StyleInfo(Display.Inline, FontStyle.Italic);
        }
    }
}
