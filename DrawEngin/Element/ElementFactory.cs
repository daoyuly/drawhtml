using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawEngin.Element
{
   public class ElementFactory
    {
       //static ElementFactory _factory = null;

       ElementFactory()
       {

       }
       
       public static EleBase CreateEle(ElementType tag)
       {
           EleBase ele = null;
           switch (tag)
           {
               case ElementType.P:
                   {
                       ele = new PEle();
                       break;
                   }
               case ElementType.B:
                   {
                       ele = new BEle();
                       break;
                   }
               case ElementType.I:
                   {
                       ele = new IEle();
                       break;
                   }
               case ElementType.LI:
                   {
                       ele = new LiEle();
                       break;
                   }
               case ElementType.UL:
                   {
                       ele = new UlEle();
                       break;
                   }
               case ElementType.U:
                   {
                       ele = new UEle();
                       break;
                   }
               default:
                   break;
           }

           return ele;

       }

    }
}
