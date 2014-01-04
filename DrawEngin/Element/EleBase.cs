using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Style;

namespace DrawEngin.Element
{
   public class EleBase
    {
      public string Tag;
      public string Text;
      public EleBase Parent;
      public List<EleBase> Childern;
      public StyleInfo Style;

    }
}
