using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan
{
    class LijnenVoorraad
    {
        private Queue<Lijn> _lijnen = new Queue<Lijn>();

        public void LijnToevoegenAanRij(Lijn lijn)
        {
            _lijnen.Enqueue(lijn);
        }

        public Lijn VerwijderEersteLijn()
        {
            if (_lijnen.Count == 0)
            {
                return null;
            }
            else
            {
                return _lijnen.Dequeue();
            }
        }

        public int GetAantalLijnen()
        {
            return _lijnen.Count;
        }

        override
        public string ToString()
        {
            return (_lijnen.Count + " lijnen op voorraad");
        }
    }
}
