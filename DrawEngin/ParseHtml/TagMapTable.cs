using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Element;

namespace DrawEngin.ParseHtml
{
   public class TagMapTable
    {

       static TagMapTable table = null;

       Dictionary<string, ElementType> TagMaps = new Dictionary<string, ElementType>();



       public static TagMapTable Instant
       {
           get
           {
               if (table == null)
               {
                   table = new TagMapTable();

               }
               return table;
           }
       }
       
       private TagMapTable() 
       {
           InitTagMaps();
          
       }

       /// <summary>
       /// 初始化符号表
       /// </summary>
       void InitTagMaps() 
       {
           TagMaps.Add("P",ElementType.P);
           TagMaps.Add("B", ElementType.B);
           TagMaps.Add("I", ElementType.I);
           TagMaps.Add("UL", ElementType.UL);
           TagMaps.Add("LI", ElementType.LI);
           TagMaps.Add("U", ElementType.U);
     
        
       }

     



       /// <summary>
       /// 判断字符是否为tag的组成部分，目前只判读是否为字母
       /// </summary>
       /// <param name="c"></param>
       /// <returns></returns>
       public bool IsValidateChar(char c)
       {
           bool val = false;

           if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
           {
               val = true;
           }

           return val;

       }


       public ElementType MatchEle(string tag) 
       {
           if (string.IsNullOrEmpty(tag))
           {
               return ElementType.NONE;
           }

           tag = tag.ToUpper();
           if (TagMaps.ContainsKey(tag))
           {
               return TagMaps[tag];
           }
           return ElementType.NONE;
       }



    }
}
