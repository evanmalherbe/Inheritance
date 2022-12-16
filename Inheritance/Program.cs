using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
           Text text = new Text();
            text.Copy();
            text.Width = 100;
            text.AddHyperlink("link-" + text.Width);
        }
    }
}
