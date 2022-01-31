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

namespace Klassifis_Consultor.Telas
{
    public partial class frmEditarLayoutFiscal_Manual : Form
    {
        public frmEditarLayoutFiscal_Manual()
        {
            InitializeComponent();
        }
        //////////////////////////// Instância
        Funcoes_Sistema fSistema = new Funcoes_Sistema();

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




        private void frmEditarLayoutFiscal_Manual_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
        }


        private void txtCod_CEST_Validating(object sender, CancelEventArgs e)
        {
            if (fSistema.contar_Numeros(txtCod_CEST.Text) != 7)
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

        ///////////////////ICMS
        private void txtICMS_CST_Validating(object sender, CancelEventArgs e)
        {
            cst_Validation(txtICMS_CST, lblICMS_CST);
        }

        private void txtICMS_Alq_Validating(object sender, CancelEventArgs e)
        {
            txtICMS_Alq.Text = fSistema.mascara_Double(txtICMS_Alq.Text);
        }

        private void txtICMS_CSOSN_Validating(object sender, CancelEventArgs e)
        {
            txtICMS_CSOSN.Text = fSistema.mascara_Double(txtICMS_CSOSN.Text);
        }
        
        private void txtICMS_MVA_Validating(object sender, CancelEventArgs e)
        {
            txtICMS_MVA.Text = fSistema.mascara_Double(txtICMS_MVA.Text);
        }

        //////////////////IPI
        private void txtIPI_CST_Validating(object sender, CancelEventArgs e)
        {
            cst_Validation(txtIPI_CST, lblIPI_CST);
        }

        private void txtIPI_CSOSN_Validating(object sender, CancelEventArgs e)
        {
            txtIPI_CSOSN.Text = fSistema.mascara_Double(txtIPI_CSOSN.Text);
        }

        private void txtIPI_Alq_Validating(object sender, CancelEventArgs e)
        {
            txtIPI_Alq.Text = fSistema.mascara_Double(txtIPI_Alq.Text);
        }


        //////////////////PIS
        private void txtPIS_CST_Validating(object sender, CancelEventArgs e)
        {
            cst_Validation(txtPIS_CST, lblPIS_CST);
        }

        private void txtPIS_CSOSN_Validating(object sender, CancelEventArgs e)
        {
            txtPIS_CSOSN.Text = fSistema.mascara_Double(txtPIS_CSOSN.Text);
        }

        private void txtPIS_Alq_Validating(object sender, CancelEventArgs e)
        {
            txtPIS_Alq.Text = fSistema.mascara_Double(txtPIS_Alq.Text);
        }


        /////////////////////////COFINS
        private void txtCOFINS_CST_Validating(object sender, CancelEventArgs e)
        {
            cst_Validation(txtCOFINS_CST, lblCOFINS_CST);
        }

        private void txtCOFINS_Alq_Validating(object sender, CancelEventArgs e)
        {
            txtCOFINS_Alq.Text = fSistema.mascara_Double(txtCOFINS_Alq.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCOFINS_CSOSN_Validating(object sender, CancelEventArgs e)
        {
            txtCOFINS_CSOSN.Text = fSistema.mascara_Double(txtCOFINS_CSOSN.Text);
        }



    }
}
