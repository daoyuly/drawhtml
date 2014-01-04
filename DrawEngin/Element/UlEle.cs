using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Style;

namespace DrawEngin.Element
{
    class UlEle : EleBase
    {
        public UlEle()
        {
            this.Tag = "ul";
            this.Style = new StyleInfo(Display.Block, FontStyle.None);
        }
    }
}
