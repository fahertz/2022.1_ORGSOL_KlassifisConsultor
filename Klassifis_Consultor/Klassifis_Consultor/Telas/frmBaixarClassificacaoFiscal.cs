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
using kLib;
using OpenPop.Pop3;

namespace Klassifis_Consultor.Telas
{
    public partial class frmBaixarClassificacaoFiscal : Form
    {
        public frmBaixarClassificacaoFiscal()
        {
            InitializeComponent();
        }

        ///////////////Instância

        //Variáveis Text box
        private String mMessage, mTittle;
        private MessageBoxButtons mButton;
        private new MessageBoxIcon mIcon = MessageBoxIcon.Asterisk;
        
        List<Baixar_Classificacao> lBaixar_Classificacao = new List<Baixar_Classificacao>();


        ////////////////////Métodos internos da tela
        //Configurações Iniciais
        private void configuracoes_Iniciais()
        {
            //Icon
            this.Icon = Properties.Resources.klassifis_logo_azulado;

            //Deixando como falso a visibilidade dos informativos de Listagem
            lblCarregando.Visible = false;
            lblBaixando.Visible = false;

            //Configura o dgvDados para verificar
            configurar_DataGridView(dgvDados);
            Task.Factory.StartNew(() => carregar_Lista_Emails());

            //btnCarregar_Click(btnCarregar, new EventArgs());
        }


        //Configura o DataGridView
        private void configurar_DataGridView(DataGridView _dgv)
        {
            _dgv.Columns.Add("ID_Email", "ID_Email"); //0
            _dgv.Columns.Add("CNPJ_Cliente", "CNPJ"); //1
            _dgv.Columns.Add("Data_Recebimento", "Data"); //2
            _dgv.Columns.Add("Status", "Resposta");
            //Cria coluna Checável para o DataGridView
            //var col = new DataGridViewCheckBoxColumn();
            //col.Name = "Download";
            //col.HeaderText = "Download";
            //col.FalseValue = "0";
            //col.TrueValue = "1";
            //Faz a marcação padrão
            //col.CellTemplate.Value = true;
            //col.CellTemplate.Style.NullValue = true;
            ////Insere a coluna 1
            //_dgv.Columns.Insert(1, col);
            //Deixa a coluna Invisível
            _dgv.Columns[0].Visible = false;
            //Coluna inativada, será reativada em versões posteriores
            //_dgv.Columns[1].Visible = false;
            _dgv.Columns[2].Width = 150;
        }


