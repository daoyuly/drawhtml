using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Element;
using DrawEngin.Layout;

namespace DrawEngin.Document
{
    public class DomBase
    {
       public string ID;
       public EleBase ele;
       public SizeInfo size;

       public DomBase Parent;

       private List<DomBase> children = null;
       public List<DomBase> Children 
       {
           get
           {
               if (children==null)
               {
                   children = new List<DomBase>();
               }
               return children;
           }
       }

     
    }
}
