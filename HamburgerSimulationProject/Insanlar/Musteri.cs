using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Insanlar
{
    public class Musteri
    {
        public Siparis Siparisim { get; set; }

        public void SiparisVer(Siparis siparis)
        {
            this.Siparisim= siparis;
        }

    }
}
