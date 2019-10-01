using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan
{
    interface IWachtrij
    {
        void SporterNeemPlaatsInRij(Sporter sporter);

        List<Sporter> GetAlleSporters();

        List<Sporter> SportersVerlatenRij(int aantal);
    }
}
