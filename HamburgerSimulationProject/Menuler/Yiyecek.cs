using HamburgerSimulationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Menuler
{
    public class Yiyecek : IUrun
    {
        public string Ad { get; set; }

        public Yiyecek(string ad)
        {
            Ad = ad;
        }
    }
}
