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
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.Mail;
using Klassifis_Consultor.Telas.Tabelas;

namespace Klassifis_Consultor.Telas
{
    public partial class frmEditarLayoutFiscal : Form
    {
        public frmEditarLayoutFiscal()
        {
            InitializeComponent();
        }

        //////////////////// Instância do form
        Parametros_Excel pExcel = new Parametros_Excel();        

        //Variáveis Text box
        private String mMessage, mTittle;
        private MessageBoxButtons mButton;
        private new MessageBoxIcon mIcon = MessageBoxIcon.Asterisk;
        DialogResult result;
        
        //Caminhos dos arquivos para serem carregados de acordo com a tela anterior
        public string sPathCliente, sPathProdutos,sPathReduzido;

        //Lista dos produtos que já possuem o código cadastrado
        List<String> lCodigos_Produto = new List<String>();
        
        //Ativa a validação por código
        int flg_Ativo = 0;

        int cep_Exception;




        /////////////////// Métodos internos do form

        //Configuracoes Iniciais
        private void configuracoes_Iniciais()
        {

            //Icon
            this.Icon = Properties.Resources.klassifis_logo_azulado;

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

            //Limpa as linhas nulas
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (row.Cells[0].Value.ToString().Trim().Equals(String.Empty))
                {
                    dgvProdutos.Rows.Remove(row);
                }
                else
                {
                    lCodigos_Produto.Add(row.Cells[0].Value.ToString());                    
                }
            }




            int flg_Tipo;
            string tipo_Empresa;
            if (rdbSimples.Checked)

            {
                flg_Tipo = 1;
                tipo_Empresa = "Simples Nacional";
            }
            else if (rdbPresumido.Checked)
            {
                flg_Tipo = 2;
                tipo_Empresa = "Lucro Presumido";
            }
            else
            {
                flg_Tipo = 3;
                tipo_Empresa = "Lucro Real";
            }

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {



                row.Cells[dgvProdutos.Columns.IndexOf(dgvProdutos.Columns["PIS_CST_Entrada"])].Value = Fiscal.PIS_CST_Entrada(flg_Tipo);
                row.Cells[dgvProdutos.Columns.IndexOf(dgvProdutos.Columns["PIS_CST_Saida"])].Value = Fiscal.PIS_CST_Saida(flg_Tipo);
                row.Cells[dgvProdutos.Columns.IndexOf(dgvProdutos.Columns["PIS_Alq"])].Value = Fiscal.PIS_Aliquota(flg_Tipo).ToString().mascarar_Double();
                                                      
                row.Cells[dgvProdutos.Columns.IndexOf(dgvProdutos.Columns["COFINS_CST_Entrada"])].Value = Fiscal.COFINS_CST_Entrada(flg_Tipo);
                row.Cells[dgvProdutos.Columns.IndexOf(dgvProdutos.Columns["COFINS_CST_Saida"])].Value = Fiscal.COFINS_CST_Saida(flg_Tipo);
                row.Cells[dgvProdutos.Columns.IndexOf(dgvProdutos.Columns["COFINS_Alq"])].Value = Fiscal.COFINS_Aliquota(flg_Tipo).ToString().mascarar_Double();
                
            }

            lsbRegras.Items.Add(tipo_Empresa + " PIS E/S " + Fiscal.PIS_CST_Entrada(flg_Tipo) + "/" + Fiscal.PIS_CST_Saida(flg_Tipo) + " com Alíquota de " + Fiscal.PIS_Aliquota(flg_Tipo).ToString()).ToString().mascarar_Double();
            lsbRegras.Items.Add(tipo_Empresa + " COFINS E/S " + Fiscal.COFINS_CST_Entrada(flg_Tipo) + "/" + Fiscal.COFINS_CST_Entrada(flg_Tipo) + " com Alíquota de " + Fiscal.COFINS_Aliquota(flg_Tipo).ToString()).ToString().mascarar_Double();






            //Carrega dados do Cliente
            carregar_Cliente(sPathCliente);

            
            Task.Factory.StartNew(() => buscar_CEP(mtxCEP.Text));
            Task.Factory.StartNew(() => validar_Dados(dgvProdutos));
            
        }
      
