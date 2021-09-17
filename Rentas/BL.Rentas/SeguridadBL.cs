using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contrasenia)//Método / Función.
        {
            if (usuario == "admin" && contrasenia == "123")
            {
                return true;
            }
            else
            {
                if (usuario == "user" && contrasenia == "456")
                {
                    return false;
                }
                
            }
            return false;
        }
    }
}
