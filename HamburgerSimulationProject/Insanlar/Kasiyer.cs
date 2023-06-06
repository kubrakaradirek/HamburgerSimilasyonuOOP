using HamburgerSimulationProject.Restoran;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using HamburgerSimulationProject.Exceptions;
using HamburgerSimulationProject.Interfaces;

namespace HamburgerSimulationProject.Insanlar
{   
    public class Kasiyer :Personel, IIcecekHazirla
    {
        List<Siparis> MusteriSiparisListesi;

        public Kasiyer() : base(GorevSecenekleri.Kasiyer)
        {
            MusteriSiparisListesi = new List<Siparis>();
        }
        ~Kasiyer()
        {
            MusteriSiparisListesi.Clear();
            MusteriSiparisListesi = null;
        }        
        public void ServisYap(ServisStandi servisStandi)
        {
           
        }

        public void SiparisAl(Siparis siparis)
        {
            MusteriSiparisListesi.Add(siparis);
        }

        public Siparis Siparisleriİlet()
        {
            if(MusteriSiparisListesi.Count==0)
            {
                throw new ExceptionsYeniSiparisYok();
            }
            Siparis guncel = MusteriSiparisListesi[0];
            MusteriSiparisListesi.Remove(guncel);
            return guncel;
        }

        public void İcecekHazirla()
        {
            throw new NotImplementedException();
        }
    }
}
