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
    public partial class frmTabelaCest : Form
    {
        public frmTabelaCest()
        {
            InitializeComponent();
        }


        //Configurações Iniciais
        private void configuracoes_Iniciais()
        {
            this.Icon = Properties.Resources.klassifis_logo_azulado;
        }


        //Configurar datagridview para CEST
        private void configurar_dgv()
        {
            dgvDados.Columns.Add("Codigo_CEST", "Código");
            dgvDados.Columns.Add("Descricao_CEST", "Descrição");
            dgvDados.Columns[1].Width = 500;
            //Adicionando dados
            dgvDados.Rows.Add(1, "Operação Tributável com Alíquota Básica");
            dgvDados.Rows.Add(2, "Operação Tributável com Alíquota Diferenciada");
            dgvDados.Rows.Add(3, "Operação Tributável com Alíquota por Unidade de Medida de Produto");
            dgvDados.Rows.Add(4, "Operação Tributável Monofásica – Revenda a Alíquota Zero");
            dgvDados.Rows.Add(5, "Operação Tributável por Substituição Tributária");
            dgvDados.Rows.Add(6, "Operação Tributável a Alíquota Zero");
            dgvDados.Rows.Add(7, "Operação Isenta da Contribuição");
            dgvDados.Rows.Add(8, "Operação sem Incidência da Contribuição");
            dgvDados.Rows.Add(9, "Operação com Suspensão da Contribuição");
            dgvDados.Rows.Add(49, "Outras Operações de Saída");
            dgvDados.Rows.Add(50, "Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Tributada no Mercado Interno");
            dgvDados.Rows.Add(51, "Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno");
            dgvDados.Rows.Add(52, "Operação com Direito a Crédito – Vinculada Exclusivamente a Receita de Exportação");
            dgvDados.Rows.Add(53, "Operação com Direito a Crédito – Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno");
            dgvDados.Rows.Add(54, "Operação com Direito a Crédito – Vinculada a Receitas Tributadas no Mercado Interno e de Exportação");
            dgvDados.Rows.Add(55, "Operação com Direito a Crédito – Vinculada a Receitas Não Tributadas no Mercado Interno e de Exportação");
            dgvDados.Rows.Add(56, "Operação com Direito a Crédito – Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno e de Exportação");
            dgvDados.Rows.Add(60, "Crédito Presumido – Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno");
            dgvDados.Rows.Add(61, "Crédito Presumido – Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno");
            dgvDados.Rows.Add(62, "Crédito Presumido – Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação");
            dgvDados.Rows.Add(63, "Crédito Presumido – Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno");
            dgvDados.Rows.Add(64, "Crédito Presumido – Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação");
            dgvDados.Rows.Add(65, "Crédito Presumido – Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação");
            dgvDados.Rows.Add(66, "Crédito Presumido – Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno e de Exportação");
            dgvDados.Rows.Add(67, "Crédito Presumido – Outras Operações");
            dgvDados.Rows.Add(70, "Operação de Aquisição sem Direito a Crédito");
            dgvDados.Rows.Add(71, "Operação de Aquisição com Isenção");
            dgvDados.Rows.Add(72, "Operação de Aquisição com Suspensão");
            dgvDados.Rows.Add(73, "Operação de Aquisição a Alíquota Zero");
            dgvDados.Rows.Add(74, "Operação de Aquisição sem Incidência da Contribuição");
            dgvDados.Rows.Add(75, "Operação de Aquisição por Substituição Tributária");
            dgvDados.Rows.Add(98, "Outras Operações de Entrada");
            dgvDados.Rows.Add(99, "Outras Operações");




        

        }
        private void frmTabelaCest_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
            configurar_dgv();
        }

        //Criar uma classe pro linq

        private void filtrar_Dados()
        {
            
            
            
        }

        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filtrar_Dados();
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
