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
    public partial class frmTabelaTipi : Form
    {
        public frmTabelaTipi()
        {
            InitializeComponent();
        }




        private void configurar_Dgv(DataGridView _dgv)
        {
            _dgv.Invoke((MethodInvoker)delegate
            {
                _dgv.Columns.Add("NCM", "NCM");
                _dgv.Columns.Add("Categoria", "Categoria");
                _dgv.Columns.Add("Descricao", "Descrição");
                _dgv.Columns.Add("IPI", "IPI");
                _dgv.Columns.Add("UnTrib", "Unidade");
                _dgv.Columns.Add("UnTrib_Desc", "Desc. Unidade");
                _dgv.Columns.Add("Observacao", "Observação");

                _dgv.Columns[1].Width = 200;
                _dgv.Columns[2].Width = 450;
                _dgv.Columns[3].Width = 50;
                _dgv.Columns[5].Width = 120;



            });
        }
   
       
        private void configuracoes_Iniciais()
        {
            this.Icon = Properties.Resources.klassifis_logo_azulado;
            
           
            
            configurar_Dgv(dgvDados);

            filtrar_Dados(dgvDados);
        }


        private void filtrar_Dados(DataGridView _dgv)
        {
            var Lista_Filtrada = from tipi in Fiscal.Lista_Tabela_Tipi
                                 where tipi.NCM.Contains(txtPesquisar.Text.ToUpper())
                                 ||    tipi.Categoria.Contains(txtPesquisar.Text.ToUpper())
                                 ||    tipi.Descricao.Contains(txtPesquisar.Text.ToUpper())
                                 select tipi;

            _dgv.Invoke((MethodInvoker) delegate
            {
                _dgv.Rows.Clear();
                foreach (var item in Lista_Filtrada)
                {
                    _dgv.Rows.Add(item.NCM,item.Categoria,item.Descricao,item.IPI,item.UnTrib,item.UnTrib_Desc,item.Observacao);
                }
            });
        }


        private void frmTabelaTipi_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
        }



        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                filtrar_Dados(dgvDados);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvDados.CurrentRow.Cells[3].Selected)
            {
                System.Diagnostics.Process.Start("https://portalunico.siscomex.gov.br/classif/#/sumario?perfil=publico");
                Clipboard.SetText(dgvDados.CurrentCell.Value?.ToString());
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
