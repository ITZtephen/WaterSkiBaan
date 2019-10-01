using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan
{
    class WachtrijInstructie : IWachtrij
    {
        public int MAX_LENGTE_RIJ = 100;

        public List<Sporter> GetAlleSporters()
        {
            throw new NotImplementedException();
        }

        public void SporterNeemPlaatsInRij(Sporter sporter)
        {
            throw new NotImplementedException();
        }

        public List<Sporter> SportersVerlatenRij(int aantal)
        {
            throw new NotImplementedException();
        }
    }
}
