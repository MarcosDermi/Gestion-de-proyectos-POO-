using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2___FInal
{
    public class clsPrueba : clsTarea
    {
        public string fechafinalizacion { get; set; }

        public clsPrueba(){}

        public override void PresupuestarHoras()
        {
            Valor *= 0.10;
        }

        public override int DevolverEstado()
        {
            return this.Estado;
        }

        public override string ToString()
        {
            return nombre + " " + Estado + " " + fechafinalizacion;
        }
    }
}
