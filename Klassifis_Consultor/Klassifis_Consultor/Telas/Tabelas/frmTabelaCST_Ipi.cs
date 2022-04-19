using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kLib;
namespace Klassifis_Consultor.Telas.Tabelas
{
    public partial class frmTabelaCST_Ipi : Form
    {
        public frmTabelaCST_Ipi()
        {
            InitializeComponent();
        }

        //Configurações Iniciais
        private void configuracoes_Iniciais()
        {
            this.Icon = Properties.Resources.klassifis_logo_azulado;


            configurar_dgv(dgvDados);



            filtrar_Dados(dgvDados);
        }


        //Configurar datagridview para CST
        private void configurar_dgv(DataGridView _dgv)
        {
            _dgv.Invoke((MethodInvoker)delegate
            {
                _dgv.Columns.Add("Codigo_CEST", "Código");
                _dgv.Columns.Add("Descricao_CEST", "Descrição");
                _dgv.Columns["Descricao_CEST"].Width = 500;
            });

        }

        //Filtrar a lista
        private void filtrar_Dados(DataGridView _dgv)
        {
            string Pesquisa = null;
            _dgv.Rows.Clear();
            txtPesquisar.Invoke((MethodInvoker)delegate { Pesquisa = txtPesquisar.Text; });
            var lista_Filtrada = from Cest in Fiscal.Lista_Tabela_CST_Ipi
                                 where Cest.Id.Contains(Pesquisa) || Cest.Descricao.Contains(Pesquisa)
                                 select Cest;

            _dgv.Invoke((MethodInvoker)delegate
            {
                foreach (var item in lista_Filtrada)
                {
                    _dgv.Rows.Add(item.Id, item.Descricao);
                }
            });

        }

        private void frmTabelaCST_Ipi_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();

        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                filtrar_Dados(dgvDados);
            }
        }

        //Pesquisa com TextChanged
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            filtrar_Dados(dgvDados);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
