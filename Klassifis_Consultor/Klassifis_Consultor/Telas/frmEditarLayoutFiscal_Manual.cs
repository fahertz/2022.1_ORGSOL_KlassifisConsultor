using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klassifis_Consultor.Telas.Tabelas;
using kLib;

namespace Klassifis_Consultor.Telas
{
    public partial class frmEditarLayoutFiscal_Manual : Form
    {
        public frmEditarLayoutFiscal_Manual()
        {
            InitializeComponent();
        }
        //////////////////////////// Instância        

        //Variáveis Text box
        private String mMessage, mTittle;
        private MessageBoxButtons mButton;
        private new MessageBoxIcon mIcon = MessageBoxIcon.Asterisk;
        DialogResult result;



        
        //////////////////////////Funções Gerais internas
        
        private void configuracoes_Iniciais()
        {
            //Icon
            this.Icon = Properties.Resources.klassifis_logo_azulado;
        }
        
        
        private void aceita_Numeros_Ponto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void aceita_Numeros_Virgula(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }


        private void aceita_Numeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Validação do CST

        private void cst_Validation(TextBox textbox, Label label)
        {
            if (textbox.Text.Length < 2)
            {
                mMessage = "CST inválido.";
                mTittle = "Klassifis validation";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                textbox.ForeColor = Color.Red;
                label.ForeColor = Color.Red;
                textbox.Focus();
            }
            else
            {
                if (textbox.ForeColor == Color.Red) 
                {
                    textbox.ForeColor = Color.Black;
                    label.ForeColor = Color.Black;
                }
            }
        }

        private void ncm_Validation(TextBox textbox, Label label)
        {
            if (!textbox.Text.Trim().Equals(String.Empty)) {
                if (textbox.Text.Length != 8)
                {
                    mMessage = "O NCM deve ter 8 dígitos.";
                    mTittle = "Klassifis validation";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    textbox.ForeColor = Color.Red;
                    label.ForeColor = Color.Red;
                    textbox.Focus();
                }
                else if (!textbox.Text.Equals(String.Empty) && Fiscal.Validar_NCM(textbox.Text) != true)
                {
                    mMessage = "NCM incorreto, para dúvidas verifique a tabela TIPI.";
                    mTittle = "Klassifis warming";
                    mButton = MessageBoxButtons.OK;
                    mIcon = MessageBoxIcon.Error;
                    MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                    textbox.ForeColor = Color.Red;
                    label.ForeColor = Color.Red;
                    btnTipi_Click(btnTipi, new EventArgs());
                    textbox.Focus();
                }
                else
                {
                    if (textbox.ForeColor == Color.Red)
                    {
                        textbox.ForeColor = Color.Black;
                        label.ForeColor = Color.Black;
                        textbox.Focus();
                    }
                }
            }
        }




        private void frmEditarLayoutFiscal_Manual_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
        }


        private void txtCod_CEST_Validating(object sender, CancelEventArgs e)
        {
            if (txtCod_CEST.Text.contar_Numeros() != 7)
            {
                mMessage = "CEST inválido.";
                mTittle = "Klassifis validation";
                mButton = MessageBoxButtons.OK;
                mIcon = MessageBoxIcon.Error;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
                txtCod_CEST.ForeColor = Color.Red;
                lblCod_CEST.ForeColor = Color.Red;
                txtCod_CEST.Focus();
            }
            else
            {
                if (txtCod_CEST.ForeColor == Color.Red)
                {
                    txtCod_CEST.ForeColor = Color.Black;
                    lblCod_CEST.ForeColor = Color.Black;
                }
            }
        }

        private void txtCod_NCM_Validating(object sender, CancelEventArgs e)
        {
            ncm_Validation(txtCod_NCM, lblCod_NCM);
        }

        private void txtCod_NCM_Ex_Validating(object sender, CancelEventArgs e)
        {
            ncm_Validation(txtCod_NCM_Ex, lblCod_NCM_Ex);
        }


        ///////////////////ICMS
        private void txtICMS_CST_Validating(object sender, CancelEventArgs e)
        {
            cst_Validation(txtICMS_CST, lblICMS_CST);
        }

        private void txtICMS_Alq_Validating(object sender, CancelEventArgs e)
        {
            txtICMS_Alq.Text = txtICMS_Alq.Text.mascarar_Double();
        }

        private void txtICMS_CSOSN_Validating(object sender, CancelEventArgs e)
        {
            txtICMS_CSOSN.Text = txtICMS_CSOSN.Text.mascarar_Double();
        }
        
        private void txtICMS_MVA_Validating(object sender, CancelEventArgs e)
        {
            txtICMS_MVA.Text = txtICMS_MVA.Text.mascarar_Double();
        }

        //////////////////IPI
        private void txtIPI_CST_Validating(object sender, CancelEventArgs e)
        {
            cst_Validation(txtIPI_CST, lblIPI_CST);
        }

        private void txtIPI_CSOSN_Validating(object sender, CancelEventArgs e)
        {
            txtIPI_CSOSN.Text = txtIPI_CSOSN.Text.mascarar_Double();
        }

        private void txtIPI_Alq_Validating(object sender, CancelEventArgs e)
        {
            txtIPI_Alq.Text = txtIPI_Alq.Text.mascarar_Double();
        }


        //////////////////PIS
        private void txtPIS_CST_Validating(object sender, CancelEventArgs e)
        {
            cst_Validation(txtPIS_CST_Entrada, lblPIS_CST_Entrada);
        }
        private void txtPIS_CST_Saida_TextChanged(object sender, EventArgs e)
        {
            cst_Validation(txtPIS_CST_Saida, lblPIS_CST_Saida);
        }
        private void txtPIS_CSOSN_Validating(object sender, CancelEventArgs e)
        {
            txtPIS_CSOSN.Text = txtPIS_CSOSN.Text.mascarar_Double();
        }

        private void txtPIS_Alq_Validating(object sender, CancelEventArgs e)
        {
            txtPIS_Alq.Text = txtPIS_Alq.Text.mascarar_Double();
        }


        /////////////////////////COFINS
        private void txtCOFINS_CST_Validating(object sender, CancelEventArgs e)
        {
            cst_Validation(txtCOFINS_CST_Entrada, lblCOFINS_CST_Entrada);
        }

        private void txtCOFINS_CST_Saida_Validating(object sender, CancelEventArgs e)
        {
            cst_Validation(txtCOFINS_CST_Saida, lblCOFINS_CST_Saida);
        }

        private void txtCOFINS_Alq_Validating(object sender, CancelEventArgs e)
        {
            txtCOFINS_Alq.Text = txtCOFINS_Alq.Text.mascarar_Double();
        }

      

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void abrir_TabelaCest()
        {
            Application.Run(new frmTabelaCST_PisCofins());
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


        private void txtCOFINS_CSOSN_Validating(object sender, CancelEventArgs e)
        {
            txtCOFINS_CSOSN.Text = txtCOFINS_CSOSN.Text.mascarar_Double();
        }



    }
}
