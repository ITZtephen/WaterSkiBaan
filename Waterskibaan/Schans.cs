using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan
{
    class Schans : IMoves
    {
        public int Move()
        {
            Random random = new Random();
            int gelukt = random.Next(100);
            if (gelukt < 20)
            {
                return 69;
            }
            else
            {
                return 0;
            }
        }
    }
}
