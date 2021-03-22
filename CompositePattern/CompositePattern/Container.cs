using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Container : HtmlDom
    {
        protected List<HtmlDom> _children = new List<HtmlDom>();
        string _tag;
        public override void Tag(string tag)
        {
            this._tag = tag;
        }
        public override void Add(HtmlDom element)
        {
            this._children.Add(element);
        }

        public override void Remove(HtmlDom element)
        {
            this._children.Remove(element);
        }

        public override string GetInnerHtml()
        {
            int i = 0;
            string result = $"{this._tag}(";

            foreach (HtmlDom element in this._children)
            {
                result += element.GetInnerHtml();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }
            return result + ")";
        }
    }
}
