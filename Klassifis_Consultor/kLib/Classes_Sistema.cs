using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kLib
{
    public class Classes_Sistema
    {

    }

    public class Tabela_Cest
    {
        public String Id { get; set; }
        public String Descricao { get; set; }

    }

    public class Tabela_Tipi
    {
            public String NCM                   {get; set;}
            public String Categoria             {get; set;}
            public String Descricao             {get; set;}
            public String IPI                   {get; set;}
            public String UnTrib                 {get; set;}
            public String UnTrib_Desc        {get; set;}          
            public String Observacao          { get; set; }
    }




    public class Baixar_Classificacao
    {
        public String Id { get; set; }
        public String CNPJ_Cliente { get; set; }
        public DateTime Data_Recebimento { get; set; }
        public String Status { get; set; }
    }
}
