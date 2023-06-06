using HamburgerSimulationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace HamburgerSimulationProject.Menuler
{

    class Menu : IMenu
    {
        protected List<Icecek> icecekler;
        protected List<Yiyecek> yiyecekler;

        public Menu()
        {
            icecekler = new List<Icecek>();
            yiyecekler = new List<Yiyecek>();
        }

        public void IcecekEkle(Icecek icecek)
        {
            icecekler.Add(icecek);
        }

        public void YiyecekEkle(Yiyecek yiyecek)
        {
            yiyecekler.Add(yiyecek);
        }

        public List<string> MenuYiyecekler()
        {
            List<string> listYiyecek = new List<string>();

            foreach (var item in icecekler)
            {
                listYiyecek.Add(item.ToString());
            }

            return listYiyecek;
        }


        public List<string> MenuIcecekler()
        {
            List<string> listIcecek = new List<string>();

            foreach (var item in yiyecekler)
            {
                listIcecek.Add(item.ToString());
            }

            return listIcecek;
        }

        
    }
}
