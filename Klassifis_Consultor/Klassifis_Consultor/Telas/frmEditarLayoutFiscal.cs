using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using kLib;
using System.Web.Script.Serialization;

namespace Klassifis_Consultor.Telas
{
    public partial class frmEditarLayoutFiscal : Form
    {
        public frmEditarLayoutFiscal()
        {
            InitializeComponent();
        }

        //////////////////// Instância do form
        Cliente cliente = new Cliente();

        //Variáveis Text box
        private String mMessage, mTittle;
        private MessageBoxButtons mButton;
        private new MessageBoxIcon mIcon = MessageBoxIcon.Asterisk;
        DialogResult result;
        
        //Caminhos dos arquivos para serem carregados de acordo com a tela anterior
        public string sPathCliente, sPathProdutos;

        //Lista dos produtos que já possuem o código cadastrado
        List<String> lCodigos_Produto = new List<String>();
        
        //Ativa a validação por código
        int flg_Ativo = 0;




        /////////////////// Métodos internos do form

        //Configuracoes Iniciais
        private void configuracoes_Iniciais()
        {
            //Carrega os bloqueios, pois como é uma tela de conferência não diz respeito aos dados do cabeçalho
            //Texts box e Masked Texts box
            mtxCNPJ.ReadOnly = true;
            mtxCNAE.ReadOnly = true;
            txtIE.ReadOnly = true;
            mtxCEP.ReadOnly = true;
            txtEmail.ReadOnly = true;
            mtxContato.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtUF.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtLogradouro.ReadOnly = true;


            //Radio Buttons
            rdbAtacado.Enabled = false;
            rdbComercio.Enabled = false;
            rdbVarejo.Enabled = false;
            rdbSimples.Enabled = false;
            rdbPresumido.Enabled = false;
            rdbReal.Enabled = false;


            //Carregar Produtos
            carregar_Produtos(dgvProdutos,sPathProdutos);



            //Carrega dados do Cliente
            carregar_Cliente(sPathCliente);
        }

        //Carregar informações do Layout de produtos
        private void carregar_Produtos(DataGridView _dgv, String path)
        {
            StreamReader reader = new StreamReader(path);
            string linhasDoArquivo = reader.ReadToEnd();
            _dgv.DataSource = (DataTable)JsonConvert.DeserializeObject(linhasDoArquivo, (typeof(DataTable)));
            
        }
        //Carrega informações do Cliente
        private void carregar_Cliente(String path)
        {
            StreamReader reader = new StreamReader(path);
            string linhasDoArquivo = reader.ReadToEnd();
            DataTable cliente = (DataTable)JsonConvert.DeserializeObject(linhasDoArquivo, (typeof(DataTable)));
            
            
            
  
            DataRow[] oDataRow = cliente.Select();
            foreach (DataRow dr in oDataRow)
            {
                //CNPJ
                mtxCNPJ.Text =  dr["CNPJ_Cliente"].ToString();
                
                //Verifica a atividade do Cliente            
                if (Convert.ToInt32(dr["Atividade_Cliente"].ToString()) == 1)
                {
                    rdbAtacado.Checked = true;
                }
                else if (Convert.ToInt32(dr["Atividade_Cliente"].ToString()) == 2)
                {
                    rdbComercio.Checked = true;
                }
                else if (Convert.ToInt32(dr["Atividade_Cliente"].ToString()) == 3)
                {
                    rdbVarejo.Checked = true;
                }

                //Pega o CNAE do cliente
                mtxCNAE.Text = dr["CNAE_Cliente"].ToString();



                //Verifica o Regime tributário do cliente
                if (Convert.ToInt32(dr["Regime_Cliente"].ToString()) == 1)
                {
                    rdbSimples.Checked = true;
                }
                else if (Convert.ToInt32(dr["Regime_Cliente"].ToString()) == 2)
                {
                    rdbPresumido.Checked = true;
                }
                else if (Convert.ToInt32(dr["Regime_Cliente"].ToString()) == 3)
                {
                    rdbReal.Checked = true;
                }

                txtIE.Text = dr["IE_Cliente"].ToString();

                mtxCEP.Text = dr["CEP_Cliente"].ToString();

                txtEmail.Text = dr["Email_Cliente"].ToString();
               
                mtxContato.Text = dr["Contato_Cliente"].ToString();

            }
           


        }


        ////////////////// Componentes internos do form        

        //Load do form
        private void frmEditarLayoutFiscal_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
        }
    }
}
