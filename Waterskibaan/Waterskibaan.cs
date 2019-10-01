using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Waterskibaan
{
    class Waterskibaan
    {
        LijnenVoorraad _lijnenVoorraad;
        Kabel _kabel;
        public Waterskibaan()
        {
            _lijnenVoorraad = new LijnenVoorraad();

            for (int i = 0; i < 15; i++)
            {
                _lijnenVoorraad.LijnToevoegenAanRij(new Lijn());
            }

            _kabel = new Kabel();
        }
        public void VerplaatsKabel()
        {
            _kabel.VerschuifLijnen();
            _lijnenVoorraad.LijnToevoegenAanRij(_kabel.VerwijderLijnVanKabel());
        }

        override
        public string ToString()
        {
            return (_lijnenVoorraad.ToString() + " + " + _kabel.ToString());
        }

        public void SporterStart(Sporter sp)
        {
            if (sp.Zwemvest == null)
            {
                throw new Exception("Je moet nog een zwemvest pakken");
            }
            if (sp.Skies == null)
            {
                throw new Exception("Je moet nog een skies pakken");
            }

            if (!_kabel.IsStartPositieLeeg()) { return; }
            Random rand = new Random();
            sp.AantalRondenNogTeGaan = rand.Next(1, 2);

            List<Color> list = new List<Color>() { Color.Blue, Color.Green, Color.Red, Color.Yellow };
            sp.KledingKleur = list[rand.Next(0,3)];


            Lijn _lijn = _lijnenVoorraad.VerwijderEersteLijn();
            _lijn.Sporter = sp;
            _kabel.NeemLijnInGebruik(_lijn);
        }
    }
}
