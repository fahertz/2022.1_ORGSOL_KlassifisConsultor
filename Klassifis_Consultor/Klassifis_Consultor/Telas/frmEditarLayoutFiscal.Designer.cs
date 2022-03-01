namespace Klassifis_Consultor.Telas
{
    partial class frmEditarLayoutFiscal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnAbrirExcel = new System.Windows.Forms.Button();
            this.btnEntradaManual = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblEnviarClassificacaoFiscal = new System.Windows.Forms.Label();
            this.gpbDadosDoCliente = new System.Windows.Forms.GroupBox();
            this.mtxCNAE = new System.Windows.Forms.MaskedTextBox();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.lblIE = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.mtxContato = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gpbAtividade = new System.Windows.Forms.GroupBox();
            this.rdbVarejo = new System.Windows.Forms.RadioButton();
            this.rdbComercio = new System.Windows.Forms.RadioButton();
            this.rdbAtacado = new System.Windows.Forms.RadioButton();
            this.gpbRegime = new System.Windows.Forms.GroupBox();
            this.rdbReal = new System.Windows.Forms.RadioButton();
            this.rdbPresumido = new System.Windows.Forms.RadioButton();
            this.rdbSimples = new System.Windows.Forms.RadioButton();
            this.lblCNAE = new System.Windows.Forms.Label();
            this.mtxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.mtxCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbRegras = new System.Windows.Forms.ListBox();
            this.lblRegras = new System.Windows.Forms.Label();
            this.btnTabCest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gpbDadosDoCliente.SuspendLayout();
            this.gpbAtividade.SuspendLayout();
            this.gpbRegime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblArquivo.Location = new System.Drawing.Point(9, 217);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(62, 16);
            this.lblArquivo.TabIndex = 93;
            this.lblArquivo.Text = "Arquivo";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(308, 234);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 92;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(12, 236);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(290, 20);
            this.txtArquivo.TabIndex = 91;
            // 
            // btnAbrirExcel
            // 
            this.btnAbrirExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirExcel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAbrirExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbrirExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirExcel.Font = new System.Drawing.Font("Century Schoolbook", 7F, System.Drawing.FontStyle.Bold);
            this.btnAbrirExcel.ForeColor = System.Drawing.Color.White;
            this.btnAbrirExcel.Location = new System.Drawing.Point(136, 560);
            this.btnAbrirExcel.Name = "btnAbrirExcel";
            this.btnAbrirExcel.Size = new System.Drawing.Size(117, 24);
            this.btnAbrirExcel.TabIndex = 90;
            this.btnAbrirExcel.Text = "Abrir em Excel";
            this.btnAbrirExcel.UseVisualStyleBackColor = false;
            this.btnAbrirExcel.Click += new System.EventHandler(this.btnAbrirExcel_Click);
            // 
            // btnEntradaManual
            // 
            this.btnEntradaManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntradaManual.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEntradaManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntradaManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntradaManual.Font = new System.Drawing.Font("Century Schoolbook", 7F, System.Drawing.FontStyle.Bold);
            this.btnEntradaManual.ForeColor = System.Drawing.Color.White;
            this.btnEntradaManual.Location = new System.Drawing.Point(259, 560);
            this.btnEntradaManual.Name = "btnEntradaManual";
            this.btnEntradaManual.Size = new System.Drawing.Size(117, 24);
            this.btnEntradaManual.TabIndex = 89;
            this.btnEntradaManual.Text = "Alterar visão";
            this.btnEntradaManual.UseVisualStyleBackColor = false;
            this.btnEntradaManual.Click += new System.EventHandler(this.btnEntradaManual_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportarExcel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Schoolbook", 7F, System.Drawing.FontStyle.Bold);
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(13, 560);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(117, 24);
            this.btnExportarExcel.TabIndex = 88;
            this.btnExportarExcel.Text = "Exportar em Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1051, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 35);
            this.btnCancelar.TabIndex = 86;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(1148, 560);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(91, 35);
            this.btnEnviar.TabIndex = 85;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 262);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1226, 292);
            this.dgvProdutos.TabIndex = 84;
            this.dgvProdutos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellEndEdit);
            this.dgvProdutos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvProdutos_CellValidating);
            this.dgvProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProdutos_KeyDown);
            this.dgvProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProdutos_KeyPress);
            // 
            // lblEnviarClassificacaoFiscal
            // 
            this.lblEnviarClassificacaoFiscal.AutoSize = true;
            this.lblEnviarClassificacaoFiscal.BackColor = System.Drawing.Color.DarkGray;
            this.lblEnviarClassificacaoFiscal.Font = new System.Drawing.Font("Century Schoolbook", 25F, System.Drawing.FontStyle.Bold);
            this.lblEnviarClassificacaoFiscal.Location = new System.Drawing.Point(12, 12);
            this.lblEnviarClassificacaoFiscal.Name = "lblEnviarClassificacaoFiscal";
            this.lblEnviarClassificacaoFiscal.Size = new System.Drawing.Size(384, 40);
            this.lblEnviarClassificacaoFiscal.TabIndex = 83;
            this.lblEnviarClassificacaoFiscal.Text = "Editar Layout Fiscal";
            // 
            // gpbDadosDoCliente
            // 
            this.gpbDadosDoCliente.Controls.Add(this.mtxCNAE);
            this.gpbDadosDoCliente.Controls.Add(this.txtIE);
            this.gpbDadosDoCliente.Controls.Add(this.lblIE);
            this.gpbDadosDoCliente.Controls.Add(this.lblContato);
            this.gpbDadosDoCliente.Controls.Add(this.mtxContato);
            this.gpbDadosDoCliente.Controls.Add(this.txtEmail);
            this.gpbDadosDoCliente.Controls.Add(this.lblEmail);
            this.gpbDadosDoCliente.Controls.Add(this.gpbAtividade);
            this.gpbDadosDoCliente.Controls.Add(this.gpbRegime);
            this.gpbDadosDoCliente.Controls.Add(this.lblCNAE);
            this.gpbDadosDoCliente.Controls.Add(this.mtxCNPJ);
            this.gpbDadosDoCliente.Controls.Add(this.lblCNPJ);
            this.gpbDadosDoCliente.Controls.Add(this.mtxCEP);
            this.gpbDadosDoCliente.Controls.Add(this.txtCidade);
            this.gpbDadosDoCliente.Controls.Add(this.lblCEP);
            this.gpbDadosDoCliente.Controls.Add(this.txtBairro);
            this.gpbDadosDoCliente.Controls.Add(this.lblBairro);
            this.gpbDadosDoCliente.Controls.Add(this.txtLogradouro);
            this.gpbDadosDoCliente.Controls.Add(this.lblLogradouro);
            this.gpbDadosDoCliente.Controls.Add(this.txtUF);
            this.gpbDadosDoCliente.Controls.Add(this.lblCidade);
            this.gpbDadosDoCliente.Controls.Add(this.label2);
            this.gpbDadosDoCliente.Location = new System.Drawing.Point(11, 55);
            this.gpbDadosDoCliente.Name = "gpbDadosDoCliente";
            this.gpbDadosDoCliente.Size = new System.Drawing.Size(764, 159);
            this.gpbDadosDoCliente.TabIndex = 94;
            this.gpbDadosDoCliente.TabStop = false;
            this.gpbDadosDoCliente.Text = "Dados do Cliente";
            // 
            // mtxCNAE
            // 
            this.mtxCNAE.Location = new System.Drawing.Point(8, 81);
            this.mtxCNAE.Mask = "0000-0/00";
            this.mtxCNAE.Name = "mtxCNAE";
            this.mtxCNAE.Size = new System.Drawing.Size(64, 20);
            this.mtxCNAE.TabIndex = 1;
            // 
            // txtIE
            // 
            this.txtIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIE.Location = new System.Drawing.Point(8, 125);
            this.txtIE.MaxLength = 20;
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(168, 20);
            this.txtIE.TabIndex = 2;
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIE.Location = new System.Drawing.Point(5, 106);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(170, 16);
            this.lblIE.TabIndex = 102;
            this.lblIE.Text = "Inscrição Estadual (I.E.)";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(661, 19);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(62, 16);
            this.lblContato.TabIndex = 101;
            this.lblContato.Text = "Contato";
            // 
            // mtxContato
            // 
            this.mtxContato.Location = new System.Drawing.Point(664, 38);
            this.mtxContato.Mask = "(99) 00000-0000";
            this.mtxContato.Name = "mtxContato";
            this.mtxContato.Size = new System.Drawing.Size(88, 20);
            this.mtxContato.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmail.Location = new System.Drawing.Point(446, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(443, 19);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 99;
            this.lblEmail.Text = "Email";
            // 
            // gpbAtividade
            // 
            this.gpbAtividade.Controls.Add(this.rdbVarejo);
            this.gpbAtividade.Controls.Add(this.rdbComercio);
            this.gpbAtividade.Controls.Add(this.rdbAtacado);
            this.gpbAtividade.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.gpbAtividade.Location = new System.Drawing.Point(123, 16);
            this.gpbAtividade.Name = "gpbAtividade";
            this.gpbAtividade.Size = new System.Drawing.Size(124, 91);
            this.gpbAtividade.TabIndex = 3;
            this.gpbAtividade.TabStop = false;
            this.gpbAtividade.Text = "Atividade";
            // 
            // rdbVarejo
            // 
            this.rdbVarejo.AutoSize = true;
            this.rdbVarejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbVarejo.Location = new System.Drawing.Point(7, 68);
            this.rdbVarejo.Name = "rdbVarejo";
            this.rdbVarejo.Size = new System.Drawing.Size(55, 17);
            this.rdbVarejo.TabIndex = 2;
            this.rdbVarejo.Text = "Varejo";
            this.rdbVarejo.UseVisualStyleBackColor = true;
            // 
            // rdbComercio
            // 
            this.rdbComercio.AutoSize = true;
            this.rdbComercio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbComercio.Location = new System.Drawing.Point(7, 45);
            this.rdbComercio.Name = "rdbComercio";
            this.rdbComercio.Size = new System.Drawing.Size(69, 17);
            this.rdbComercio.TabIndex = 1;
            this.rdbComercio.Text = "Comércio";
            this.rdbComercio.UseVisualStyleBackColor = true;
            // 
            // rdbAtacado
            // 
            this.rdbAtacado.AutoSize = true;
            this.rdbAtacado.Checked = true;
            this.rdbAtacado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbAtacado.Location = new System.Drawing.Point(7, 22);
            this.rdbAtacado.Name = "rdbAtacado";
            this.rdbAtacado.Size = new System.Drawing.Size(65, 17);
            this.rdbAtacado.TabIndex = 0;
            this.rdbAtacado.TabStop = true;
            this.rdbAtacado.Text = "Atacado";
            this.rdbAtacado.UseVisualStyleBackColor = true;
            // 
            // gpbRegime
            // 
            this.gpbRegime.Controls.Add(this.rdbReal);
            this.gpbRegime.Controls.Add(this.rdbPresumido);
            this.gpbRegime.Controls.Add(this.rdbSimples);
            this.gpbRegime.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.gpbRegime.Location = new System.Drawing.Point(253, 16);
            this.gpbRegime.Name = "gpbRegime";
            this.gpbRegime.Size = new System.Drawing.Size(124, 91);
            this.gpbRegime.TabIndex = 4;
            this.gpbRegime.TabStop = false;
            this.gpbRegime.Text = "Regime";
            // 
            // rdbReal
            // 
            this.rdbReal.AutoSize = true;
            this.rdbReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbReal.Location = new System.Drawing.Point(7, 68);
            this.rdbReal.Name = "rdbReal";
            this.rdbReal.Size = new System.Drawing.Size(77, 17);
            this.rdbReal.TabIndex = 2;
            this.rdbReal.Text = "Lucro Real";
            this.rdbReal.UseVisualStyleBackColor = true;
            // 
            // rdbPresumido
            // 
            this.rdbPresumido.AutoSize = true;
            this.rdbPresumido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbPresumido.Location = new System.Drawing.Point(7, 45);
            this.rdbPresumido.Name = "rdbPresumido";
            this.rdbPresumido.Size = new System.Drawing.Size(104, 17);
            this.rdbPresumido.TabIndex = 1;
            this.rdbPresumido.Text = "Lucro Presumido";
            this.rdbPresumido.UseVisualStyleBackColor = true;
            // 
            // rdbSimples
            // 
            this.rdbSimples.AutoSize = true;
            this.rdbSimples.Checked = true;
            this.rdbSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbSimples.Location = new System.Drawing.Point(7, 22);
            this.rdbSimples.Name = "rdbSimples";
            this.rdbSimples.Size = new System.Drawing.Size(106, 17);
            this.rdbSimples.TabIndex = 0;
            this.rdbSimples.TabStop = true;
            this.rdbSimples.Text = "Simples Nacional";
            this.rdbSimples.UseVisualStyleBackColor = true;
            // 
            // lblCNAE
            // 
            this.lblCNAE.AutoSize = true;
            this.lblCNAE.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNAE.Location = new System.Drawing.Point(5, 62);
            this.lblCNAE.Name = "lblCNAE";
            this.lblCNAE.Size = new System.Drawing.Size(47, 16);
            this.lblCNAE.TabIndex = 94;
            this.lblCNAE.Text = "CNAE";
            // 
            // mtxCNPJ
            // 
            this.mtxCNPJ.Location = new System.Drawing.Point(7, 35);
            this.mtxCNPJ.Mask = "00.000.000/0000-00";
            this.mtxCNPJ.Name = "mtxCNPJ";
            this.mtxCNPJ.Size = new System.Drawing.Size(110, 20);
            this.mtxCNPJ.TabIndex = 0;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(5, 16);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(53, 16);
            this.lblCNPJ.TabIndex = 90;
            this.lblCNPJ.Text = "CNPJ*";
            // 
            // mtxCEP
            // 
            this.mtxCEP.Location = new System.Drawing.Point(383, 38);
            this.mtxCEP.Mask = "00000-000";
            this.mtxCEP.Name = "mtxCEP";
            this.mtxCEP.Size = new System.Drawing.Size(57, 20);
            this.mtxCEP.TabIndex = 5;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCidade.Location = new System.Drawing.Point(606, 81);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(146, 20);
            this.txtCidade.TabIndex = 82;
            this.txtCidade.TabStop = false;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(380, 19);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(43, 16);
            this.lblCEP.TabIndex = 78;
            this.lblCEP.Text = "CEP*";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBairro.Location = new System.Drawing.Point(383, 81);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(185, 20);
            this.txtBairro.TabIndex = 86;
            this.txtBairro.TabStop = false;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(380, 62);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(52, 16);
            this.lblBairro.TabIndex = 85;
            this.lblBairro.Text = "Bairro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtLogradouro.Location = new System.Drawing.Point(383, 125);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(369, 20);
            this.txtLogradouro.TabIndex = 84;
            this.txtLogradouro.TabStop = false;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(380, 106);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(86, 16);
            this.lblLogradouro.TabIndex = 83;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUF.Location = new System.Drawing.Point(574, 81);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(26, 20);
            this.txtUF.TabIndex = 80;
            this.txtUF.TabStop = false;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(600, 62);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(53, 16);
            this.lblCidade.TabIndex = 81;
            this.lblCidade.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "UF";
            // 
            // lsbRegras
            // 
            this.lsbRegras.FormattingEnabled = true;
            this.lsbRegras.Location = new System.Drawing.Point(781, 90);
            this.lsbRegras.Name = "lsbRegras";
            this.lsbRegras.Size = new System.Drawing.Size(457, 121);
            this.lsbRegras.TabIndex = 95;
            // 
            // lblRegras
            // 
            this.lblRegras.AutoSize = true;
            this.lblRegras.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegras.Location = new System.Drawing.Point(778, 71);
            this.lblRegras.Name = "lblRegras";
            this.lblRegras.Size = new System.Drawing.Size(128, 16);
            this.lblRegras.TabIndex = 103;
            this.lblRegras.Text = "Regras Utilizadas";
            // 
            // btnTabCest
            // 
            this.btnTabCest.Location = new System.Drawing.Point(781, 217);
            this.btnTabCest.Name = "btnTabCest";
            this.btnTabCest.Size = new System.Drawing.Size(75, 36);
            this.btnTabCest.TabIndex = 104;
            this.btnTabCest.Text = "Tab. CEST";
            this.btnTabCest.UseVisualStyleBackColor = true;
            this.btnTabCest.Click += new System.EventHandler(this.btnTabCest_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(862, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 105;
            this.button2.Text = "Tab. TIPI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmEditarLayoutFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTabCest);
            this.Controls.Add(this.lblRegras);
            this.Controls.Add(this.lsbRegras);
            this.Controls.Add(this.gpbDadosDoCliente);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btnAbrirExcel);
            this.Controls.Add(this.btnEntradaManual);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblEnviarClassificacaoFiscal);
            this.MinimumSize = new System.Drawing.Size(803, 646);
            this.Name = "frmEditarLayoutFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klassifis Consultor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEditarLayoutFiscal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gpbDadosDoCliente.ResumeLayout(false);
            this.gpbDadosDoCliente.PerformLayout();
            this.gpbAtividade.ResumeLayout(false);
            this.gpbAtividade.PerformLayout();
            this.gpbRegime.ResumeLayout(false);
            this.gpbRegime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnAbrirExcel;
        private System.Windows.Forms.Button btnEntradaManual;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblEnviarClassificacaoFiscal;
        private System.Windows.Forms.GroupBox gpbDadosDoCliente;
        private System.Windows.Forms.MaskedTextBox mtxCNAE;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.MaskedTextBox mtxContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gpbAtividade;
        private System.Windows.Forms.RadioButton rdbVarejo;
        private System.Windows.Forms.RadioButton rdbComercio;
        private System.Windows.Forms.RadioButton rdbAtacado;
        private System.Windows.Forms.GroupBox gpbRegime;
        private System.Windows.Forms.RadioButton rdbReal;
        private System.Windows.Forms.RadioButton rdbPresumido;
        private System.Windows.Forms.RadioButton rdbSimples;
        private System.Windows.Forms.Label lblCNAE;
        private System.Windows.Forms.MaskedTextBox mtxCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.MaskedTextBox mtxCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbRegras;
        private System.Windows.Forms.Label lblRegras;
        private System.Windows.Forms.Button btnTabCest;
        private System.Windows.Forms.Button button2;
    }
}