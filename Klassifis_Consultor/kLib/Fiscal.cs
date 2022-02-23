using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kLib
{
    public class Fiscal
    {
        //PIS
        public static double PIS_Aliquota(int Tipo_Cliente)
        {
            double aliquota = 0;


            //Simples Nacional
            if (Tipo_Cliente == 1)
            {
                aliquota = 0;
            }

            //Lucro Presumido
            else if (Tipo_Cliente == 2)
            {
                aliquota = 0.65;
            }

            //Lucro Real
            else 
            {
                aliquota = 1.65;
            }

            return aliquota;
        }

        public static string PIS_CST_Entrada(int Tipo_Cliente)
        {
            string CST_Entrada = null;

            //Simples Nacional
            if (Tipo_Cliente == 1)
            {
                CST_Entrada = "99";
            }

            //Lucro Presumido
            else if (Tipo_Cliente == 2)
            {
                CST_Entrada = "99";
            }

            //Lucro Real
            else
            {
                CST_Entrada = "50";
            }



            return CST_Entrada;
        }

        public static string PIS_CST_Saida(int Tipo_Cliente)
        {
            string CST_Saida= null;



            //Simples Nacional
            if (Tipo_Cliente == 1)
            {
                CST_Saida = "49";
            }

            //Lucro Presumido
            else if (Tipo_Cliente == 2)
            {
                CST_Saida = "01";
            }

            //Lucro Real
            else
            {
                CST_Saida = "01";
            }
            return CST_Saida;
        }

        //COFINS
        public static double COFINS_Aliquota(int Tipo_Cliente)
        {
            double aliquota = 0;


            //Simples Nacional
            if (Tipo_Cliente == 1)
            {
                aliquota = 0;
            }

            //Lucro Presumido
            else if (Tipo_Cliente == 2)
            {
                aliquota = 3;
            }

            //Lucro Real
            else
            {
                aliquota = 7.6;
            }

            return aliquota;
        }

        public static string COFINS_CST_Entrada(int Tipo_Cliente)
        {
            string CST_Entrada = null;

            //Simples Nacional
            if (Tipo_Cliente == 1)
            {
                CST_Entrada = "99";
            }

            //Lucro Presumido
            else if (Tipo_Cliente == 2)
            {
                CST_Entrada = "99";
            }

            //Lucro Real
            else
            {
                CST_Entrada = "50";
            }



            return CST_Entrada;
        }

        public static string COFINS_CST_Saida(int Tipo_Cliente)
        {
            string CST_Saida = null;



            //Simples Nacional
            if (Tipo_Cliente == 1)
            {
                CST_Saida = "49";
            }

            //Lucro Presumido
            else if (Tipo_Cliente == 2)
            {
                CST_Saida = "01";
            }

            //Lucro Real
            else
            {
                CST_Saida = "01";
            }
            return CST_Saida;
        }

    }
}
