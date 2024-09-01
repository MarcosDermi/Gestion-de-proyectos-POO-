using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2___FInal
{
    public class clsEquipo : ICloneable , Icalculable
    {

        public string nombre { get; set; }

        public int Estado { get; set; }

        internal List<clsTarea> ListaTareas = new List<clsTarea>();

        public override string ToString()
        {
            return nombre;
        }
        double Icalculable.CalcularTotal(clsEquipo oEquipo) 
        {
            double MontoTotal = 0;

            if (oEquipo.ListaTareas.Count > 0)
            {
                foreach (clsTarea item in oEquipo.ListaTareas)
                {
                    
                    MontoTotal += item.Valor;

                }

            }

            return MontoTotal;
        }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
