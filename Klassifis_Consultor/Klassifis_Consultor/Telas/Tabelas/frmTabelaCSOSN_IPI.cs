using kLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassifis_Consultor.Telas.Tabelas
{
    public partial class frmTabelaCSOSN_IPI : Form
    {
        public frmTabelaCSOSN_IPI()
        {
            InitializeComponent();
        }


        private void configuracoes_Iniciais()
        {
            this.Icon = Properties.Resources.klassifis_logo_azulado;
        }

        private void frmTabelaCSOSN_IPI_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
            configurar_dgv(dgvDados);
            filtrar_Dados(dgvDados);
        }



        //Configurar datagridview para CSOSN de IPI
        private void configurar_dgv(DataGridView _dgv)
        {
            _dgv.Invoke((MethodInvoker)delegate
            {
                _dgv.Columns.Add("Codigo_CSOSN", "Código");
                _dgv.Columns.Add("Descricao_CSOSN", "Descrição");
                _dgv.Columns["Descricao_CSOSN"].Width = 500;
            });

        }


        //Filtrar a lista
        private void filtrar_Dados(DataGridView _dgv)
        {
            string Pesquisa = null;
            _dgv.Rows.Clear();
            txtPesquisar.Invoke((MethodInvoker)delegate { Pesquisa = txtPesquisar.Text; });
            var lista_Filtrada = from CSOSN in Fiscal.Lista_Tabela_CSOSN_Ipi
                                 where CSOSN.Id.Contains(Pesquisa.ToUpper().Trim()) || CSOSN.Descricao.ToUpper().Contains(Pesquisa.ToUpper().Trim())
                                 select CSOSN;

            _dgv.Invoke((MethodInvoker)delegate
            {
                foreach (var item in lista_Filtrada)
                {
                    _dgv.Rows.Add(item.Id, item.Descricao);
                }
            });

        }
        //Filtrar dados com Enter
        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filtrar_Dados(dgvDados);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            filtrar_Dados(dgvDados);
        }
    }
}
