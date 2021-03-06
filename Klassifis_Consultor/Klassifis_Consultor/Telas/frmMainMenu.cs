using Klassifis_Consultor.Telas;
using kLib;
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
        Fiscal_Tabelas Tabelas_Fiscais = new Fiscal_Tabelas(); 
        //Variáveis da caixa de texto
        String mMessage;
        String mTittle;
        MessageBoxButtons mButton;
        MessageBoxIcon mIcon;
        DialogResult result;





        ///////////////////////Funções internas do Formulário

        //Configurações Iniciais
        private void configuracoes_Iniciais()
        {

            mMessage = "Klassifis Software versão consultor (v1.3) - Versão Testes";
            mTittle = "Bem vindo!!";
            mButton = MessageBoxButtons.OK;
            mIcon = MessageBoxIcon.Information;
            MessageBox.Show(mMessage, mTittle, mButton, mIcon);


            //Icon
            this.Icon = Properties.Resources.klassifis_logo_azulado;


            //Background
            this.BackgroundImage = Properties.Resources.klassifis_main_menu;
            this.BackgroundImageLayout = ImageLayout.Stretch;



            //Carregando variáveis estáticas
            Tabelas_Fiscais.carregar_CatProduto();
            Tabelas_Fiscais.carregar_DescTipi();
            Task.Factory.StartNew(() => Tabelas_Fiscais.carregar_Tabela_Tipi());
            Task.Factory.StartNew(() => Tabelas_Fiscais.carregar_Tabela_CST_Pis_Cofins());
            Task.Factory.StartNew(() => Tabelas_Fiscais.carregar_Tabela_CST_Ipi());
            Task.Factory.StartNew(() => Tabelas_Fiscais.carregar_Tabela_CSOSN_Ipi());

        }

        //Load do form
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            configuracoes_Iniciais();
        }


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




        //Abrindo o form para listar as classificações fiscais baixadas
        private void abrir_LayoutsEnviados()
        {
            Application.Run(new frmLayoutsEnviados());
        }
        private void btnLayoutsEnvados_Click(object sender, EventArgs e)
        {
            Thread t3 = new Thread(abrir_LayoutsEnviados);
            t3.SetApartmentState (ApartmentState.STA);
            t3.Start();
        }


        //Fechar form
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            mMessage = "Tem certeza que deseja encerrar a aplciação?";
            mTittle = "Encerrar sistema";
            mButton = MessageBoxButtons.YesNo;
            mIcon = MessageBoxIcon.Warning;
            result = MessageBox.Show(mMessage, mTittle, mButton, mIcon);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        
    }
}
