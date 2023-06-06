using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Insanlar
{
    public enum GorevSecenekleri { Asci, Kasiyer}

    /// <summary>
    /// Bu sınıftan herhangi bir nesne üretilmesini istemediğimiz için abstract olarak belirttik
    /// 
    /// </summary>
    public abstract class Personel : Insan
    {    
        private GorevSecenekleri gorev; //!!!!!!protected!!!!!!!/////
        public GorevSecenekleri Gorev
        {
            get { return this.gorev; }
            private set { this.gorev = value;}           
        }

        public Personel(GorevSecenekleri Gorev)
        {       
            this.Gorev = Gorev;         
        }       

    }
}