        //Carrega os e-mails no DataGridView
        private void carregar_Emails_Grid(DataGridView _dgv)
        {
            _dgv.Rows.Clear();

            try
            {
                using (var client = new OpenPop.Pop3.Pop3Client())
                {
                    client.Connect(Email._pophostname, Email._popport, Email._useSsl);
                    client.Authenticate(Email._popusername, Email._password);
                    int messageCount = client.GetMessageCount();
                    Email._emails.Clear();

                    int mensagensCarregadas = 0;
                    int mensagens_aCarregar = 0;



                    for (int i = messageCount; i > 0; i--)
                    {
                        var popEmail2 = client.GetMessage(i);
                        if (popEmail2.Headers.Subject.Contains("LF_"))
                            mensagens_aCarregar++;
                    }




                    lblCarregando.Invoke((MethodInvoker)delegate
                    {
                        lblCarregando.Visible = true;
                        lblCarregando.Text = "Carregando....(" + mensagensCarregadas + " / " + mensagens_aCarregar + ")";
                    });

                    List<String> email = new List<String>();

                    for (int i = messageCount; i > 0; i--)
                    {
                        var popEmail2 = client.GetMessage(i);
                        if (popEmail2.Headers.Subject.Contains("LFR_"))
                            email.Add(popEmail2.Headers.Subject);
                    }

                    for (int i = messageCount; i > 0; i--)
                    {
                        var popEmail = client.GetMessage(i);
                        var popText = popEmail.FindFirstPlainTextVersion();
                        var popHtml = popEmail.FindFirstHtmlVersion();

                        string mailText = string.Empty;
                        string mailHtml = string.Empty;
                        if (popText != null)
                            mailText = popText.GetBodyAsText();
                        if (popHtml != null)
                            mailHtml = popHtml.GetBodyAsText();



                        if (popEmail.Headers.Subject.Contains("LF_"))
                        {
                            int resp = 0;


                            foreach (var subject in email)
                            {
                                if (popEmail.Headers.Subject.Replace("LF", "LFR").Equals(subject))
                                {
                                    resp = 1;
                                    break;
                                }
                            }


                            //foreach (var attachment in popEmail.FindAllAttachments())
                            //{
                            //    if (attachment.FileName.Contains(".klp"))
                            //    {
                            //        resp = 1;
                            //        break;
                            //    }
                            //}
                            String[] add = null;
                            add = popEmail.Headers.Subject.ToString().Split('_');
                            _dgv.Invoke((MethodInvoker)(delegate
                            {                               
                                if (resp == 1)
                                {
                                    lBaixar_Classificacao.Add(new Baixar_Classificacao
                                    {
                                        Id = popEmail.Headers.MessageId,
                                        CNPJ_Cliente = add[1],
                                        Data_Recebimento = Convert.ToDateTime((popEmail.Headers.Date).Replace("(PDT)", "").Replace("(PST)", "")),
                                        Status = "Respondido"
                                    });

                                }
                                else
                                {
                                    lBaixar_Classificacao.Add(new Baixar_Classificacao
                                    {
                                        Id = popEmail.Headers.MessageId,
                                        CNPJ_Cliente = add[1],
                                        Data_Recebimento = Convert.ToDateTime((popEmail.Headers.Date).Replace("(PDT)", "").Replace("(PST)", "")),
                                        Status = "Não Respondido"
                                    });
                                }

                            }));
                            mensagensCarregadas++;
                            lblCarregando.Invoke((MethodInvoker)delegate { lblCarregando.Text = "Carregando....(" + mensagensCarregadas + " / " + mensagens_aCarregar + ")"; });

                        }
                    }
                }
            }
            finally
            {

                //var filtro_Inicial = lBaixar_Classificacao.Select(x => x.Data_Recebimento).OrderByDescending(x=> x.Date);

                var filtro_Inicial = from Classificacao in lBaixar_Classificacao
                                     orderby Classificacao.Data_Recebimento descending
                                     select new { Classificacao }
                                      ;

                _dgv.Invoke((MethodInvoker)(delegate
               {
                   foreach (var classi in filtro_Inicial)
                   {
                       _dgv.Rows.Add(classi.Classificacao.Id, classi.Classificacao.CNPJ_Cliente, classi.Classificacao.Data_Recebimento, classi.Classificacao.Status);
                   }
                   foreach (DataGridViewRow row in _dgv.Rows)
                   {
                       if (row.Cells["Status"].Value.ToString().Equals("Respondido"))
                       {
                           row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                       }
                   }
               }));               
            }
        }
        


        //Baixa o arquivo para a pasta Raiz do Projeto
        private void baixar_Arquivos(DataGridViewRow _row)
        {
            string wpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString();
            string folder = wpath + "\\" + "LF"; //nome do diretorio a ser criado
            //Se o diretório não existir...

            if (!Directory.Exists(folder))
            {
                //Criamos um com o nome folder
                Directory.CreateDirectory(folder);

            }

            var client = new Pop3Client();
            try
            {
                //Define o Hist_Name, Porta e se usa SSL ou não
                client.Connect(Email._pophostname, Email._popport, Email._useSsl);
                client.Authenticate(Email._popusername, Email._password);
                var messageCount = client.GetMessageCount();
                var Messages = new List<OpenPop.Mime.Message>(messageCount);

                for (int i = 0; i < messageCount; i++)
                {
                    OpenPop.Mime.Message getMessage = client.GetMessage(i + 1);
                    if (_row.Cells[0].Value.ToString() == getMessage.Headers.MessageId.ToString())
                    {
                        Messages.Add(getMessage);
                    }

                }
                foreach (OpenPop.Mime.Message msg in Messages)
                {
                    foreach (var attachment in msg.FindAllAttachments())
                    {
                        string filePath = Path.Combine(@folder, attachment.FileName);
                        FileStream Stream = new FileStream(filePath, FileMode.Create);
                        BinaryWriter BinaryStream = new BinaryWriter(Stream);
                        BinaryStream.Write(attachment.Body);
                        BinaryStream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("", ex.Message);
            }
            finally
            {
                if (client.Connected)
                    client.Dispose();
            }
        }








        //////////////Métodos dos componentes

        //Load do form
        private void frmBaixarClassificacaoFiscal_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
                        
        }

        //Baixar e-mails

        private void baixar_Emails()
        {
            this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.WaitCursor; });

            btnCarregar.Invoke((MethodInvoker)delegate { btnCarregar.Enabled = false; });
            btnFiltrar.Invoke((MethodInvoker)delegate { btnFiltrar.Enabled = false; });


