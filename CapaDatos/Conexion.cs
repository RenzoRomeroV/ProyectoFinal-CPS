using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //con esto ya nos permite a comunicarnos el archivo web-config

namespace CapaDatos
{
    public class Conexion
    {
        //aca estamos obteniendo el valor de la cadena
        public static string cn = ConfigurationManager.ConnectionStrings["cadena"].ToString();   
    }
}
