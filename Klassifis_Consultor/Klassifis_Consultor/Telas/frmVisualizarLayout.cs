using kLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassifis_Consultor.Telas
{
    public partial class frmVisualizarForms : Form
    {
        public frmVisualizarForms()
        {
            InitializeComponent();
        }
        
        
        /////////////Instância
        Parametros_Excel pExcel = new Parametros_Excel();
        DataTable dt;
        public string path_Produtos;

        /////////////Métodos internos do Form
        //Carregar informações do Layout
        private void carregar_Layout_Produtos()
        {
            StreamReader reader = new StreamReader(path_Produtos);
            string linhasDoArquivo = reader.ReadToEnd();
            //dgvProdutos.DataSource = (DataTable)JsonConvert.DeserializeObject(linhasDoArquivo, (typeof(DataTable)));
            dt = (DataTable)JsonConvert.DeserializeObject(linhasDoArquivo, (typeof(DataTable)));

        }

        //Configuracoes Iniciais do Form
        private void configuracoes_Iniciais()
        {
            //Icon
            this.Icon = Properties.Resources.klassifis_logo_azulado;
            Queue<Task> tasks = new Queue<Task>();

            tasks.Enqueue(Task.Factory.StartNew(() => LayoutFiscal.configurar_Grid_LayoutFiscal(dgvProdutos)));
            tasks.Enqueue(Task.Factory.StartNew(() => carregar_Layout_Produtos()));
            Task.WaitAny(tasks.ToArray());
            Task.Factory.StartNew(() => filtrar_Dados(dgvProdutos));
        }

        //Configurar Grid
        


        //Filtrar dados
        private void filtrar_Dados(DataGridView _dgv)
        {
            this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.WaitCursor; });
                

            var lista_Filtrada = from lista in dt.AsEnumerable()
                                 select lista;
            _dgv.Invoke((MethodInvoker)delegate
            {
                _dgv.Rows.Clear();
                foreach (var item in lista_Filtrada)
                {
                    _dgv.Rows.Add(
                         item["Cod_Produto"]
                        , item["Cod_Produto"]
                        , item["Des_Produto"]
                        , item["Cod_GTIN"]
                        , item["Cod_NCM"]
                        , item["Cod_CEST"]
                        , item["Cod_NCM_Ex"]
                        , item["ICMS_CST"]
                        , item["ICMS_ALQ"]
                        , item["ICMS_MVA"]
                        , item["ICMS_CSOSN"]
                        , item["PIS_CST_Entrada"]
                        , item["PIS_CST_Saida"]
                        , item["PIS_ALQ"]
                        , item["PIS_CSOSN"]
                        , item["COFINS_CST_Entrada"]
                        , item["COFINS_CST_Saida"]
                        , item["COFINS_ALQ"]
                        , item["COFINS_CSOSN"]
                        , item["IPI_CST"]
                        , item["IPI_ALQ"]
                        , item["IPI_CSOSN"]
                        );
                }
            });


            this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.Default; });
          
        }


        
        ///////////////////////  Componentes internos
        
        //Load do form
        private void frmVisualizarForms_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
        }

        
        //Exportar para excel
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            pExcel.exportar_ParaExcel("Layout Fiscal", dgvProdutos);
        }

        //Abrir em excel
        private void btnAbrirExcel_Click(object sender, EventArgs e)
        {
            pExcel.abrir_Grid_Excel(dgvProdutos, "Layout Fiscal" + DateTime.Now.ToString("ddMMyyyy"), "Layout Fiscal");
        }

        //Botão pesqusiar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            filtrar_Dados(dgvProdutos);
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filtrar_Dados(dgvProdutos);
            }
        }


        //Fechar o form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
