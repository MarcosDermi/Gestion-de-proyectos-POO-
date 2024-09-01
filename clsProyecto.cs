using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TP_2___FInal
{
    public class clsProyecto
    {
        public string nombre { get; set; }

        public clsEquipo Equipo { get; set; }

        public override string ToString()
        {
            return $" {nombre} {Equipo}";
        }
    }
}
