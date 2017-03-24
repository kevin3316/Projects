using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_IntegracionContinua
{
    public class prueba
    {
        public prueba() { }

        public bool Login(string usuario, string contra)
        {
            if (usuario == "kevin3316" && contra == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Login2(string usuario, string contra)
        {
            if(usuario == "kevin" && contra == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
