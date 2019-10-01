using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan
{
    class EenBeen : IMoves
    {
        public int Move()
        {
            Random random = new Random();
            int gelukt = random.Next(100);
            if (gelukt < 50)
            {
                return 20;
            }
            else
            {
                return 0;
            }
        }
    }
}
