using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kLib
{
    public class Funcoes_Sistema

    {            
            public int contar_Numeros(string texto)
            {
                return texto.Where(c => char.IsNumber(c)).Count();
            }

            public string mascara_Double(string texto)
            {
            if (texto != String.Empty && Convert.ToDouble(texto) != 0)
            {
                string converter = texto.Replace(".", ",");
                //double numero = Math.Round(Convert.ToDouble(converter), casas_Decimais);
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