            if (dgvDados.SelectedRows != null && dgvDados.CurrentRow!= null)
            {
                lblBaixando.Invoke((MethodInvoker)delegate { lblBaixando.Visible = true; });
                int contador_Downloads = 0;

                lblBaixando.Invoke((MethodInvoker)delegate { lblBaixando.Text = "Baixando ... (" + contador_Downloads + "/" + dgvDados.SelectedRows.Count.ToString() + ")"; });
                foreach (DataGridViewRow row in dgvDados.SelectedRows)
                {
                    baixar_Arquivos(row);
                    contador_Downloads++;
                    lblBaixando.Invoke((MethodInvoker)delegate { lblBaixando.Text = "Baixando ... (" + contador_Downloads + "/" + dgvDados.SelectedRows.Count.ToString() + ")"; });
                }
                mMessage = "Download realizado com sucesso!";
                mTittle = "Klassifis Information";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Information;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                lblBaixando.Invoke((MethodInvoker)delegate { lblBaixando.Visible = false; });
            }
            else
            {
                mMessage = "Por favor selecione algum Layout para baixar";
                mTittle = "Klassifis Alert";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Warning;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
            }



            btnCarregar.Invoke((MethodInvoker)delegate { btnCarregar.Enabled = true; });
            btnFiltrar.Invoke((MethodInvoker)delegate { btnFiltrar.Enabled = true; });

            this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.Default; });
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => baixar_Emails());
        }

        //Botão para carregar os e-mails na Grid

        private void carregar_Lista_Emails()
        {
            lBaixar_Classificacao.Clear();
            this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.WaitCursor; });
            btnFiltrar.Invoke((MethodInvoker)delegate
            {
                btnFiltrar.Enabled = false;
            });


            this.Invoke((MethodInvoker)delegate 
            { 
                btnCarregar.Enabled = false;
                btnCarregar.Text = "Carregando...";               
            });
            carregar_Emails_Grid(dgvDados);            
            mMessage = "Listagem realizada com sucesso!";
            mTittle = "Klassifis Information";
            mButton = MessageBoxButtons.OK;
            mIcon = MessageBoxIcon.Information;
            this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.Default; });
            MessageBox.Show(mMessage, mTittle, mButton, mIcon);
            lblCarregando.Invoke((MethodInvoker)(delegate { lblCarregando.Visible = false; }));

            this.Invoke((MethodInvoker)delegate
            {
                btnCarregar.Enabled = true;
                btnCarregar.Text = "Carregar";
            });

            btnFiltrar.Invoke((MethodInvoker)delegate
            {
                btnFiltrar.Enabled = true;
            });


        }
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => carregar_Lista_Emails());
        }

        //Limpa as linhas do Grid
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.Clear();
        }



        //Abrir tela dos layouts baixados
        //Abrindo o form para listar as classificações fiscais baixadas
        private void abrir_ListaDeClassificacoes()
        {
            Application.Run(new frmListaLayoutFiscal());
        }
        private void btnBaixados_Click(object sender, EventArgs e)
        {
            Thread t3 = new Thread(abrir_ListaDeClassificacoes);
            t3.SetApartmentState (ApartmentState.STA);
            t3.Start();
        }

        //Botão Filtrar CNPJ
        private void txtFiltrar_Click(object sender, EventArgs e)
        {                                       
            
            this.Cursor = Cursors.WaitCursor;
            dgvDados.Rows.Clear();

            var listaEmail = from Classificacao in lBaixar_Classificacao
                             where Classificacao.CNPJ_Cliente.Contains(mtxCNPJ.Text.ToString().Replace(",", "").Replace("-", "").Replace("/", "").Replace(".", "").Trim())
                             orderby Classificacao.Data_Recebimento descending
                             select new { Classificacao };

            foreach (var lista_Filtrada in listaEmail)
            {
                dgvDados.Rows.Add(lista_Filtrada.Classificacao.Id, lista_Filtrada.Classificacao.CNPJ_Cliente, lista_Filtrada.Classificacao.Data_Recebimento, lista_Filtrada.Classificacao.Status);
            }
            
            foreach (DataGridViewRow row in dgvDados.Rows)
            {
                if (row.Cells["Status"].Value.ToString().Equals("Respondido"))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
            }
            this.Cursor = Cursors.Default;
        }

        
        //Pesquisar o CNPJ com o enter
        private void mtxCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnFiltrar.Enabled == true)
            {
                txtFiltrar_Click(btnFiltrar, new EventArgs());
            }            
        }

        private void mtxCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        //Fechar Form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
