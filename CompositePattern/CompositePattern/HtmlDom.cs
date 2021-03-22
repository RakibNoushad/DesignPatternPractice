using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    abstract class HtmlDom
    {
        public virtual void Tag(string tag) { }
        public virtual void Add(HtmlDom element){ }
        public virtual void Remove(HtmlDom element) { }
        public abstract string GetInnerHtml();

    }
}
