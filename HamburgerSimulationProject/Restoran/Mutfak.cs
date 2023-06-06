using HamburgerSimulationProject.Insanlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Restoran
{
    public class Mutfak
    {
        List<Mutfak> MutfakSiparisListesi;

        private Asci Asci { get; }
      
        public Mutfak(Asci asci)
        {
            MutfakSiparisListesi = new List<Mutfak>();
            this.Asci = asci;           
        }
    }
}
