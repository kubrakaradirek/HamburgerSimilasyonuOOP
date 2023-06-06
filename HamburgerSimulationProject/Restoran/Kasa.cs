using HamburgerSimulationProject.Insanlar;
using HamburgerSimulationProject.Menuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Restoran
{
    public class Kasa
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.MenuYiyecekler();
            menu.MenuIcecekler();
        }
        
        private Kasiyer Kasiyer { get; }
        public Kasa(Kasiyer kasiyer)
        {
            this.Kasiyer = kasiyer;
            //kasiyer.SiparisAl();
            //kasiyer.Siparisleriİlet();
        }

        public void SiparisinOdemesiniAl(Musteri musteri)
        {
            
        }

        //public void SiparisiMutfagaIlet(Siparis siparis)
        //{
        //    Kasiyer kasiyer = new Kasiyer();
        //    kasiyer.Siparisleriİlet(siparis);
        //}





    }
}
