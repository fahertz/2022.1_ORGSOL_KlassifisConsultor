using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassifis_Consultor.Telas
{
    public partial class frmLayoutsEnviados : Form
    {
        public frmLayoutsEnviados()
        {
            InitializeComponent();
        }
        
        
        
        /////////////////////////////////////////Instância        
        //Variáveis Textbox
        private string mMessage;
        private string mTittle;
        private MessageBoxIcon mIcon;
        private MessageBoxButtons mButton;
        private DialogResult result;


        //Configurar datagridview para armazenar as informações da pasta
        private void configurar_dgv(DataGridView _dgv)
        {
            _dgv.Columns.Add("arch_Full_Name", "Full_Name");
            _dgv.Columns.Add("CNPJ", "CNPJ");
            _dgv.Columns.Add("Data_Hora", "Data Envio");

            //Deixa como invisível a coluna onde consta o documento            
            _dgv.Columns[0].Visible = false;
            _dgv.Columns[2].Width = 120;

        }

        //Carregar Arquivos
        private void carregar_Layouts(DataGridView _dgv)
        {
            _dgv.Rows.Clear();
            string wpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString();
            string folder = wpath + "\\" + "Layouts_Respondidos"; //nome do diretorio a ser criado
            //Se o diretório não existir...
            if (!Directory.Exists(folder))
            {
                //Criamos um com o nome folder
                Directory.CreateDirectory(folder);
            }

            DirectoryInfo Dir = new DirectoryInfo(@folder);
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo File in Files)
            {
                string[] add = File.Name.ToString().Split('_');
                if (File.Name.Contains(".klp") && !File.Name.Contains("~"))
                {
                    _dgv.Rows.Add(File.FullName, add[1], Convert.ToDateTime(add[2].Substring(0, 2) + "/" + add[2].Substring(2, 2) + "/" + add[2].Substring(4, 4)
                                               + " " + add[2].Substring(8, 2) + ":" + add[2].Substring(10, 2))
                        );
                }
            }
            _dgv.Sort(_dgv.Columns[2], ListSortDirection.Descending);
        }

        private void configuracoes_Iniciais()
        {
            this.Icon = Properties.Resources.klassifis_logo_azulado;
            configurar_dgv(dgvDados);
            carregar_Layouts(dgvDados);
        }


        ////////////////  Load do Form
        private void frmLayoutsEnviados_Load(object sender, EventArgs e)
        {

            configuracoes_Iniciais();
            
        }

        //Recarregar Layouts
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            carregar_Layouts(dgvDados);
        }


        //Abrir downloads
        private void abrirBaixar_ClassificacaoFiscal()
        {
            Application.Run(new frmBaixarClassificacaoFiscal());
        }


        private void btnBaixar_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(abrirBaixar_ClassificacaoFiscal);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null)
            {
                frmVisualizarForms form = new frmVisualizarForms();
                form.path_Produtos = dgvDados.CurrentRow.Cells[0].Value.ToString();
                form.Show();
            }
            else
            {
                mMessage = "Nenhum arquivo selecionado!";
                mTittle = "Klassifis alert";
                mIcon = MessageBoxIcon.Warning;
                mButton = MessageBoxButtons.OK;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
