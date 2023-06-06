using HamburgerSimulationProject.Insanlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Restoran
{
    public class Mudur
    {

        public IEnumerable<Kasiyer> kasiyerler = new List<Kasiyer>();
        private List<Kasiyer> _kasiyerler;
        public IEnumerable<Asci> ascilar = new List<Asci>();
        private List<Asci> _ascilar;


        public Mudur(int kasiyerSayisi, int asciSayisi)
        {
            _kasiyerler = new List<Kasiyer>();
            _ascilar = new List<Asci>();

            for (int i = 0; i < kasiyerSayisi; i++)
            {
                Kasiyer kasiyer = new Kasiyer();
                _kasiyerler.Add(kasiyer);
            }

            for (int i = 0; i < asciSayisi; i++)
            {
                Asci asci = new Asci();
                _ascilar.Add(asci);
            }
        }



    }
}
