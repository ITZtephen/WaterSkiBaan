using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan
{
    static class MoveCollection
    {
        private static List<IMoves> _moves = new List<IMoves>() { new EenBeen(), new EenHand(), new Schans() };

        public static List<IMoves> GetWillekeurigeMoves()
        {
            Random rand = new Random();

            List<IMoves> _list = new List<IMoves>();

            var randMoves = rand.Next(0, 5);

            for (var i = 0; i < randMoves; i++)
            {
                var randMoveIndividual = rand.Next(0, _moves.Count);
                _list.Add(_moves[randMoveIndividual]);
                //_moves.RemoveAt[randMoveIndividual];
            }

            return _list;
        }
    }
}
