using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface jkou2
    {
        string wbjk();
    }
    public class wbclas:jkou2
    {
        public string wbjk()
        {
            var a = "wbjkou2";
            return a;
        }
    }
}
