using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class DataPresentation
    {
        private IMethod _method;

        public DataPresentation()
        {

        }

        public DataPresentation(IMethod method)
        {
            this._method = method;
        }

        public void SetMethod(IMethod method)
        {
            this._method = method;
        }
    }
}
