using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan
{
    class EenHand : IMoves
    {
        public int Move()
        {
            Random random = new Random();
            int gelukt = random.Next(100);
            if (gelukt < 80)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
    }
}
