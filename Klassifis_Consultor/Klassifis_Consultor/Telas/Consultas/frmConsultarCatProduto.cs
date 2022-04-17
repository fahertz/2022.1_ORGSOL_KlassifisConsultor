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

namespace Klassifis_Consultor.Telas.Consultas
{
    public partial class frmConsultarCatProduto : Form
    {
        public frmConsultarCatProduto()
        {
            InitializeComponent();
        }
        //Instância
        Fiscal fiscal = new Fiscal();

        //Controle de Inserção
        //Se for 1, ele não permite a inclusão do valor.
        public int iControle = 0;

        //Configurações Iniciais
        private void configuracoes_Iniciais()
        {
            this.Icon = Properties.Resources.klassifis_logo_azulado;
        }

        //Carregar Categorias de Produto com base na tabela tipi
        private void carregar_CatFiscal()
        {
            var categorias = from item in Fiscal.Lista_CategoriaTipi
                             select new { item.idCategoria, item.nameCategoria };
            dgvDados.Columns.Add("Cod_Categoria", "Código");
            dgvDados.Columns.Add("Des_Categoria", "Descrição Categoria");
            dgvDados.Columns[1].Width = 1000;

            foreach (var item in categorias)
            {
                dgvDados.Rows.Add(item.idCategoria, item.nameCategoria);
            }
        }

        private void filtrar_Dados()
        {
            dgvDados.Rows.Clear();
            var categorias = from item in Fiscal.Lista_CategoriaTipi
                             where item.nameCategoria.Contains(txtPesquisar.Text.ToUpper()) || item.idCategoria.ToString().Equals(txtPesquisar.Text)
                             select new { item.idCategoria, item.nameCategoria };

            foreach (var item in categorias)
            {
                dgvDados.Rows.Add(item.idCategoria, item.nameCategoria);
            }
        }

        private void frmConsultarCatProduto_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
            carregar_CatFiscal();

        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                filtrar_Dados();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            iControle = 1;
            this.Close();
        }

        private void dgvDados_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
