namespace Klassifis_Consultor.Telas
{
    partial class frmEditarLayoutFiscal_Manual
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
            this.gpbIPI = new System.Windows.Forms.GroupBox();
            this.txtIPI_CST = new System.Windows.Forms.TextBox();
            this.lblIPI_CST = new System.Windows.Forms.Label();
            this.lblIPI_Alq = new System.Windows.Forms.Label();
            this.txtIPI_CSOSN = new System.Windows.Forms.TextBox();
            this.txtIPI_Alq = new System.Windows.Forms.TextBox();
            this.lblIPI_CSOSN = new System.Windows.Forms.Label();
            this.gpbCOFINS = new System.Windows.Forms.GroupBox();
            this.txtCOFINS_CST = new System.Windows.Forms.TextBox();
            this.lblCOFINS_CST = new System.Windows.Forms.Label();
            this.lblCOFINS_Alq = new System.Windows.Forms.Label();
            this.txtCOFINS_CSOSN = new System.Windows.Forms.TextBox();
            this.txtCOFINS_Alq = new System.Windows.Forms.TextBox();
            this.lblCOFINS_CSOSN = new System.Windows.Forms.Label();
            this.gpbPIS = new System.Windows.Forms.GroupBox();
            this.txtPIS_CST = new System.Windows.Forms.TextBox();
            this.lblPIS_CST = new System.Windows.Forms.Label();
            this.lblPIS_Alq = new System.Windows.Forms.Label();
            this.txtPIS_CSOSN = new System.Windows.Forms.TextBox();
            this.txtPIS_Alq = new System.Windows.Forms.TextBox();
            this.lblPIS_CSOSN = new System.Windows.Forms.Label();
            this.gpbICMS = new System.Windows.Forms.GroupBox();
            this.txtICMS_CST = new System.Windows.Forms.TextBox();
            this.txtICMS_MVA = new System.Windows.Forms.TextBox();
            this.lblICMS_CST = new System.Windows.Forms.Label();
            this.lblICMS_MVA = new System.Windows.Forms.Label();
            this.lblICMS_Alq = new System.Windows.Forms.Label();
            this.txtICMS_CSOSN = new System.Windows.Forms.TextBox();
            this.txtICMS_Alq = new System.Windows.Forms.TextBox();
            this.lblICMS_CSOSN = new System.Windows.Forms.Label();
            this.gpbCodigosProduto = new System.Windows.Forms.GroupBox();
            this.txtCod_GTIN = new System.Windows.Forms.TextBox();
            this.txtCod_CEST = new System.Windows.Forms.TextBox();
            this.lblCod_GTIN = new System.Windows.Forms.Label();
            this.lblCod_CEST = new System.Windows.Forms.Label();
            this.lblCod_NCM = new System.Windows.Forms.Label();
            this.txtCod_NCM_Ex = new System.Windows.Forms.TextBox();
            this.txtCod_NCM = new System.Windows.Forms.TextBox();
            this.lblCod_NCM_Ex = new System.Windows.Forms.Label();
            this.txtDesc_Produto = new System.Windows.Forms.TextBox();
            this.lblDesc_Produto = new System.Windows.Forms.Label();
            this.lblEnviarClassificacaoFiscal = new System.Windows.Forms.Label();
            this.txtCod_Produto = new System.Windows.Forms.TextBox();
            this.lblCod_Produto = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gpbIPI.SuspendLayout();
            this.gpbCOFINS.SuspendLayout();
            this.gpbPIS.SuspendLayout();
            this.gpbICMS.SuspendLayout();
            this.gpbCodigosProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbIPI
            // 
            this.gpbIPI.Controls.Add(this.txtIPI_CST);
            this.gpbIPI.Controls.Add(this.lblIPI_CST);
            this.gpbIPI.Controls.Add(this.lblIPI_Alq);
            this.gpbIPI.Controls.Add(this.txtIPI_CSOSN);
            this.gpbIPI.Controls.Add(this.txtIPI_Alq);
            this.gpbIPI.Controls.Add(this.lblIPI_CSOSN);
            this.gpbIPI.Location = new System.Drawing.Point(650, 104);
            this.gpbIPI.Name = "gpbIPI";
            this.gpbIPI.Size = new System.Drawing.Size(301, 118);
            this.gpbIPI.TabIndex = 142;
            this.gpbIPI.TabStop = false;
            this.gpbIPI.Text = "IPI";
            // 
            // txtIPI_CST
            // 
            this.txtIPI_CST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIPI_CST.Location = new System.Drawing.Point(6, 37);
            this.txtIPI_CST.MaxLength = 14;
            this.txtIPI_CST.Name = "txtIPI_CST";
            this.txtIPI_CST.Size = new System.Drawing.Size(139, 20);
            this.txtIPI_CST.TabIndex = 0;
            this.txtIPI_CST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros);
            this.txtIPI_CST.Validating += new System.ComponentModel.CancelEventHandler(this.txtIPI_CST_Validating);
            // 
            // lblIPI_CST
            // 
            this.lblIPI_CST.AutoSize = true;
            this.lblIPI_CST.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPI_CST.Location = new System.Drawing.Point(3, 18);
            this.lblIPI_CST.Name = "lblIPI_CST";
            this.lblIPI_CST.Size = new System.Drawing.Size(35, 16);
            this.lblIPI_CST.TabIndex = 99;
            this.lblIPI_CST.Text = "CST";
            // 
            // lblIPI_Alq
            // 
            this.lblIPI_Alq.AutoSize = true;
            this.lblIPI_Alq.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPI_Alq.Location = new System.Drawing.Point(3, 62);
            this.lblIPI_Alq.Name = "lblIPI_Alq";
            this.lblIPI_Alq.Size = new System.Drawing.Size(66, 16);
            this.lblIPI_Alq.TabIndex = 101;
            this.lblIPI_Alq.Text = "Alíquota";
            // 
            // txtIPI_CSOSN
            // 
            this.txtIPI_CSOSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIPI_CSOSN.Location = new System.Drawing.Point(151, 37);
            this.txtIPI_CSOSN.MaxLength = 8;
            this.txtIPI_CSOSN.Name = "txtIPI_CSOSN";
            this.txtIPI_CSOSN.Size = new System.Drawing.Size(139, 20);
            this.txtIPI_CSOSN.TabIndex = 2;
            this.txtIPI_CSOSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Virgula);
            this.txtIPI_CSOSN.Validating += new System.ComponentModel.CancelEventHandler(this.txtIPI_CSOSN_Validating);
            // 
            // txtIPI_Alq
            // 
            this.txtIPI_Alq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIPI_Alq.Location = new System.Drawing.Point(6, 81);
            this.txtIPI_Alq.MaxLength = 8;
            this.txtIPI_Alq.Name = "txtIPI_Alq";
            this.txtIPI_Alq.Size = new System.Drawing.Size(139, 20);
            this.txtIPI_Alq.TabIndex = 1;
            this.txtIPI_Alq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Virgula);
            this.txtIPI_Alq.Validating += new System.ComponentModel.CancelEventHandler(this.txtIPI_Alq_Validating);
            // 
            // lblIPI_CSOSN
            // 
            this.lblIPI_CSOSN.AutoSize = true;
            this.lblIPI_CSOSN.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPI_CSOSN.Location = new System.Drawing.Point(148, 18);
            this.lblIPI_CSOSN.Name = "lblIPI_CSOSN";
            this.lblIPI_CSOSN.Size = new System.Drawing.Size(57, 16);
            this.lblIPI_CSOSN.TabIndex = 105;
            this.lblIPI_CSOSN.Text = "CSOSN";
            // 
            // gpbCOFINS
            // 
            this.gpbCOFINS.Controls.Add(this.txtCOFINS_CST);
            this.gpbCOFINS.Controls.Add(this.lblCOFINS_CST);
            this.gpbCOFINS.Controls.Add(this.lblCOFINS_Alq);
            this.gpbCOFINS.Controls.Add(this.txtCOFINS_CSOSN);
            this.gpbCOFINS.Controls.Add(this.txtCOFINS_Alq);
            this.gpbCOFINS.Controls.Add(this.lblCOFINS_CSOSN);
            this.gpbCOFINS.Location = new System.Drawing.Point(334, 228);
            this.gpbCOFINS.Name = "gpbCOFINS";
            this.gpbCOFINS.Size = new System.Drawing.Size(301, 118);
            this.gpbCOFINS.TabIndex = 141;
            this.gpbCOFINS.TabStop = false;
            this.gpbCOFINS.Text = "COFINS";
            // 
            // txtCOFINS_CST
            // 
            this.txtCOFINS_CST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCOFINS_CST.Location = new System.Drawing.Point(6, 37);
            this.txtCOFINS_CST.MaxLength = 14;
            this.txtCOFINS_CST.Name = "txtCOFINS_CST";
            this.txtCOFINS_CST.Size = new System.Drawing.Size(139, 20);
            this.txtCOFINS_CST.TabIndex = 0;
            this.txtCOFINS_CST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros);
            this.txtCOFINS_CST.Validating += new System.ComponentModel.CancelEventHandler(this.txtCOFINS_CST_Validating);
            // 
            // lblCOFINS_CST
            // 
            this.lblCOFINS_CST.AutoSize = true;
            this.lblCOFINS_CST.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOFINS_CST.Location = new System.Drawing.Point(3, 18);
            this.lblCOFINS_CST.Name = "lblCOFINS_CST";
            this.lblCOFINS_CST.Size = new System.Drawing.Size(35, 16);
            this.lblCOFINS_CST.TabIndex = 99;
            this.lblCOFINS_CST.Text = "CST";
            // 
            // lblCOFINS_Alq
            // 
            this.lblCOFINS_Alq.AutoSize = true;
            this.lblCOFINS_Alq.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOFINS_Alq.Location = new System.Drawing.Point(3, 62);
            this.lblCOFINS_Alq.Name = "lblCOFINS_Alq";
            this.lblCOFINS_Alq.Size = new System.Drawing.Size(66, 16);
            this.lblCOFINS_Alq.TabIndex = 101;
            this.lblCOFINS_Alq.Text = "Alíquota";
            // 
            // txtCOFINS_CSOSN
            // 
            this.txtCOFINS_CSOSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCOFINS_CSOSN.Location = new System.Drawing.Point(151, 37);
            this.txtCOFINS_CSOSN.MaxLength = 8;
            this.txtCOFINS_CSOSN.Name = "txtCOFINS_CSOSN";
            this.txtCOFINS_CSOSN.Size = new System.Drawing.Size(139, 20);
            this.txtCOFINS_CSOSN.TabIndex = 2;
            this.txtCOFINS_CSOSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Virgula);
            this.txtCOFINS_CSOSN.Validating += new System.ComponentModel.CancelEventHandler(this.txtCOFINS_CSOSN_Validating);
            // 
            // txtCOFINS_Alq
            // 
            this.txtCOFINS_Alq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCOFINS_Alq.Location = new System.Drawing.Point(6, 81);
            this.txtCOFINS_Alq.MaxLength = 8;
            this.txtCOFINS_Alq.Name = "txtCOFINS_Alq";
            this.txtCOFINS_Alq.Size = new System.Drawing.Size(139, 20);
            this.txtCOFINS_Alq.TabIndex = 1;
            this.txtCOFINS_Alq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Virgula);
            this.txtCOFINS_Alq.Validating += new System.ComponentModel.CancelEventHandler(this.txtCOFINS_Alq_Validating);
            // 
            // lblCOFINS_CSOSN
            // 
            this.lblCOFINS_CSOSN.AutoSize = true;
            this.lblCOFINS_CSOSN.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOFINS_CSOSN.Location = new System.Drawing.Point(148, 18);
            this.lblCOFINS_CSOSN.Name = "lblCOFINS_CSOSN";
            this.lblCOFINS_CSOSN.Size = new System.Drawing.Size(57, 16);
            this.lblCOFINS_CSOSN.TabIndex = 105;
            this.lblCOFINS_CSOSN.Text = "CSOSN";
            // 
            // gpbPIS
            // 
            this.gpbPIS.Controls.Add(this.txtPIS_CST);
            this.gpbPIS.Controls.Add(this.lblPIS_CST);
            this.gpbPIS.Controls.Add(this.lblPIS_Alq);
            this.gpbPIS.Controls.Add(this.txtPIS_CSOSN);
            this.gpbPIS.Controls.Add(this.txtPIS_Alq);
            this.gpbPIS.Controls.Add(this.lblPIS_CSOSN);
            this.gpbPIS.Location = new System.Drawing.Point(19, 228);
            this.gpbPIS.Name = "gpbPIS";
            this.gpbPIS.Size = new System.Drawing.Size(301, 118);
            this.gpbPIS.TabIndex = 140;
            this.gpbPIS.TabStop = false;
            this.gpbPIS.Text = "PIS";
            // 
            // txtPIS_CST
            // 
            this.txtPIS_CST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPIS_CST.Location = new System.Drawing.Point(6, 37);
            this.txtPIS_CST.MaxLength = 14;
            this.txtPIS_CST.Name = "txtPIS_CST";
            this.txtPIS_CST.Size = new System.Drawing.Size(139, 20);
            this.txtPIS_CST.TabIndex = 0;
            this.txtPIS_CST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros);
            this.txtPIS_CST.Validating += new System.ComponentModel.CancelEventHandler(this.txtPIS_CST_Validating);
            // 
            // lblPIS_CST
            // 
            this.lblPIS_CST.AutoSize = true;
            this.lblPIS_CST.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIS_CST.Location = new System.Drawing.Point(3, 18);
            this.lblPIS_CST.Name = "lblPIS_CST";
            this.lblPIS_CST.Size = new System.Drawing.Size(35, 16);
            this.lblPIS_CST.TabIndex = 99;
            this.lblPIS_CST.Text = "CST";
            // 
            // lblPIS_Alq
            // 
            this.lblPIS_Alq.AutoSize = true;
            this.lblPIS_Alq.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIS_Alq.Location = new System.Drawing.Point(3, 62);
            this.lblPIS_Alq.Name = "lblPIS_Alq";
            this.lblPIS_Alq.Size = new System.Drawing.Size(66, 16);
            this.lblPIS_Alq.TabIndex = 101;
            this.lblPIS_Alq.Text = "Alíquota";
            // 
            // txtPIS_CSOSN
            // 
            this.txtPIS_CSOSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPIS_CSOSN.Location = new System.Drawing.Point(151, 37);
            this.txtPIS_CSOSN.MaxLength = 8;
            this.txtPIS_CSOSN.Name = "txtPIS_CSOSN";
            this.txtPIS_CSOSN.Size = new System.Drawing.Size(139, 20);
            this.txtPIS_CSOSN.TabIndex = 2;
            this.txtPIS_CSOSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Virgula);
            this.txtPIS_CSOSN.Validating += new System.ComponentModel.CancelEventHandler(this.txtPIS_CSOSN_Validating);
            // 
            // txtPIS_Alq
            // 
            this.txtPIS_Alq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPIS_Alq.Location = new System.Drawing.Point(6, 81);
            this.txtPIS_Alq.MaxLength = 8;
            this.txtPIS_Alq.Name = "txtPIS_Alq";
            this.txtPIS_Alq.Size = new System.Drawing.Size(139, 20);
            this.txtPIS_Alq.TabIndex = 1;
            this.txtPIS_Alq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Virgula);
            this.txtPIS_Alq.Validating += new System.ComponentModel.CancelEventHandler(this.txtPIS_Alq_Validating);
            // 
            // lblPIS_CSOSN
            // 
            this.lblPIS_CSOSN.AutoSize = true;
            this.lblPIS_CSOSN.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIS_CSOSN.Location = new System.Drawing.Point(148, 18);
            this.lblPIS_CSOSN.Name = "lblPIS_CSOSN";
            this.lblPIS_CSOSN.Size = new System.Drawing.Size(57, 16);
            this.lblPIS_CSOSN.TabIndex = 105;
            this.lblPIS_CSOSN.Text = "CSOSN";
            // 
            // gpbICMS
            // 
            this.gpbICMS.Controls.Add(this.txtICMS_CST);
            this.gpbICMS.Controls.Add(this.txtICMS_MVA);
            this.gpbICMS.Controls.Add(this.lblICMS_CST);
            this.gpbICMS.Controls.Add(this.lblICMS_MVA);
            this.gpbICMS.Controls.Add(this.lblICMS_Alq);
            this.gpbICMS.Controls.Add(this.txtICMS_CSOSN);
            this.gpbICMS.Controls.Add(this.txtICMS_Alq);
            this.gpbICMS.Controls.Add(this.lblICMS_CSOSN);
            this.gpbICMS.Location = new System.Drawing.Point(334, 104);
            this.gpbICMS.Name = "gpbICMS";
            this.gpbICMS.Size = new System.Drawing.Size(301, 118);
            this.gpbICMS.TabIndex = 139;
            this.gpbICMS.TabStop = false;
            this.gpbICMS.Text = "ICMS";
            // 
            // txtICMS_CST
            // 
            this.txtICMS_CST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtICMS_CST.Location = new System.Drawing.Point(6, 37);
            this.txtICMS_CST.MaxLength = 14;
            this.txtICMS_CST.Name = "txtICMS_CST";
            this.txtICMS_CST.Size = new System.Drawing.Size(139, 20);
            this.txtICMS_CST.TabIndex = 0;
            this.txtICMS_CST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros);
            this.txtICMS_CST.Validating += new System.ComponentModel.CancelEventHandler(this.txtICMS_CST_Validating);
            // 
            // txtICMS_MVA
            // 
            this.txtICMS_MVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtICMS_MVA.Location = new System.Drawing.Point(151, 37);
            this.txtICMS_MVA.MaxLength = 7;
            this.txtICMS_MVA.Name = "txtICMS_MVA";
            this.txtICMS_MVA.Size = new System.Drawing.Size(139, 20);
            this.txtICMS_MVA.TabIndex = 2;
            this.txtICMS_MVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Virgula);
            this.txtICMS_MVA.Validating += new System.ComponentModel.CancelEventHandler(this.txtICMS_MVA_Validating);
            // 
            // lblICMS_CST
            // 
            this.lblICMS_CST.AutoSize = true;
            this.lblICMS_CST.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICMS_CST.Location = new System.Drawing.Point(3, 18);
            this.lblICMS_CST.Name = "lblICMS_CST";
            this.lblICMS_CST.Size = new System.Drawing.Size(35, 16);
            this.lblICMS_CST.TabIndex = 99;
            this.lblICMS_CST.Text = "CST";
            // 
            // lblICMS_MVA
            // 
            this.lblICMS_MVA.AutoSize = true;
            this.lblICMS_MVA.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICMS_MVA.Location = new System.Drawing.Point(148, 18);
            this.lblICMS_MVA.Name = "lblICMS_MVA";
            this.lblICMS_MVA.Size = new System.Drawing.Size(40, 16);
            this.lblICMS_MVA.TabIndex = 107;
            this.lblICMS_MVA.Text = "MVA";
            // 
            // lblICMS_Alq
            // 
            this.lblICMS_Alq.AutoSize = true;
            this.lblICMS_Alq.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICMS_Alq.Location = new System.Drawing.Point(3, 62);
            this.lblICMS_Alq.Name = "lblICMS_Alq";
            this.lblICMS_Alq.Size = new System.Drawing.Size(66, 16);
            this.lblICMS_Alq.TabIndex = 101;
            this.lblICMS_Alq.Text = "Alíquota";
            // 
            // txtICMS_CSOSN
            // 
            this.txtICMS_CSOSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtICMS_CSOSN.Location = new System.Drawing.Point(151, 81);
            this.txtICMS_CSOSN.MaxLength = 8;
            this.txtICMS_CSOSN.Name = "txtICMS_CSOSN";
            this.txtICMS_CSOSN.Size = new System.Drawing.Size(139, 20);
            this.txtICMS_CSOSN.TabIndex = 3;
            this.txtICMS_CSOSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Virgula);
            this.txtICMS_CSOSN.Validating += new System.ComponentModel.CancelEventHandler(this.txtICMS_CSOSN_Validating);
            // 
            // txtICMS_Alq
            // 
            this.txtICMS_Alq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtICMS_Alq.Location = new System.Drawing.Point(6, 81);
            this.txtICMS_Alq.MaxLength = 8;
            this.txtICMS_Alq.Name = "txtICMS_Alq";
            this.txtICMS_Alq.Size = new System.Drawing.Size(139, 20);
            this.txtICMS_Alq.TabIndex = 1;
            this.txtICMS_Alq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Virgula);
            this.txtICMS_Alq.Validating += new System.ComponentModel.CancelEventHandler(this.txtICMS_Alq_Validating);
            // 
            // lblICMS_CSOSN
            // 
            this.lblICMS_CSOSN.AutoSize = true;
            this.lblICMS_CSOSN.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICMS_CSOSN.Location = new System.Drawing.Point(148, 62);
            this.lblICMS_CSOSN.Name = "lblICMS_CSOSN";
            this.lblICMS_CSOSN.Size = new System.Drawing.Size(57, 16);
            this.lblICMS_CSOSN.TabIndex = 105;
            this.lblICMS_CSOSN.Text = "CSOSN";
            // 
            // gpbCodigosProduto
            // 
            this.gpbCodigosProduto.Controls.Add(this.txtCod_GTIN);
            this.gpbCodigosProduto.Controls.Add(this.txtCod_CEST);
            this.gpbCodigosProduto.Controls.Add(this.lblCod_GTIN);
            this.gpbCodigosProduto.Controls.Add(this.lblCod_CEST);
            this.gpbCodigosProduto.Controls.Add(this.lblCod_NCM);
            this.gpbCodigosProduto.Controls.Add(this.txtCod_NCM_Ex);
            this.gpbCodigosProduto.Controls.Add(this.txtCod_NCM);
            this.gpbCodigosProduto.Controls.Add(this.lblCod_NCM_Ex);
            this.gpbCodigosProduto.Location = new System.Drawing.Point(19, 104);
            this.gpbCodigosProduto.Name = "gpbCodigosProduto";
            this.gpbCodigosProduto.Size = new System.Drawing.Size(301, 118);
            this.gpbCodigosProduto.TabIndex = 138;
            this.gpbCodigosProduto.TabStop = false;
            this.gpbCodigosProduto.Text = "Códigos do Produto";
            // 
            // txtCod_GTIN
            // 
            this.txtCod_GTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCod_GTIN.Location = new System.Drawing.Point(6, 37);
            this.txtCod_GTIN.MaxLength = 14;
            this.txtCod_GTIN.Name = "txtCod_GTIN";
            this.txtCod_GTIN.Size = new System.Drawing.Size(139, 20);
            this.txtCod_GTIN.TabIndex = 0;
            this.txtCod_GTIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros);
            // 
            // txtCod_CEST
            // 
            this.txtCod_CEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCod_CEST.Location = new System.Drawing.Point(151, 37);
            this.txtCod_CEST.MaxLength = 7;
            this.txtCod_CEST.Name = "txtCod_CEST";
            this.txtCod_CEST.Size = new System.Drawing.Size(139, 20);
            this.txtCod_CEST.TabIndex = 1;
            this.txtCod_CEST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros);
            this.txtCod_CEST.Validating += new System.ComponentModel.CancelEventHandler(this.txtCod_CEST_Validating);
            // 
            // lblCod_GTIN
            // 
            this.lblCod_GTIN.AutoSize = true;
            this.lblCod_GTIN.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod_GTIN.Location = new System.Drawing.Point(3, 18);
            this.lblCod_GTIN.Name = "lblCod_GTIN";
            this.lblCod_GTIN.Size = new System.Drawing.Size(77, 16);
            this.lblCod_GTIN.TabIndex = 99;
            this.lblCod_GTIN.Text = "Cód. GTIN";
            // 
            // lblCod_CEST
            // 
            this.lblCod_CEST.AutoSize = true;
            this.lblCod_CEST.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod_CEST.Location = new System.Drawing.Point(148, 18);
            this.lblCod_CEST.Name = "lblCod_CEST";
            this.lblCod_CEST.Size = new System.Drawing.Size(78, 16);
            this.lblCod_CEST.TabIndex = 107;
            this.lblCod_CEST.Text = "Cód. CEST";
            // 
            // lblCod_NCM
            // 
            this.lblCod_NCM.AutoSize = true;
            this.lblCod_NCM.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod_NCM.Location = new System.Drawing.Point(3, 62);
            this.lblCod_NCM.Name = "lblCod_NCM";
            this.lblCod_NCM.Size = new System.Drawing.Size(75, 16);
            this.lblCod_NCM.TabIndex = 101;
            this.lblCod_NCM.Text = "Cód. NCM";
            // 
            // txtCod_NCM_Ex
            // 
            this.txtCod_NCM_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCod_NCM_Ex.Location = new System.Drawing.Point(151, 81);
            this.txtCod_NCM_Ex.MaxLength = 8;
            this.txtCod_NCM_Ex.Name = "txtCod_NCM_Ex";
            this.txtCod_NCM_Ex.Size = new System.Drawing.Size(139, 20);
            this.txtCod_NCM_Ex.TabIndex = 3;
            this.txtCod_NCM_Ex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Ponto);
            this.txtCod_NCM_Ex.Validating += new System.ComponentModel.CancelEventHandler(this.txtCod_NCM_Ex_Validating);
            // 
            // txtCod_NCM
            // 
            this.txtCod_NCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCod_NCM.Location = new System.Drawing.Point(6, 81);
            this.txtCod_NCM.MaxLength = 8;
            this.txtCod_NCM.Name = "txtCod_NCM";
            this.txtCod_NCM.Size = new System.Drawing.Size(139, 20);
            this.txtCod_NCM.TabIndex = 2;
            this.txtCod_NCM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceita_Numeros_Ponto);
            this.txtCod_NCM.Validating += new System.ComponentModel.CancelEventHandler(this.txtCod_NCM_Validating);
            // 
            // lblCod_NCM_Ex
            // 
            this.lblCod_NCM_Ex.AutoSize = true;
            this.lblCod_NCM_Ex.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod_NCM_Ex.Location = new System.Drawing.Point(148, 62);
            this.lblCod_NCM_Ex.Name = "lblCod_NCM_Ex";
            this.lblCod_NCM_Ex.Size = new System.Drawing.Size(95, 16);
            this.lblCod_NCM_Ex.TabIndex = 105;
            this.lblCod_NCM_Ex.Text = "Cód. NCM Ex";
            // 
            // txtDesc_Produto
            // 
            this.txtDesc_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDesc_Produto.Location = new System.Drawing.Point(120, 78);
            this.txtDesc_Produto.MaxLength = 100;
            this.txtDesc_Produto.Name = "txtDesc_Produto";
            this.txtDesc_Produto.Size = new System.Drawing.Size(515, 20);
            this.txtDesc_Produto.TabIndex = 133;
            // 
            // lblDesc_Produto
            // 
            this.lblDesc_Produto.AutoSize = true;
            this.lblDesc_Produto.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc_Produto.Location = new System.Drawing.Point(117, 59);
            this.lblDesc_Produto.Name = "lblDesc_Produto";
            this.lblDesc_Produto.Size = new System.Drawing.Size(103, 16);
            this.lblDesc_Produto.TabIndex = 137;
            this.lblDesc_Produto.Text = "Desc. Produto";
            // 
            // lblEnviarClassificacaoFiscal
            // 
            this.lblEnviarClassificacaoFiscal.AutoSize = true;
            this.lblEnviarClassificacaoFiscal.BackColor = System.Drawing.Color.DarkGray;
            this.lblEnviarClassificacaoFiscal.Font = new System.Drawing.Font("Century Schoolbook", 25F, System.Drawing.FontStyle.Bold);
            this.lblEnviarClassificacaoFiscal.Location = new System.Drawing.Point(12, 9);
            this.lblEnviarClassificacaoFiscal.Name = "lblEnviarClassificacaoFiscal";
            this.lblEnviarClassificacaoFiscal.Size = new System.Drawing.Size(288, 40);
            this.lblEnviarClassificacaoFiscal.TabIndex = 136;
            this.lblEnviarClassificacaoFiscal.Text = "Editar Produto";
            // 
            // txtCod_Produto
            // 
            this.txtCod_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCod_Produto.Location = new System.Drawing.Point(19, 78);
            this.txtCod_Produto.MaxLength = 14;
            this.txtCod_Produto.Name = "txtCod_Produto";
            this.txtCod_Produto.Size = new System.Drawing.Size(92, 20);
            this.txtCod_Produto.TabIndex = 132;
            // 
            // lblCod_Produto
            // 
            this.lblCod_Produto.AutoSize = true;
            this.lblCod_Produto.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod_Produto.Location = new System.Drawing.Point(16, 59);
            this.lblCod_Produto.Name = "lblCod_Produto";
            this.lblCod_Produto.Size = new System.Drawing.Size(97, 16);
            this.lblCod_Produto.TabIndex = 135;
            this.lblCod_Produto.Text = "Cód. Produto";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.DarkGray;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(860, 312);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 35);
            this.btnFechar.TabIndex = 134;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmEditarLayoutFiscal_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 359);
            this.Controls.Add(this.gpbIPI);
            this.Controls.Add(this.gpbCOFINS);
            this.Controls.Add(this.gpbPIS);
            this.Controls.Add(this.gpbICMS);
            this.Controls.Add(this.gpbCodigosProduto);
            this.Controls.Add(this.txtDesc_Produto);
            this.Controls.Add(this.lblDesc_Produto);
            this.Controls.Add(this.lblEnviarClassificacaoFiscal);
            this.Controls.Add(this.txtCod_Produto);
            this.Controls.Add(this.lblCod_Produto);
            this.Controls.Add(this.btnFechar);
            this.MinimumSize = new System.Drawing.Size(975, 398);
            this.Name = "frmEditarLayoutFiscal_Manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klassifis Consultor";
            this.Load += new System.EventHandler(this.frmEditarLayoutFiscal_Manual_Load);
            this.gpbIPI.ResumeLayout(false);
            this.gpbIPI.PerformLayout();
            this.gpbCOFINS.ResumeLayout(false);
            this.gpbCOFINS.PerformLayout();
            this.gpbPIS.ResumeLayout(false);
            this.gpbPIS.PerformLayout();
            this.gpbICMS.ResumeLayout(false);
            this.gpbICMS.PerformLayout();
            this.gpbCodigosProduto.ResumeLayout(false);
            this.gpbCodigosProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbIPI;
        public System.Windows.Forms.TextBox txtIPI_CST;
        private System.Windows.Forms.Label lblIPI_CST;
        private System.Windows.Forms.Label lblIPI_Alq;
        public System.Windows.Forms.TextBox txtIPI_CSOSN;
        public System.Windows.Forms.TextBox txtIPI_Alq;
        private System.Windows.Forms.Label lblIPI_CSOSN;
        private System.Windows.Forms.GroupBox gpbCOFINS;
        public System.Windows.Forms.TextBox txtCOFINS_CST;
        private System.Windows.Forms.Label lblCOFINS_CST;
        private System.Windows.Forms.Label lblCOFINS_Alq;
        public System.Windows.Forms.TextBox txtCOFINS_CSOSN;
        public System.Windows.Forms.TextBox txtCOFINS_Alq;
        private System.Windows.Forms.Label lblCOFINS_CSOSN;
        private System.Windows.Forms.GroupBox gpbPIS;
        public System.Windows.Forms.TextBox txtPIS_CST;
        private System.Windows.Forms.Label lblPIS_CST;
        private System.Windows.Forms.Label lblPIS_Alq;
        public System.Windows.Forms.TextBox txtPIS_CSOSN;
        public System.Windows.Forms.TextBox txtPIS_Alq;
        private System.Windows.Forms.Label lblPIS_CSOSN;
        private System.Windows.Forms.GroupBox gpbICMS;
        public System.Windows.Forms.TextBox txtICMS_CST;
        public System.Windows.Forms.TextBox txtICMS_MVA;
        private System.Windows.Forms.Label lblICMS_CST;
        private System.Windows.Forms.Label lblICMS_MVA;
        private System.Windows.Forms.Label lblICMS_Alq;
        public System.Windows.Forms.TextBox txtICMS_CSOSN;
        public System.Windows.Forms.TextBox txtICMS_Alq;
        private System.Windows.Forms.Label lblICMS_CSOSN;
        private System.Windows.Forms.GroupBox gpbCodigosProduto;
        public System.Windows.Forms.TextBox txtCod_GTIN;
        public System.Windows.Forms.TextBox txtCod_CEST;
        private System.Windows.Forms.Label lblCod_GTIN;
        private System.Windows.Forms.Label lblCod_CEST;
        private System.Windows.Forms.Label lblCod_NCM;
        public System.Windows.Forms.TextBox txtCod_NCM_Ex;
        public System.Windows.Forms.TextBox txtCod_NCM;
        private System.Windows.Forms.Label lblCod_NCM_Ex;
        public System.Windows.Forms.TextBox txtDesc_Produto;
        private System.Windows.Forms.Label lblDesc_Produto;
        private System.Windows.Forms.Label lblEnviarClassificacaoFiscal;
        public System.Windows.Forms.TextBox txtCod_Produto;
        private System.Windows.Forms.Label lblCod_Produto;
        private System.Windows.Forms.Button btnFechar;
    }
}