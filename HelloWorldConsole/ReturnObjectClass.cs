using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class ReturnObjectClass
    {
        public string ReturnString { get; private set; }

        public ReturnObjectClass()
        {
            this.SetReturnString("Hello World");
        }

        public void SetReturnString (string returnString)
        {
            this.ReturnString = returnString ?? "";
        }
    }
}
