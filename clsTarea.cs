using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2___FInal
{
    public abstract class clsTarea
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int Estado { get; set; }
        public double Valor { get; set; }

         public clsTarea()
        {
            Random random = new Random();

            int codigoAleatorio = random.Next(0, 10);

            this.codigo = codigoAleatorio; 
        }

        public List<clsTarea> LTareas { get; set; }

        public abstract void PresupuestarHoras();

        public virtual int DevolverEstado()
        {
            return Estado;
        }


    }
}
