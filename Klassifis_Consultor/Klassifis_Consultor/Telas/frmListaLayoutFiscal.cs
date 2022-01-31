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
    public partial class frmListaLayoutFiscal : Form
    {
        public frmListaLayoutFiscal()
        {
            InitializeComponent();
        }



        ////////////////////////Instância
        
        //Variáveis Text box
        private String mMessage, mTittle;
        private MessageBoxButtons mButton;
        private new MessageBoxIcon mIcon = MessageBoxIcon.Asterisk;
        DialogResult result;




        /////////////////////Métodos internos do form
        private void configuracoes_Iniciais()
        {
            //Icon
            this.Icon = Properties.Resources.klassifis_logo_azulado;

            //Configura o Grid para receber as informações
            configurar_dgv(dgvDados);

            //Carrega os arquivos para visualização
            carregar_Layouts(dgvDados);

        }



        
        //Configura o DataGridView que recebe o nome dos arquivos
        private void configurar_dgv(DataGridView _dgv)
        {
            _dgv.Columns.Add("arch_Full_Name", "Full_Name");
            _dgv.Columns.Add("arch_Name", "Name");
            _dgv.Columns.Add("CNPJ", "CNPJ");
            _dgv.Columns.Add("Data_Hora", "Data Envio");

            //Deixa como invisível a coluna onde consta o documento            
            _dgv.Columns[0].Visible = false;
            _dgv.Columns[1].Visible = false;
            _dgv.Columns[3].Width = 150;

        }

        //Carrega todos os layouts baixados
        private void carregar_Layouts(DataGridView _dgv)
        {
            _dgv.Rows.Clear();
            string wpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString();
            string folder = wpath + "\\" + "LF"; //nome do diretorio a ser criado
            DirectoryInfo Dir = new DirectoryInfo(@folder);           
            
            //Se o diretório não existir...
            if (!Directory.Exists(folder))
            {
                //Criamos um com o nome folder
                Directory.CreateDirectory(folder);
            }

            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo File in Files)
            {
                string[] add = File.Name.ToString().Split('_');
                if (File.Name.Contains(".klp") && !File.Name.Contains("~"))
                {
                    _dgv.Rows.Add(File.FullName,File.Name, add[1], Convert.ToDateTime(add[2].Substring(0, 2) + "/" + add[2].Substring(2, 2) + "/" + add[2].Substring(4, 4)
                                               + " " + add[2].Substring(8, 2) + ":" + add[2].Substring(10, 2))
                        );
                }
            }
            _dgv.Sort(_dgv.Columns[2], ListSortDirection.Descending);
        }

        
        /////////////////Funções dos componentes internos do form
        
        //Load do form
        private void frmListaLayoutFiscal_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
        }

        //Recarregar lista
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            carregar_Layouts(dgvDados);
            this.Cursor = Cursors.Default;
        }

        //Remover arquivo selecionado        
        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (dgvDados.CurrentRow != null) {
                //Variáveis Text box
                mMessage = "Tem certeza que deseja remover o arquivo selecionado?";
                mTittle = "Klassifis Warning";
                mButton = MessageBoxButtons.YesNoCancel;
                mIcon = MessageBoxIcon.Warning;
                result = MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                if (result == DialogResult.Yes)
                {
                    File.Delete(dgvDados.CurrentRow.Cells[0].Value.ToString());
                    btnRefresh_Click(btnRefresh, new EventArgs());
                }
            }
            else
            {
                //Variáveis Text box
                mMessage = "Selecione um arquivo para remover";
                mTittle = "Klassifis Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Information;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            if (dgvDados.CurrentRow != null) {
                frmEditarLayoutFiscal form = new frmEditarLayoutFiscal();
                form.sPathCliente = dgvDados.CurrentRow.Cells[0].Value.ToString().Replace("PRODUTOS", "CLIENTE").Replace(".klp", ".klc");
                form.sPathProdutos = dgvDados.CurrentRow.Cells[0].Value.ToString();
                form.sPathReduzido = dgvDados.CurrentRow.Cells[1].Value.ToString();
                form.ShowDialog();
            }
        }

        //Botão para filtrar o CNPJ
        private void txtFiltrar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in dgvDados.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(mtxCNPJ.Text.ToString().Replace(",", "").Replace("-", "").Replace("/", "").Replace(".", "").Trim()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void mtxCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFiltrar_Click(txtFiltrar, new EventArgs());
            }
        }



        //Fechar o form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
