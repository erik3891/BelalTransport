using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransport
{
    public class Resultat
    {
        public int Lommeregner(List<int> indtægtList, List<int> udgiftsListe)
        {
            int indtægtSum = indtægtList.Sum();
            int udgiftSum = udgiftsListe.Sum();
            return indtægtSum - udgiftSum;
        }
    }
}
