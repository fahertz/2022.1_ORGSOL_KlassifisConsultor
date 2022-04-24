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

namespace Klassifis_Consultor.Telas.Tabelas
{
    public partial class frmTabelaCSOSN : Form
    {
        public frmTabelaCSOSN()
        {
            InitializeComponent();
        }


        //Configurações Iniciais do FORM
        private void configuracoes_Iniciais()
        {
            this.Icon = Properties.Resources.klassifis_logo_azulado;
        }


        private void frmTabelaCSOSN_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void abrir_Tabela_CSOSN_IPI()
        {
            Application.Run(new frmTabelaCSOSN_IPI());
        }

        private void btnCSOSN_IPI_Click(object sender, EventArgs e)
        {
            Thread tAbrirTabelaCSOSN_IPI = new Thread(abrir_Tabela_CSOSN_IPI);
            tAbrirTabelaCSOSN_IPI.SetApartmentState(ApartmentState.STA);
            tAbrirTabelaCSOSN_IPI.Start();

        }
    }
}
