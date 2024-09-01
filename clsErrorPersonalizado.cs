using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2___FInal
{
    public class clsErrorPersonalizado : Exception
    {
        public override string Message 
        { get 
            {
                return string.Format("No se puede ingresar numeros negativos o 0");
                } 
        
        }
       
    }
}
