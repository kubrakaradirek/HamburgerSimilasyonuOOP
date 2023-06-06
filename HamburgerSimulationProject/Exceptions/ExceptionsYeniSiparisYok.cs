using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSimulationProject.Exceptions
{
    public class ExceptionsYeniSiparisYok : Exception
    {
        public ExceptionsYeniSiparisYok() : base("Yeni Siparis Yok")
        {

        }
    }
}
