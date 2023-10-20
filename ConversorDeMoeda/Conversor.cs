using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda
{
     public class Conversor
    {
       
       public static double valorCompra;

        public static double ConversorMoeda(double cotacao)
        {
            double calc = (valorCompra * cotacao);
            double resultado = (calc * 6) / 100;

            return resultado + calc;
        }
    }

}
