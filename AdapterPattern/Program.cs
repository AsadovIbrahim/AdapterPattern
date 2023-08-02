namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LegacyPrinter legacyPrinter = new LegacyPrinter();
            legacyPrinter.Print("Hello Legacy Pattern");

            IPrinter printer=new PrinterAdapter(legacyPrinter);
            printer.Print("Hello Adapter Pattern");
        }
    }
}