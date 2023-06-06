using HamburgerSimulationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Menuler
{
    public class Icecek : IUrun
    {
        public string Ad { get; set; }

        public Icecek(string ad)
        {
            Ad = ad;
        }
    }
}
