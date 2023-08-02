using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class LegacyPrinter
    {
        public void Print(string text) {
        
            Console.WriteLine($"Legacy Printer:{text}");
        }
    }
}
