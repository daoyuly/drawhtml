using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawEngin.Element;
using DrawEngin.Document;

namespace DrawEngin.ParseHtml
{
    public interface IParseStrategy
    {
        DomBase Parse();
    }
}
