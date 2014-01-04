using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Style;

namespace DrawEngin.Element
{
    class LiEle : EleBase
    {
        public LiEle()
        {
            this.Tag = "li";
            this.Style = new StyleInfo(Display.Block, FontStyle.None);
        }
    }
}
