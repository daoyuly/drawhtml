using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Style;

namespace DrawEngin.Element
{
   public class PEle:EleBase
    {
       public PEle()
       {
           this.Tag = "p";
           this.Style = new StyleInfo(Display.Block,FontStyle.None);
       }
    }
}
