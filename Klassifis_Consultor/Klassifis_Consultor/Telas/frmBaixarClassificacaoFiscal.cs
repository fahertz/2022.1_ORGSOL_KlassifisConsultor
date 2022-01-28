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
        DialogResult result;

        ////////////////////Métodos internos da tela
        //Configurações Iniciais
        private void configuracoes_Iniciais()
        {
            //Deixando como falso a visibilidade dos informativos de Listagem
            lblCarregando.Visible = false;
            lblBaixando.Visible = false;

            //Configura o dgvDados para verificar
            configurar_DataGridView(dgvDados);
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
            var col = new DataGridViewCheckBoxColumn();
            col.Name = "Download";
            col.HeaderText = "Download";
            col.FalseValue = "0";
            col.TrueValue = "1";
            //Faz a marcação padrão
            col.CellTemplate.Value = true;
            col.CellTemplate.Style.NullValue = true;
            //Insere a coluna 1
            _dgv.Columns.Insert(1, col);
            //Deixa a coluna Invisível
            _dgv.Columns[0].Visible = false;
            //Coluna inativada, será reativada em versões posteriores
            _dgv.Columns[1].Visible = false;
            _dgv.Columns[3].Width = 150;
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
                            _dgv.Invoke((MethodInvoker)(delegate {
                                if (resp == 1)
                                {


                                    _dgv.Rows.Add(
                                        popEmail.Headers.MessageId
                                        , 0
                                        , add[1]
                                        , Convert.ToDateTime((popEmail.Headers.Date).Replace("(PDT)", "").Replace("(PST)", ""))
                                        , "Respondido"
                                        );
                                }
                                else
                                {
                                    _dgv.Rows.Add(
                                          popEmail.Headers.MessageId
                                        , 0
                                        , add[1]
                                        , Convert.ToDateTime((popEmail.Headers.Date).Replace("(PDT)", "").Replace("(PST)", ""))
                                        , "Não Respondido"
                                        );
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

                _dgv.Invoke((MethodInvoker)(delegate
               {

                   foreach (DataGridViewRow row in _dgv.Rows)
                   {
                       if (row.Cells[4].Value.ToString().Equals("Respondido"))
                       {
                           row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                       }
                   }
                   _dgv.Sort(_dgv.Columns[3], ListSortDirection.Descending);
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

            this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.Default; });
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            
                Thread t1 = new Thread(baixar_Emails);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            

        }

        //Botão para carregar os e-mails na Grid

        private void carregar_Lista_Emails()
        {
            this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.WaitCursor; });
            carregar_Emails_Grid(dgvDados);
            mMessage = "Listagem realizada com sucesso!";
            mTittle = "Klassifis Information";
            mButton = MessageBoxButtons.OK;
            mIcon = MessageBoxIcon.Information;
            this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.Default; });
            MessageBox.Show(mMessage, mTittle, mButton, mIcon);
            lblCarregando.Invoke((MethodInvoker)(delegate { lblCarregando.Visible = false; }));
                

        }
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            
            Thread t2 = new Thread(carregar_Lista_Emails);                         
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();                                                
        }

        //Limpa as linhas do Grid
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.Clear();
        }

        private void btnBaixados_Click(object sender, EventArgs e)
        {
            
        }



        //Fechar Form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
