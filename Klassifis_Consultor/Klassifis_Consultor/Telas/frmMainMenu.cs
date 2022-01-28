using Klassifis_Consultor.Telas;
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

namespace Klassifis_Consultor
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        ////////////////////////////Instância




        
        ///////////////////////Funções internas do Formulário
        
        //Abrindo o form para Baixar a classificação fiscal
        private void abrir_BaixcarClassFiscal()
        {
            Application.Run(new frmBaixarClassificacaoFiscal());
        }

        private void btnBaixarClassFiscal_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(abrir_BaixcarClassFiscal);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            
        }


        //Abrindo o form para listar as classificações fiscais baixadas
        private void abrir_ListaDeClassificacoes()
        {
            Application.Run(new frmListaLayoutFiscal());
        }


        private void frmListaDeClassificacoes_Click(object sender, EventArgs e)
        {
            Thread t2 = new Thread(abrir_ListaDeClassificacoes);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }
    }
}
