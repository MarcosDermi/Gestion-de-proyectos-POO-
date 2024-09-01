using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2___FInal
{
    public class clsDesarrollo:clsTarea
    {
        public string Desc { get; set; }

        public clsDesarrollo(string Desc)
        {
            this.Desc = Desc;
        }

        public override int DevolverEstado()
        {
            return this.Estado;
        }

        public override void PresupuestarHoras()
        {
            Valor *= 0.15;
        }


        public override string ToString()
        {
            return nombre + " " + Estado + " " + Desc;
        }
    }
}
