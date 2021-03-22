using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Leaf : HtmlDom
    {
        string _tag;

        public override void Tag(string tag)
        {
            this._tag = tag;
        }
        public override string GetInnerHtml()
        {
            return $"{this._tag}";
        }
    }
}
