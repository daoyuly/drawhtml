using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Document;
using DrawEngin.Element;

namespace DrawEngin.ParseHtml
{
    /// <summary>
    /// 1 < p> 解释为文本
    /// </summary>


    enum NodeState
    {
        BeginTag,
        EndTag,
        Text
    }
    public class FsmParser : IParseStrategy
    {

        #region 私有变量

        DomBase root = null;
        string html = string.Empty;

        #endregion

        int CurentPtr = 0;


        public string Html
        {
            get { return html; }
            set { html = value; }
        }

        public DomBase Root
        {
            get { return root; }
            set { root = value; }
        }

        public FsmParser()
        {
            Root = new DomBase() { ID = " root", ele = null, size = null };
        }
        public void Parse()
        {

            if (string.IsNullOrEmpty(html))
            {
                return;
            }



            DomBase parent = Root;
            DomBase current = null;


            while (CurentPtr <= Html.Length)
            {


                NodeState state = GetState();

                switch (state)
                {
                    case NodeState.BeginTag:
                        {
                            //CurentPtr++;
                            EleBase ele = ParseBeginTag();
                            if (ele == null)
                            {
                                return;
                            }
                            current = new DomBase();
                            current.ele = ele;
                            Root.Children.Add(current);


                            break;
                        }
                    case NodeState.EndTag:


                        break;
                    case NodeState.Text:

                        break;
                    default:
                        break;
                }


                CurentPtr++;
            }




        }



        /// <summary>
        /// 该算法是解析类似<p>的标签。不解析标签内属性。
        /// 方便扩展，使用状态控制流
        /// </summary>
        /// <returns></returns>
        EleBase ParseBeginTag()
        {
            EleBase ele = null;
            int i = CurentPtr;
            string tag = "";
            List<char> ctag = new List<char>();
            bool inTag = false;
            bool finshed = false;
            while (i < Html.Length&&!finshed)
            {
                char c = Html[i];
                switch (c)
                {
                    case '<':
                        {
                            inTag = true;
                            break;
                        }
                    case ' ':
                        {
                            if (inTag)
                            {
                                finshed = true;
                            }
                            break;
                        }
                    case '>':
                        {
                            finshed = true;
                            break;
                        }
                    default:
                        {
                          
                            if (TagMapTable.Instant.IsValidateChar(c))
                            {
                                char tmp = c;
                                ctag.Add(tmp);

                            }
                          
                            break;
                        }
                }

                i++;
            }

            tag = new string(ctag.ToArray());
            ElementType type = TagMapTable.Instant.MatchEle(tag);
            ele = ElementFactory.CreateEle(type);

            CurentPtr = i;

            return ele;
        }

        /// <summary>
        /// 该算法是解析类似</p>的标签。不解析标签内属性。
        /// 方便扩展，使用状态控制流
        /// </summary>
        /// <returns></returns>
        EleBase ParseEndTag()
        {
            EleBase ele = null;
            int i = CurentPtr;
            string tag = "";
            List<char> ctag = new List<char>();
            bool inTag = false;
            bool finshed = false;
            while (i < Html.Length && !finshed)
            {
                char c = Html[i];
                switch (c)
                {
                    case '<':
                        {
                            inTag = true;
                            break;
                        }
                    case ' ':
                        {
                            if (inTag)
                            {
                                finshed = true;
                            }
                            break;
                        }
                    case '>':
                        {
                            finshed = true;
                            break;
                        }
                    case '/':
                        {
                            
                            break;
                        }
                    default:
                        {

                            if (TagMapTable.Instant.IsValidateChar(c))
                            {
                                char tmp = c;
                                ctag.Add(tmp);

                            }

                            break;
                        }
                }

                i++;
            }

            tag = new string(ctag.ToArray());
            ElementType type = TagMapTable.Instant.MatchEle(tag);
            ele = ElementFactory.CreateEle(type);

            CurentPtr = i;

            return ele;
        }

        /// <summary>
        /// 判断状态
        /// 
        /// 注意CurentPtr + 1的边界
        /// </summary>
        /// <returns></returns>
        NodeState GetState()
        {
            NodeState state = NodeState.Text;

            char current = Html[CurentPtr];
            if (CurentPtr + 1 <= Html.Length)
            {

                char next = Html[CurentPtr + 1];
                if (current == '<' && next != '/')
                {
                    state = NodeState.BeginTag;
                }
                else if (current == '<' && next == '/')
                {
                    state = NodeState.EndTag;
                }
                else if (current == '>' && next != '/')
                {
                    state = NodeState.Text;
                }
            }
            return state;
        }
    }
}
