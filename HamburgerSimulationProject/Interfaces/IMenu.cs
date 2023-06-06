using HamburgerSimulationProject.Menuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Interfaces
{
    public interface IMenu
    {
        void IcecekEkle(Icecek icecek);
        void YiyecekEkle(Yiyecek yiyecek);
        public List<string> MenuYiyecekler();
        public List<string> MenuIcecekler();
    }
}
