using HamburgerSimulationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Insanlar
{
    public class Asci : Personel, IIcecekHazirla
    {
        List<Siparis> MutfakSiparisListesi;

        public Asci() : base(GorevSecenekleri.Asci)
        {
            MutfakSiparisListesi = new List<Siparis>();
        }

        public void SiparisAl(Kasiyer kasiyer)
        {
            try
            {
                MutfakSiparisListesi.Add(kasiyer.Siparisleriİlet());
            }
            catch (Exceptions.ExceptionsYeniSiparisYok)
            {
                throw;
            }
        }

        public void YıyecekHazırla()
        {

        }

        public void İcecekHazirla()
        {
            
        }

        public void HazirlananSiparisiStandaKoy()
        {

        }
    }
}
