using HamburgerSimulationProject.Menuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject
{
    public class MenuOlustur
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();


            Icecek kola = new Icecek("Kola");
            menu.IcecekEkle(kola);


            Yiyecek hamburger = new Yiyecek("Hamburger");
            menu.YiyecekEkle(hamburger);


        }

    }
}
