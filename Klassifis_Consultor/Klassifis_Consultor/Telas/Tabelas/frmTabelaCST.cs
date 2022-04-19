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
    public partial class frmTabelaCST : Form
    {
        public frmTabelaCST()
        {
            InitializeComponent();
        }

        //Configurações Iniciais 
        private void configuracoes_Iniciais()
        {
            this.Icon = Properties.Resources.klassifis_logo_azulado;
        }
            
        //Load do form
        private void frmTabelaCST_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
        }


        //Abrir tabelas de PIS e COFINS
        private void abrir_TabelaCST_PisCofins()
        {
            Application.Run(new frmTabelaCST_PisCofins());
        }
        private void btnCST_PIS_COFINS_Click(object sender, EventArgs e)
        {
            Thread tAbrirTabela_PisCofins = new Thread(new ThreadStart(abrir_TabelaCST_PisCofins));
            tAbrirTabela_PisCofins.SetApartmentState(ApartmentState.STA);
            tAbrirTabela_PisCofins.Start();
        }

        //Abrir tabelas de IPI
        private void abrir_TabelaCST_Ipi()
        {
            Application.Run(new frmTabelaCST_Ipi());
        }
        private void btnCST_IPI_Click(object sender, EventArgs e)
        {
            Thread tAbrirTabela_Ipi = new Thread(new ThreadStart(abrir_TabelaCST_Ipi));
            tAbrirTabela_Ipi.SetApartmentState(ApartmentState.STA);
            tAbrirTabela_Ipi.Start();
        }

        //Fecha o form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