        //Carregar informações do Layout de produtos
        private void carregar_Produtos(DataGridView _dgv, String path)
        {
            StreamReader reader = new StreamReader(path);
            string linhasDoArquivo = reader.ReadToEnd();
            _dgv.DataSource = (DataTable)JsonConvert.DeserializeObject(linhasDoArquivo, (typeof(DataTable)));
            
            
        }

        private void validar_Dados(DataGridView _dgv)
        {

            _dgv.Invoke((MethodInvoker)delegate
           {
               foreach (DataGridViewRow row in _dgv.Rows)
               {

                   if (!row.Cells[3].Value.ToString().Equals(String.Empty) && Fiscal.Validar_NCM(row.Cells[3].Value.ToString()) != true)
                   {
                       row.Cells[3].Style.BackColor = Color.Red;
                   }
                   else
                   {
                       row.Cells[3].Style.BackColor = Color.White;
                   }

                   if (!row.Cells[5].Value.ToString().Equals(String.Empty) && Fiscal.Validar_NCM(row.Cells[5].Value.ToString()) != true)
                   {
                       row.Cells[5].Style.BackColor = Color.Red;
                   }
                   else 
                   {
                       row.Cells[5].Style.BackColor = Color.White;
                   }

               }
           });
        }

        //Buscar pelo CEP        
        private void buscar_CEP(string cep)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    mMessage = "Preencha o campo CEP";
                    mTittle = "Autacont";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Warning;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    txtUF.ReadOnly = true;
                    txtCidade.ReadOnly = true;
                    txtBairro.ReadOnly = true;
                    txtLogradouro.ReadOnly = true;
                    //cep_Exception = 1;
                    return; // Sai da rotina
                }
                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        mMessage = "CEP não encontrado!";
                                        mTittle = "Autacont";
                                        mButton = MessageBoxButtons.OK;
                                        mIcon = MessageBoxIcon.Warning;
                                        MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                                        mtxCEP.Focus();
                                        lblCEP.ForeColor = Color.Red;
                                        return;
                                    }
                                }

                                //Logradouro
                                if (cont == 2)
                                {
                                    txtLogradouro.Invoke((MethodInvoker)delegate
                                    {
                                        string[] valor = substring.Split(":".ToCharArray());                                   
                                        txtLogradouro.Text = valor[1];
                                   });
                                    

                                }

                                if (cont == 4)
                                {

                                    txtBairro.Invoke((MethodInvoker)delegate
                                    {
                                        string[] valor = substring.Split(":".ToCharArray());
                                    txtBairro.Text = valor[1];
                                    });
                                }

                                //Localidade (Cidade)
                                if (cont == 5)
                                {

                                    txtCidade.Invoke((MethodInvoker)delegate
                                    {
                                        string[] valor = substring.Split(":".ToCharArray());
                                    txtCidade.Text = valor[1];
                                    });
                                }

                                //Estado (UF)
                                if (cont == 6)
                                {
                                        txtUF.Invoke((MethodInvoker)delegate
                                        {
                                            string[] valor = substring.Split(":".ToCharArray());
                                            txtUF.Text = valor[1];
                                        });
                                }

                                cont++;
                            }
                        }
                    }
                }
            }
            catch (WebException we)
            {
                MessageBox.Show(we.Message.ToString());
            }

        }




        private void dgvProdutos_KeyDown(object sender, KeyEventArgs e)
        {

            //Apagar a célula toda com o delete
            if (e.KeyData == Keys.Delete)
            {
                dgvProdutos.CurrentCell.Value = string.Empty;
            }
            
            //Ativando o CTRL C para a célula
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                if (!dgvProdutos.CurrentRow.Cells[0].Selected)
                dgvProdutos.CurrentCell.Value = Clipboard.GetText();
            }

        }

        private void dgvProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.CurrentRow.Cells[0].Selected && lCodigos_Produto.Contains(dgvProdutos.CurrentCell.Value.ToString().Trim()) && lCodigos_Produto.IndexOf(dgvProdutos.CurrentCell.Value.ToString()) != dgvProdutos.CurrentCell.RowIndex)
            {
                mMessage = "Código do cliente não pode ser repetido para relação.";
                mTittle = "Klassifis Error";
                mIcon = MessageBoxIcon.Warning;
                mButton = MessageBoxButtons.OK;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value + "+";
                lCodigos_Produto.Add(dgvProdutos.CurrentCell.Value.ToString());                
            }

            //0     Cod_Produto    
            //1     Des_Produto
            //2     Cod_GTIN
            //3     Cod_NCM
            //4     Cod_CEST
            //5     Cod_NCM_Ex
            //6     ICMS_CST
            //7     ICMS_ALQ
            //8     ICMS_MVA
            //9     ICMS_CSOSN
            //10    PIS_CST_Entrada
            //11    PIS_CST_Saida
            //12    PIS_ALQ
            //13    PIS_CSOSN
            //14    COFINS_CST_Entrada
            //15    COFINS_CST_Saida
            //16    COFINS_ALQ
            //17    COFINS_CSOSN
            //18    IPI_CST
            //19    IPI_ALQ
            //20    IPI_CSOSN


            // [0] Validiação se o Produto foi preenchido
            if (dgvProdutos.CurrentRow.Cells[0].Value != null)
            {
                if (dgvProdutos.CurrentRow.Cells[0].Style.BackColor == Color.Red)
                    dgvProdutos.CurrentRow.Cells[0].Style.BackColor = Color.White;

                //[0]
                if (dgvProdutos.CurrentRow.Cells[0].Selected)
                {
                    int flg_Cor = 0;
                    foreach (DataGridViewRow row in dgvProdutos.Rows)
                    {
                        if (dgvProdutos.CurrentRow.Cells[0].Value.Equals(row.Cells[0].Value) && row.Index != dgvProdutos.CurrentRow.Index)
                        {
                            dgvProdutos.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                            mMessage = "Código do cliente não pode ser repetido para relação.";
                            mTittle = "Klassifis Error";
                            mIcon = MessageBoxIcon.Warning;
                            mButton = MessageBoxButtons.OK;
                            MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                            flg_Cor = 1;
                            break;
                        }

                    }
                    if (flg_Cor == 0)
                        dgvProdutos.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                }


                // [2] Validação do código GTIN
                if (dgvProdutos.CurrentRow.Cells[2].Selected && dgvProdutos.CurrentRow.Cells[2].Value?.ToString().Trim().Length < 7)
                {
                    mMessage = "O código GTIN precisa ser maior que 7";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);

                }
                else if (dgvProdutos.CurrentRow.Cells[2].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                }

                // [3] Validação NCM
                if (dgvProdutos.CurrentRow.Cells[3].Selected && dgvProdutos.CurrentRow.Cells[3].Value?.ToString().Trim().Length != 8)
                {
                    mMessage = "O código NCM precisa ter que 8 valores";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);

                }
                else if (!dgvProdutos.CurrentRow.Cells[3].Value.ToString().Equals(String.Empty) && Fiscal.Validar_NCM(dgvProdutos.CurrentRow.Cells[3].Value.ToString()) != true)
                {
                    mMessage = "Código NCM inválido, consulte a tabela TIPI para mais informações";
                    mTittle = "Klassifis warning";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Warning;
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                }
                else if (dgvProdutos.CurrentRow.Cells[3].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                }


                // [4] Validação do Cest
                if (dgvProdutos.CurrentRow.Cells[4].Selected && dgvProdutos.CurrentRow.Cells[4].Value?.ToString().Trim().Length != 7)
                {
                    mMessage = "CEST inválido.";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                }
                else if (dgvProdutos.CurrentRow.Cells[4].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                }

                // [5] Validação NCM
                if (dgvProdutos.CurrentRow.Cells[5].Selected && dgvProdutos.CurrentRow.Cells[5].Value?.ToString().Trim().Length != 8)
                {
                    mMessage = "O código NCM precisa ter que 8 valores";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);



                }
                else if (!dgvProdutos.CurrentRow.Cells[5].Value.ToString().Equals(String.Empty) && Fiscal.Validar_NCM(dgvProdutos.CurrentRow.Cells[5].Value.ToString()) != true)
                {
                    mMessage = "Código NCM inválido, consulte a tabela TIPI para mais informações";
                    mTittle = "Klassifis warning";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Warning;
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                }
                else if (dgvProdutos.CurrentRow.Cells[5].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                }

                // [6] Validação do CST de ICMS
                if (dgvProdutos.CurrentRow.Cells[6].Selected && dgvProdutos.CurrentRow.Cells[6].Value?.ToString().Trim().Length != 2)
                {
                    mMessage = "CST inválido.";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                }
                else if (dgvProdutos.CurrentRow.Cells[6].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                }


                // [7] Validação da Alíquota de ICMS
                if (dgvProdutos.CurrentRow.Cells[7].Selected && dgvProdutos.CurrentRow.Cells[7].Value?.ToString().Trim() != String.Empty)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }


                }

                // [8] Validação do MVA de ICMS
                if (dgvProdutos.CurrentRow.Cells[8].Selected && dgvProdutos.CurrentRow.Cells[8].Value?.ToString().Trim() != String.Empty)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }


                }
                // [9] Validação do CSOSN de ICMS
                if (dgvProdutos.CurrentRow.Cells[9].Selected && dgvProdutos.CurrentRow.Cells[9].Value?.ToString().Trim() != String.Empty)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }


                }

                // [10] Validação do CST de Entrada PIS
                if (dgvProdutos.CurrentRow.Cells[10].Selected && dgvProdutos.CurrentRow.Cells[10].Value?.ToString().Trim().Length != 2)
                {
                    mMessage = "CST inválido.";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                }
                else if (dgvProdutos.CurrentRow.Cells[10].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                }
                //[11] Validação do CST de Saída PIS
                if (dgvProdutos.CurrentRow.Cells[11].Selected && dgvProdutos.CurrentRow.Cells[11].Value?.ToString().Trim().Length != 2)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }
                    mMessage = "CST inválido.";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                }
                else if (dgvProdutos.CurrentRow.Cells[11].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;

                }


                // [12] Validação da Alíquota de PIS
                if (dgvProdutos.CurrentRow.Cells[12].Selected && dgvProdutos.CurrentRow.Cells[12].Value?.ToString().Trim() != String.Empty)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }


                }

                // [13] Validação do CSOSN de PIS
                if (dgvProdutos.CurrentRow.Cells[13].Selected && dgvProdutos.CurrentRow.Cells[13].Value?.ToString().Trim() != String.Empty)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }


                }

                // [14] Validação do CST de Entraada COFINS
                if (dgvProdutos.CurrentRow.Cells[14].Selected && dgvProdutos.CurrentRow.Cells[14].Value?.ToString().Trim().Length != 2)
                {
                    mMessage = "CST inválido.";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                }
                else if (dgvProdutos.CurrentRow.Cells[14].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                }

                // [13] Validação do CST de Saida COFINS
                if (dgvProdutos.CurrentRow.Cells[15].Selected && dgvProdutos.CurrentRow.Cells[15].Value?.ToString().Trim().Length != 2)
                {
                    mMessage = "CST inválido.";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                }
                else if (dgvProdutos.CurrentRow.Cells[15].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                }


                // [16] Validação da Alíquota de Cofins
                if (dgvProdutos.CurrentRow.Cells[16].Selected && dgvProdutos.CurrentRow.Cells[16].Value?.ToString().Trim() != String.Empty)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }


                }

                // [17] Validação do CSOSN de Cofins
                if (dgvProdutos.CurrentRow.Cells[17].Selected && dgvProdutos.CurrentRow.Cells[17].Value?.ToString().Trim() != String.Empty)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }


                }

                // [18] Validação do CST de IPI
                if (dgvProdutos.CurrentRow.Cells[18].Selected && dgvProdutos.CurrentRow.Cells[18].Value?.ToString().Trim().Length != 2)
                {
                    mMessage = "CST inválido.";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    dgvProdutos.CurrentCell.Style.BackColor = Color.Red;
                }
                else if (dgvProdutos.CurrentRow.Cells[18].Selected)
                {
                    dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                }


                // [19] Validação da Alíquota de IPI
                if (dgvProdutos.CurrentRow.Cells[19].Selected && dgvProdutos.CurrentRow.Cells[19].Value?.ToString().Trim() != String.Empty)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }


                }

                // [20] Validação do CSOSN de IPI
                if (dgvProdutos.CurrentRow.Cells[20].Selected && dgvProdutos.CurrentRow.Cells[20].Value?.ToString().Trim() != String.Empty)
                {
                    if (Convert.ToInt32(dgvProdutos.CurrentCell.Value) == 0)
                    {
                        dgvProdutos.CurrentCell.Value = "0,00";
                    }

                    else
                    {
                        dgvProdutos.CurrentCell.Value = dgvProdutos.CurrentCell.Value.ToString().mascarar_Double();
                    }

                }




            }
            else
            {
                mMessage = "Preencha o código do produto";
                mTittle = "Klassifis validation";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                dgvProdutos.CurrentRow.Cells[0].Style.BackColor = Color.Red;
                dgvProdutos.CurrentCell.Value = String.Empty;
            }

        }

        private void dgvProdutos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            pExcel.exportar_ParaExcel("Layout Fiscal", dgvProdutos);
            this.Cursor = Cursors.Default;
        }

        private void btnAbrirExcel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            pExcel.abrir_Grid_Excel(dgvProdutos, "Layout Fiscal" + DateTime.Now.ToString("ddMMyyyy"), "Layout Fiscal");
            this.Cursor = Cursors.Default;
        }

        private void btnEntradaManual_Click(object sender, EventArgs e)
        {
            frmEditarLayoutFiscal_Manual form = new frmEditarLayoutFiscal_Manual();          
            form.txtCod_Produto.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            form.txtCod_Produto.ReadOnly = true;
            form.txtDesc_Produto.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();

            form.txtCod_GTIN.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
            form.txtCod_NCM.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
            form.txtCod_CEST.Text = dgvProdutos.CurrentRow.Cells[4].Value.ToString();
            form.txtCod_NCM_Ex.Text = dgvProdutos.CurrentRow.Cells[5].Value.ToString();

            form.txtICMS_CST.Text = dgvProdutos.CurrentRow.Cells[6].Value.ToString();
            form.txtICMS_Alq.Text = dgvProdutos.CurrentRow.Cells[7].Value.ToString();
            form.txtICMS_MVA.Text = dgvProdutos.CurrentRow.Cells[8].Value.ToString();
            form.txtICMS_CSOSN.Text = dgvProdutos.CurrentRow.Cells[9].Value.ToString();

            form.txtPIS_CST_Entrada.Text = dgvProdutos.CurrentRow.Cells[10].Value.ToString();
            form.txtPIS_CST_Saida.Text = dgvProdutos.CurrentRow.Cells[11].Value.ToString();
            form.txtPIS_Alq.Text = dgvProdutos.CurrentRow.Cells[12].Value.ToString();
            form.txtPIS_CSOSN.Text = dgvProdutos.CurrentRow.Cells[13].Value.ToString();

            form.txtCOFINS_CST_Entrada.Text = dgvProdutos.CurrentRow.Cells[14].Value.ToString();
            form.txtCOFINS_CST_Saida.Text = dgvProdutos.CurrentRow.Cells[15].Value.ToString();
            form.txtCOFINS_Alq.Text = dgvProdutos.CurrentRow.Cells[16].Value.ToString();
            form.txtCOFINS_CSOSN.Text = dgvProdutos.CurrentRow.Cells[17].Value.ToString();

            form.txtIPI_CST.Text = dgvProdutos.CurrentRow.Cells[18].Value.ToString();
            form.txtIPI_Alq.Text = dgvProdutos.CurrentRow.Cells[19].Value.ToString();
            form.txtIPI_CSOSN.Text = dgvProdutos.CurrentRow.Cells[20].Value.ToString();
            form.ShowDialog();

            dgvProdutos.CurrentRow.Cells[0].Value = form.txtCod_Produto.Text;            
            dgvProdutos.CurrentRow.Cells[1].Value = form.txtDesc_Produto.Text;

            dgvProdutos.CurrentRow.Cells[2].Value = form.txtCod_GTIN.Text;
            dgvProdutos.CurrentRow.Cells[3].Value = form.txtCod_NCM.Text;
            dgvProdutos.CurrentRow.Cells[4].Value = form.txtCod_CEST.Text;
            dgvProdutos.CurrentRow.Cells[5].Value = form.txtCod_NCM_Ex.Text;

            dgvProdutos.CurrentRow.Cells[6].Value = form.txtICMS_CST.Text;
            dgvProdutos.CurrentRow.Cells[7].Value = form.txtICMS_Alq.Text;
            dgvProdutos.CurrentRow.Cells[8].Value = form.txtICMS_MVA.Text;
            dgvProdutos.CurrentRow.Cells[9].Value = form.txtICMS_CSOSN.Text;

            dgvProdutos.CurrentRow.Cells[10].Value = form.txtPIS_CST_Entrada.Text;
            dgvProdutos.CurrentRow.Cells[11].Value = form.txtPIS_CST_Saida.Text;
            dgvProdutos.CurrentRow.Cells[12].Value = form.txtPIS_Alq.Text;
            dgvProdutos.CurrentRow.Cells[13].Value = form.txtPIS_CSOSN.Text;

            dgvProdutos.CurrentRow.Cells[14].Value = form.txtCOFINS_CST_Entrada.Text;
            dgvProdutos.CurrentRow.Cells[15].Value = form.txtCOFINS_CST_Saida.Text;
            dgvProdutos.CurrentRow.Cells[16].Value = form.txtCOFINS_Alq.Text;
            dgvProdutos.CurrentRow.Cells[17].Value = form.txtCOFINS_CSOSN.Text;

            dgvProdutos.CurrentRow.Cells[18].Value = form.txtIPI_CST.Text;
            dgvProdutos.CurrentRow.Cells[19].Value = form.txtIPI_Alq.Text;
            dgvProdutos.CurrentRow.Cells[20].Value = form.txtIPI_CSOSN.Text;



            validar_Dados(dgvProdutos);
        }

        private void dgvProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //Função que converte um DataGridView em DataTable
        private DataTable ToDataTable(DataGridView _dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn dataGridViewColumn in _dgv.Columns)
            {
                if (dataGridViewColumn.Visible)
                {
                    dt.Columns.Add(dataGridViewColumn.Name);
                }
            }
            var cell = new object[_dgv.Columns.Count];
            foreach (DataGridViewRow dataGridViewRow in _dgv.Rows)
            {
                for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
                {
                    cell[i] = dataGridViewRow.Cells[i].Value;
                }
                dt.Rows.Add(cell);
            }
            return dt;
        }

        //Envio de E-mail com anexos
        protected void Enviar_Email(object sender, EventArgs e, DataGridView dgv_Produto, String destino)
        {

            ///////Definição do laço de envio]

            //Título do e-mail            
            String titulo_Email = sPathReduzido.Replace("LF", "LFR").Replace(".klp", "").Replace("_PRODUTOS","");
            //Arquivo 1 (Será o arquivo Fiscal dos Produtos)            
            String archive_Produtos = sPathReduzido.Replace("LF","LFR");
            
            

            ///////Definição do caminho Salvo
            //Pega a raiz bin para salvar o arquivo produtos
            string wpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString();

            string folder = wpath + "\\" + "Layouts_Respondidos\\"; //nome do diretorio a ser criado            

            //Cria a pasta se ela não existir            
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //Table dados para o Produto
            DataTable dtProdutos = null;
            dtProdutos = ToDataTable(dgvProdutos);
            //MessageBox.Show(archive_Produtos);
            //Escrevendo arquivo json Produtos                        
            StreamWriter writer_Produtos = new StreamWriter(folder + archive_Produtos);
            writer_Produtos.Close();
            File.WriteAllText(folder + archive_Produtos, JsonConvert.SerializeObject(dtProdutos, Formatting.Indented), Encoding.UTF8);




            //Enviar e-mail
            ///                                        //Origem         //Destino
            using (MailMessage mm = new MailMessage(Email._smtpusername, Email._smtpusername))
            {
                try
                {
                    mm.Subject = titulo_Email;
                    mm.IsBodyHtml = true;

                    mm.BodyEncoding = Encoding.GetEncoding("ISO-8859-1"); // <-- Define o Encoding para aceitar caracteres especiais                    

                    //Adicionando anexos ao e-mail
                    mm.Attachments.Add(new Attachment(folder + archive_Produtos));
                    

                    //SmtpClient smtp = new SmtpClient();
                    //smtp.Host = Email._smtphostname;

                    //smtp.EnableSsl = true;
                    //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
                    //credentials.UserName = Email._smtpusername;
                    //credentials.Password = Email._password;

                    //smtp.UseDefaultCredentials = true;
                    //smtp.Credentials = credentials;
                    //smtp.Port = Email._smtpport;
                    //smtp.Send(mm);



                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = Email._smtphostname;

                    //smtp.EnableSsl = true;
                    //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
                    //credentials.UserName = Email._smtpusername;
                    //credentials.Password = Email._password;
                    //smtp.Credentials = credentials;

                    //Autenticação de Vàrios locais
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(Email._smtpusername, Email._password);

                    smtp.Port = Email._smtpport;
                    smtp.Send(mm);
                }


                catch (SmtpException except)
                {
                    MessageBox.Show(except.ToString());
                }
                finally
                {
                    mMessage = "E-mail enviado para deseja armazenar o Layout enviado?"; mTittle = "Klassifis Information";
                    mButton = MessageBoxButtons.YesNo;
                    mIcon = MessageBoxIcon.Information;
                    this.Cursor = Cursors.Default;
                    result = MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    if (result == DialogResult.Yes)
                    {
                        pExcel.exportar_ParaExcel("Class. Fiscal", dgvProdutos);
                    }
                    this.Close();
                }
            }
        }

        //Função que valida o Layout em Excel, ela aceita o número de colunas e o grid de onde os dados são apresentados

        //A função verifica a ordem, número de colunas e descrição do cabeçalho
        private bool validar_Layout(int _nColunas, DataGridView _dgv)
        {

            if (dgvProdutos.Columns.Count != _nColunas)
            {
                mMessage = "Layout Inválido, o Layout possui " + _nColunas + " e no Layout temos " + dgvProdutos.Columns.Count;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;

            }
            String nome_Coluna = null;
            int index_Coluna = 0;

            index_Coluna = 0;
            nome_Coluna = "Cod_Produto";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 1;
            nome_Coluna = "Des_Produto";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }

            index_Coluna = 2;
            nome_Coluna = "Cod_GTIN";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }

            index_Coluna = 3;
            nome_Coluna = "Cod_NCM";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 4;
            nome_Coluna = "Cod_CEST";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 5;
            nome_Coluna = "Cod_NCM_Ex";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 6;
            nome_Coluna = "ICMS_CST";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 7;
            nome_Coluna = "ICMS_ALQ";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 8;
            nome_Coluna = "ICMS_MVA";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 9;
            nome_Coluna = "ICMS_CSOSN";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 10;
            nome_Coluna = "PIS_CST_Entrada";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }

            index_Coluna = 11;
            nome_Coluna = "PIS_CST_Saida";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }

            index_Coluna = 12;
            nome_Coluna = "PIS_ALQ";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 13;
            nome_Coluna = "PIS_CSOSN";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 14;
            nome_Coluna = "COFINS_CST_Entrada";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 15;
            nome_Coluna = "COFINS_CST_Saida";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }


            index_Coluna = 16;
            nome_Coluna = "COFINS_ALQ";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 17;
            nome_Coluna = "COFINS_CSOSN";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 18;
            nome_Coluna = "IPI_CST";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 19;
            nome_Coluna = "IPI_ALQ";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }
            index_Coluna = 20;
            nome_Coluna = "IPI_CSOSN";
            if (_dgv.Columns[index_Coluna].Name.ToString() != nome_Coluna)
            {
                mMessage = "Descrição da coluna " + index_Coluna + " inválida, correta = " + nome_Coluna;
                mTittle = "Autacont Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                return false;
            }

            return true;
        }


        //Enviar Layout fiscal
        private void btnEnviar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            //Validação CNPJ
            if (!mtxCNPJ.MaskFull)
            {
                mMessage = "Preencha o campo CNPJ";
                mTittle = "Autacont";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                mtxCNPJ.Focus();
                return;
            }

            //Validação CEP
            //Serviços de busca de CPF ON
            if (cep_Exception == 0)
            {
                if (!mtxCEP.MaskFull)
                {
                    mMessage = "Preencha o campo CEP";
                    mTittle = "Autacont Error";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    mtxCEP.Focus();
                    return;
                }
            }

            //Serviços de busca de CPF OFF
            else
            {
                if (!mtxCEP.MaskFull)
                {
                    mMessage = "Preencha o campo CEP";
                    mTittle = "Autacont Error";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    mtxCEP.Focus();
                    return;
                }

                if (txtUF.Text.Equals(String.Empty))
                {
                    mMessage = "Preencha o campo UF";
                    mTittle = "Autacont";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    mtxCEP.Focus();
                    return;
                }

                if (txtCidade.Text.Equals(String.Empty))
                {
                    mMessage = "Preencha o campo Cidade";
                    mTittle = "Autacont";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    mtxCEP.Focus();
                    return;
                }
                if (txtBairro.Text.Equals(String.Empty))
                {
                    mMessage = "Preencha o campo Bairro";
                    mTittle = "Autacont";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    mtxCEP.Focus();
                    return;
                }

            }
            //Valida o Layout, verifica se corresponde às 19 casas      
            if (validar_Layout(21, dgvProdutos) == true)
            {
                
                Enviar_Email(btnEnviar, new EventArgs(), dgvProdutos, Email._smtpusername);
            }
            this.Cursor = Cursors.Default;
        }


        private void abrir_TabelaCest()
        {
            Application.Run(new frmTabelaCest());
        }

        private void btnTabCest_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(abrir_TabelaCest);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }



        private void abrir_TabelaTipi()
        {
            Application.Run(new frmTabelaTipi());
        }
     
        private void btnTipi_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;            
            Thread t1 = new Thread(abrir_TabelaTipi);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            Thread.Sleep(3000);
            this.Cursor = Cursors.Default;

        }


        private void filtrar_Dados(DataGridView _dgv, string filtro)
        {
            foreach (DataGridViewRow row in _dgv.Rows)
            {
                if (row.Cells[0].Value.ToString().ToUpper().Contains(filtro.ToUpper()) || row.Cells[1].Value.ToString().ToUpper().Contains(filtro.ToUpper())|| row.Cells[2].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                {
                    row.Visible = true;
                }
                else
                {
                    CurrencyManager cm = (CurrencyManager)BindingContext[_dgv.DataSource];
                    cm.EndCurrentEdit();
                    cm.ResumeBinding();
                    cm.SuspendBinding();                    
                    _dgv.ClearSelection();

                    row.Visible = false;
                }
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar_Dados(dgvProdutos, txtFiltro.Text);
        }

        private void dgvProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (dgvProdutos.CurrentRow.Cells[3].Selected || dgvProdutos.CurrentRow.Cells[5].Selected) 
            {
                System.Diagnostics.Process.Start("https://portalunico.siscomex.gov.br/classif/#/sumario?perfil=publico");
                Clipboard.SetText(dgvProdutos.CurrentCell.Value?.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            mMessage = "Tem certeza que deseja cancelar a operação?";
            mTittle = "Klassifis";
            mButton = MessageBoxButtons.YesNo;
            mIcon = MessageBoxIcon.Warning;
            result = MessageBox.Show(mMessage, mTittle, mButton, mIcon);

            if (result == DialogResult.Yes) 
            {
                this.Close();
            }          
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
