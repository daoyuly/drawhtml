using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawEngin.Style
{
    public enum Display
    {

        Inline,
        Block

    }

    public enum FontStyle
    {
        None,
        Blod,
        Underline,
        Italic
    }
    public class StyleInfo
    {
        public Display Display = Display.Inline;
        public FontStyle Font = FontStyle.None;

        public StyleInfo(Display display, FontStyle font)
        {
            this.Display = display;
            this.Font = font;
        }
    }
}
