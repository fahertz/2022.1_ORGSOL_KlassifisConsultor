using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kLib
{
    public static class Funcoes_Sistema
    {

        public static string CNPJ_Cliente = "25.718.218/0001-07";


        public static int contar_Numeros(this String str)
        {
            return str.Where(c => char.IsNumber(c)).Count();
        }

        public static string mascarar_Double(this String str)
        {
            if (str != String.Empty && Convert.ToDouble(str) != 0)
            {
                string converter = str.Replace(".", ",");
                string numero = Convert.ToDouble(converter).ToString("#.#0");
                return numero;
            }
            else
            {
                return "0,00";
            }
        }

    }
}
