using System;

namespace ExemploRefit
{
    internal class GetAttribute : Attribute
    {
        private string v;

        public GetAttribute(string v)
        {
            this.v = v;
        }
    }
}