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
    public partial class frmTabelaCest : Form
    {
        public frmTabelaCest()
        {
            InitializeComponent();
        }


        //////////////////////////////Instância
        List<Tabela_Cest> lTabela_Cest = new List<Tabela_Cest>();
        



        //Configurações Iniciais
        private void configuracoes_Iniciais()
        {
            this.Icon = Properties.Resources.klassifis_logo_azulado;

            List<Task> Tasks = new List<Task>();
            Task.Factory.StartNew(() => configurar_dgv(dgvDados));
            
            Task.WaitAny(Task.Factory.StartNew(() => preencher_Tabela_Cest()));
                        
            Task.Factory.StartNew(() => filtrar_Dados(dgvDados));



        }


        //Configurar datagridview para CEST
        private void configurar_dgv(DataGridView _dgv)
        {
            _dgv.Invoke((MethodInvoker)delegate
           {
               _dgv.Columns.Add("Codigo_CEST", "Código");
               _dgv.Columns.Add("Descricao_CEST", "Descrição");
               _dgv.Columns[1].Width = 500;
           });
            
        }

        //Preencher a lista
        private void preencher_Tabela_Cest()
        {            
            //Adicionando dados
            lTabela_Cest.Add(new Tabela_Cest { Id = "01", Descricao = "Operação Tributável com Alíquota Básica" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "02", Descricao = "Operação Tributável com Alíquota Diferenciada" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "03", Descricao = "Operação Tributável com Alíquota por Unidade de Medida de Produto" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "04", Descricao = "Operação Tributável Monofásica – Revenda a Alíquota Zero" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "05", Descricao = "Operação Tributável por Substituição Tributária" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "06", Descricao = "Operação Tributável a Alíquota Zero" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "07", Descricao = "Operação Isenta da Contribuição" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "08", Descricao = "Operação sem Incidência da Contribuição" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "09", Descricao = "Operação com Suspensão da Contribuição" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "49", Descricao = "Outras Operações de Saída" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "50", Descricao = "Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Tributada no Mercado Interno" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "51", Descricao = "Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "52", Descricao = "Operação com Direito a Crédito – Vinculada Exclusivamente a Receita de Exportação" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "53", Descricao = "Operação com Direito a Crédito – Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "54", Descricao = "Operação com Direito a Crédito – Vinculada a Receitas Tributadas no Mercado Interno e de Exportação" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "55", Descricao = "Operação com Direito a Crédito – Vinculada a Receitas Não Tributadas no Mercado Interno e de Exportação" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "56", Descricao = "Operação com Direito a Crédito – Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno e de Exportação" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "60", Descricao = "Crédito Presumido – Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "61", Descricao = "Crédito Presumido – Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "62", Descricao = "Crédito Presumido – Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "63", Descricao = "Crédito Presumido – Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "64", Descricao = "Crédito Presumido – Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "65", Descricao = "Crédito Presumido – Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "66", Descricao = "Crédito Presumido – Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno e de Exportação" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "67", Descricao = "Crédito Presumido – Outras Operações" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "70", Descricao = "Operação de Aquisição sem Direito a Crédito" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "71", Descricao = "Operação de Aquisição com Isenção" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "72", Descricao = "Operação de Aquisição com Suspensão" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "73", Descricao = "Operação de Aquisição a Alíquota Zero" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "74", Descricao = "Operação de Aquisição sem Incidência da Contribuição" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "75", Descricao = "Operação de Aquisição por Substituição Tributária" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "98", Descricao = "Outras Operações de Entrada" });
            lTabela_Cest.Add(new Tabela_Cest { Id = "99", Descricao = "Outras Operações" });            
        }

        //Filtrar a lista
        private void filtrar_Dados(DataGridView _dgv)
        {
            string Pesquisa = null;
            _dgv.Rows.Clear();
                txtPesquisar.Invoke((MethodInvoker)delegate { Pesquisa = txtPesquisar.Text; });
                var lista_Filtrada = from Cest in lTabela_Cest
                                     where Cest.Id.Contains(Pesquisa) || Cest.Descricao.Contains(Pesquisa)
                                     select Cest;

            _dgv.Invoke((MethodInvoker)delegate
            {
                foreach (var item in lista_Filtrada)
                    {
                        _dgv.Rows.Add(item.Id,item.Descricao);
                    }
            });

        }
        private void frmTabelaCest_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();         
        }
        

       //Fechar o form        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filtrar_Dados(dgvDados);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            filtrar_Dados(dgvDados);
        }
    }
}
