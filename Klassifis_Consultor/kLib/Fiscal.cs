using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kLib
{
    public class Fiscal
    {
        //private String mMessage;
        //private String mTittle;
        //private MessageBoxButtons mButton;
        //private MessageBoxIcon mIcon;


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

        //IPI

        public static string IPI_CST_Entrada(int Ramo)
        {
            string CST_Entrada = null;

            //Se não for indústria
            if (Ramo != 4)
            {
                CST_Entrada = "49";
            }



            return CST_Entrada;
        }

        public static string IPI_CST_Saida(int Ramo)
        {
            string CST_Saida = null;



            //Se não for indústria
            if (Ramo != 4)
            {
                CST_Saida = "99";
            }

            return CST_Saida;
        }

        public static string IPI_CSOSN_Saida(int Ramo)
        {
            string CSOSN = null;



            //Se não for indústria
            if (Ramo != 4)
            {
                CSOSN = "900";
            }

            return CSOSN;
        }



        public class Categoria_TIPI
        {
            public int idCategoria { get; set; }
            public string nameCategoria { get; set; }
        }

        public class Descricao_TIPI
        {
            public int idCategoria { get; set; }
            public string nameCategoria { get; set; }
            public string ncmCategoria { get; set; }
        }

        public class Tabela_CST_Pis_Cofins
        {
            public String Id { get; set; }
            public String Descricao { get; set; }

        }

        public class Tabela_CST_Ipi
        {
            public String Id { get; set; }
            public String Descricao { get; set; }

        }

        public class Tabela_Tipi
        {
            public String NCM { get; set; }
            public String Categoria { get; set; }
            public String Descricao { get; set; }
            public String IPI { get; set; }
            public String UnTrib { get; set; }
            public String UnTrib_Desc { get; set; }
            public String Observacao { get; set; }
        }

        //Listas estáticas referentes ao NCM
        public static List<Categoria_TIPI> Lista_CategoriaTipi = new List<Categoria_TIPI>();
        public static List<Descricao_TIPI> Lista_Descricao_Tipi = new List<Descricao_TIPI>();
        public static List<Tabela_Tipi> Lista_Tabela_Tipi = new List<Tabela_Tipi>();
        public static List<Tabela_CST_Pis_Cofins> Lista_Tabela_CST_Pis_Cofins = new List<Tabela_CST_Pis_Cofins>();
        public static List<Tabela_CST_Ipi> Lista_Tabela_CST_Ipi = new List<Tabela_CST_Ipi>();




        public String classificar_NCM(string descricao, int categoria)
        {                       
            string retorno = null;           
            var filtro = from item in Lista_Descricao_Tipi
                         where categoria == item.idCategoria
                         select item;

            int x = 0;
          foreach (var desc in filtro)
            {
                if (desc.nameCategoria.Contains(desc.ncmCategoria))
                {
                    string[] palavra = desc.nameCategoria.Remove(0, 10).Split(' ');

                    for (int y = 0; y < palavra.Count(); y++)
                    {


                        if (x < HerbertLevenshteinAlgorithm.Compare(descricao.ToUpper(), palavra[y]))
                        {

                            x = HerbertLevenshteinAlgorithm.Compare(descricao.ToUpper(), palavra[y]);
                            retorno = desc.ncmCategoria;
                        }

                    }

                    if (x < HerbertLevenshteinAlgorithm.Compare(descricao.ToUpper(), desc.nameCategoria.Remove(0, 10)))
                    {
                        x = HerbertLevenshteinAlgorithm.Compare(descricao.ToUpper(), desc.nameCategoria.Remove(0, 10));
                        retorno = desc.ncmCategoria;
                    }

                }
                else
                {
                    if (x < HerbertLevenshteinAlgorithm.Compare(descricao.ToUpper(), desc.nameCategoria))
                    {
                        x = HerbertLevenshteinAlgorithm.Compare(descricao.ToUpper(), desc.nameCategoria);
                        retorno = desc.ncmCategoria;
                    }
                }
            }
            return retorno;

        }


        //Resgate IPI
        public String calcular_ALQ_IPI(string NCM)
        {
            string IPI = null;
            var filtro = from item in Lista_Tabela_Tipi
                         where item.NCM.ToString().Equals(NCM)
                         select item.IPI;
            
                foreach (var valor_IPI in filtro)
                {
                IPI = valor_IPI;
                }
            
            return IPI;
        }


        //Validação NCM
        public bool validar_NCM_Categoria(string NCM, int categoria)
        {
            //Verificar se o NCM possui 8 caracteres
            if (NCM.Length != 8)
            {
                return false;
            }

            var filtro = from item in Lista_Descricao_Tipi
                       where item.idCategoria == categoria
                       select item.ncmCategoria;


            if (filtro.Contains(NCM))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool validar_NCM(string NCM)
        {         
            //Verificar se o NCM possui 8 caracteres
            if (NCM.Length != 8)
            {                       
                return false;
            }

            var filtro = from item in Lista_Descricao_Tipi                        
                         select item.ncmCategoria;

            if (filtro.Contains(NCM))
            {
                return true;
            }
            else
            {
                return false;
            }



        }

    }

    public static class HerbertLevenshteinAlgorithm
    {

        private static int LevenshteinDistance(string source, string target)
        {
            if (String.IsNullOrEmpty(source))
            {
                if (String.IsNullOrEmpty(target)) return 0;
                return target.Length;
            }
            if (String.IsNullOrEmpty(target)) return source.Length;

            if (source.Length > target.Length)
            {
                var temp = target;
                target = source;
                source = temp;
            }

            var m = target.Length;
            var n = source.Length;
            var distance = new int[2, m + 1];

            for (var j = 1; j <= m; j++) distance[0, j] = j;

            var currentRow = 0;
            for (var i = 1; i <= n; ++i)
            {
                currentRow = i & 1;
                distance[currentRow, 0] = i;
                var previousRow = currentRow ^ 1;
                for (var j = 1; j <= m; j++)
                {
                    var cost = (target[j - 1] == source[i - 1] ? 0 : 1);
                    distance[currentRow, j] = Math.Min(Math.Min(
                                distance[previousRow, j] + 1,
                                distance[currentRow, j - 1] + 1),
                                distance[previousRow, j - 1] + cost);
                }
            }
            return distance[currentRow, m];
        }

        /// <summary>
        /// Compara duas strings
        /// </summary>
        /// <param name="a">Primeira string</param>
        /// <param name="b">Segunda string</param>
        /// <returns>Retorna um valor de 0 à 255. Quanto mais alto este valor mais parecidas são as strings</returns>
        public static byte Compare(string a, string b)
        {
            double distance = LevenshteinDistance(a, b);
            if (distance == 0) return 255;
            double length = Math.Max(a.Length, b.Length);
            if (distance == length) return 0;

            double inverted = Invert(distance, length);
            byte percent = (byte)((inverted / length) * 255);
            return percent;
        }

        private static double Invert(double min, double max)
        {
            return max - min;
        }

    }

    public class LayoutFiscal
    {
        //public String Cod_Produto { get; set; }
        //public String Des_Produto { get; set; }
        //public String Cod_GTIN { get; set; }
        //public String Cod_NCM { get; set; }
        //public String Cod_CEST { get; set; }
        //public String Cod_NCM_Ex { get; set; }
        //public String ICMS_CST { get; set; }
        //public String ICMS_ALQ { get; set; }
        //public String ICMS_MVA { get; set; }
        //public String ICMS_CSOSN { get; set; }
        //public String PIS_CST_Entrada { get; set; }
        //public String PIS_CST_Saida { get; set; }
        //public String PIS_ALQ { get; set; }
        //public String PIS_CSOSN { get; set; }
        //public String COFINS_CST_Entrada { get; set; }
        //public String COFINS_CST_Saida { get; set; }
        //public String COFINS_ALQ { get; set; }
        //public String COFINS_CSOSN { get; set; }
        //public String IPI_CST { get; set; }
        //public String IPI_ALQ { get; set; }
        //public String IPI_CSOSN { get; set; }


        public static void configurar_Grid_LayoutFiscal(DataGridView _dgv)
        {
            _dgv.Invoke((MethodInvoker)delegate
           {
               _dgv.Columns.Add("Cod_Produto", "Cód. Produto");
               _dgv.Columns.Add("Des_Produto", "Desc. Produto");
               _dgv.Columns.Add("CodCat_Produto", "CodCat_Produto");
               _dgv.Columns.Add("Cat_Produto", "Cat_Produto");
               _dgv.Columns.Add("Cod_GTIN", "GTIN");
               _dgv.Columns.Add("Cod_NCM", "NCM");
               _dgv.Columns.Add("Cod_CEST", "CEST");
               _dgv.Columns.Add("Cod_NCM_Ex", "NCM Ex");
               _dgv.Columns.Add("ICMS_CST", "ICMS CST");
               _dgv.Columns.Add("ICMS_ALQ", "ICMS Alq");
               _dgv.Columns.Add("ICMS_MVA", "ICMS MVA");
               _dgv.Columns.Add("ICMS_CSOSN", "ICMS CSOSN");
               _dgv.Columns.Add("PIS_CST_Entrada", "PIS CST Entrada");
               _dgv.Columns.Add("PIS_CST_Saida", "PIS CST Saída");
               _dgv.Columns.Add("PIS_ALQ", "PIS Alq");
               _dgv.Columns.Add("PIS_CSOSN", "PIS CSOSN");
               _dgv.Columns.Add("COFINS_CST_Entrada", "COFINS CST Entrada");
               _dgv.Columns.Add("COFINS_CST_Saida", "COFINS CST Saída");
               _dgv.Columns.Add("COFINS_ALQ", "COFINS Alq");
               _dgv.Columns.Add("COFINS_CSOSN", "COFINS CSOSN");
               _dgv.Columns.Add("IPI_CST", "IPI CST");
               _dgv.Columns.Add("IPI_ALQ", "IPI Alq");
               _dgv.Columns.Add("IPI_CSOSN", "IPI CSOSN");
           });
        }

    }

   
}
