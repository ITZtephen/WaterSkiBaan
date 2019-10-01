using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Waterskibaan
{
    class Kabel
    {
        private LinkedList<Lijn> _lijnen = new LinkedList<Lijn>();

        public bool IsStartPositieLeeg()
        {
            return _lijnen.All(lijn => lijn.PositieOpDeLijn != 0);
        }

        public void NeemLijnInGebruik(Lijn lijn)
        {
            if (IsStartPositieLeeg())
            {
                _lijnen.AddFirst(lijn);
            }
        }

        public void VerschuifLijnen()
        {
            foreach (Lijn lijn in _lijnen)
            {
                lijn.PositieOpDeLijn += 1;

                if (lijn.PositieOpDeLijn == 10)
                {
                    lijn.PositieOpDeLijn = 0;
                    lijn.Sporter.AantalRondenNogTeGaan = -1;
                }
            }
        }

        public Lijn VerwijderLijnVanKabel()
        {
            foreach (Lijn lijn in _lijnen)
            {
                if (lijn.PositieOpDeLijn == 9 && lijn.Sporter.AantalRondenNogTeGaan == 0)
                {
                    _lijnen.Remove(lijn);
                    return lijn;
                }
            }

            return null;
        }

        override
        public string ToString()
        {
            string str = "";

            foreach (Lijn lijn in _lijnen)
            {
                str += lijn.PositieOpDeLijn + " | ";
            }

            return str;
        }
    }
}
