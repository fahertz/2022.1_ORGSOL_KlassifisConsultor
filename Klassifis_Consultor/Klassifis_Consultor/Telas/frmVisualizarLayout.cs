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
        public string path_Produtos;

        /////////////Métodos internos do Form
        //Carregar informações do Layout
        private void carregar_Layout_Produtos()
        {
            StreamReader reader = new StreamReader(path_Produtos);
            string linhasDoArquivo = reader.ReadToEnd();
            dgvProdutos.DataSource = (DataTable)JsonConvert.DeserializeObject(linhasDoArquivo, (typeof(DataTable)));

        }

        //Configuracoes Iniciais do Form
        private void configuracoes_Iniciais()
        {
            //Icon
            this.Icon = Properties.Resources.klassifis_logo_azulado;

                 
            carregar_Layout_Produtos();
        }

        //Filtrar dados
        private void filtrar_Dados()
        {
            this.Cursor = Cursors.WaitCursor;
            if (chkExato.Checked)
            {
                foreach (DataGridViewRow row in dgvProdutos.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(txtFiltro.Text) || row.Cells[1].Value.ToString().Equals(txtFiltro.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        CurrencyManager cm = (CurrencyManager)BindingContext[dgvProdutos.DataSource];
                        cm.EndCurrentEdit();
                        cm.ResumeBinding();
                        cm.SuspendBinding();
                        int i = row.Index;
                        dgvProdutos.ClearSelection();
                        row.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvProdutos.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(txtFiltro.Text) || row.Cells[1].Value.ToString().Contains(txtFiltro.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        CurrencyManager cm = (CurrencyManager)BindingContext[dgvProdutos.DataSource];

                        cm.EndCurrentEdit();
                        cm.ResumeBinding();
                        cm.SuspendBinding();
                        int i = row.Index;
                        dgvProdutos.ClearSelection();
                        row.Visible = false;
                    }
                }
            }
            this.Cursor = Cursors.Default;


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
            filtrar_Dados();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filtrar_Dados();
            }
        }


        //Fechar o form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
