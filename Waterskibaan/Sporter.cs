using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Waterskibaan
{
    class Sporter
    {
        private int _aantalRondenNogTeGaan = 0;
        private Zwemvest _zwemvest;
        private Skies _skies;
        private Color _kledingKleur;
        private List<IMoves> _moves;
        private int _punten;

        public int AantalRondenNogTeGaan
        {
            get => _aantalRondenNogTeGaan;
            set => _aantalRondenNogTeGaan = value;
        }

        public Zwemvest Zwemvest
        {
            get => _zwemvest;
            set => _zwemvest = value;
        }
        public Skies Skies
        {
            get => _skies;
            set => _skies = value;
        }
        public Color KledingKleur
        {
            get => _kledingKleur;
            set => _kledingKleur = value;
        }
        public List<IMoves> Moves
        {
            get => _moves;
            set => _moves = value;
        }
        public int Punten
        {
            get => _punten;
            set => _punten = value;
        }

        public Sporter()
        {
            Zwemvest = new Zwemvest();
            Skies = new Skies();

            Moves = MoveCollection.GetWillekeurigeMoves();

            Punten = 0;

            foreach (var item in Moves)
            {
                Punten += item.Move();
            }

        }
    }
}
