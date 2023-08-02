using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class PrinterAdapter:IPrinter
    {
        private readonly LegacyPrinter legacyPrinter;
        public PrinterAdapter(LegacyPrinter legacyPrinter ) {
            this.legacyPrinter = legacyPrinter;
        }
        public void Print(string text)
        {
            legacyPrinter.Print(text);
        }
    }
}
