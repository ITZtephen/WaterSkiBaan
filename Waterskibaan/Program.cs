using System;

namespace Waterskibaan
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOpracht();
        }

        private static void TestOpracht()
        {
            Sporter sporter = new Sporter();
            Waterskibaan waterskibaan = new Waterskibaan();
            waterskibaan.SporterStart(sporter);
        }
    }
}
