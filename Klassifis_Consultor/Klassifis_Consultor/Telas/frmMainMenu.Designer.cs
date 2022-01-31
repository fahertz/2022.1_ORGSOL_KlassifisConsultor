namespace Klassifis_Consultor
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBaixarClassFiscal = new System.Windows.Forms.Button();
            this.frmListaDeClassificacoes = new System.Windows.Forms.Button();
            this.btnLayoutsEnvados = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaixarClassFiscal
            // 
            this.btnBaixarClassFiscal.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnBaixarClassFiscal.Location = new System.Drawing.Point(13, 33);
            this.btnBaixarClassFiscal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixarClassFiscal.Name = "btnBaixarClassFiscal";
            this.btnBaixarClassFiscal.Size = new System.Drawing.Size(327, 75);
            this.btnBaixarClassFiscal.TabIndex = 2;
            this.btnBaixarClassFiscal.Text = "Baixar Classificação Fiscal";
            this.btnBaixarClassFiscal.UseVisualStyleBackColor = true;
            this.btnBaixarClassFiscal.Click += new System.EventHandler(this.btnBaixarClassFiscal_Click);
            // 
            // frmListaDeClassificacoes
            // 
            this.frmListaDeClassificacoes.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.frmListaDeClassificacoes.Location = new System.Drawing.Point(13, 116);
            this.frmListaDeClassificacoes.Margin = new System.Windows.Forms.Padding(4);
            this.frmListaDeClassificacoes.Name = "frmListaDeClassificacoes";
            this.frmListaDeClassificacoes.Size = new System.Drawing.Size(327, 75);
            this.frmListaDeClassificacoes.TabIndex = 4;
            this.frmListaDeClassificacoes.Text = "Classificações baixadas";
            this.frmListaDeClassificacoes.UseVisualStyleBackColor = true;
            this.frmListaDeClassificacoes.Click += new System.EventHandler(this.frmListaDeClassificacoes_Click);
            // 
            // btnLayoutsEnvados
            // 
            this.btnLayoutsEnvados.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnLayoutsEnvados.Location = new System.Drawing.Point(13, 198);
            this.btnLayoutsEnvados.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayoutsEnvados.Name = "btnLayoutsEnvados";
            this.btnLayoutsEnvados.Size = new System.Drawing.Size(327, 75);
            this.btnLayoutsEnvados.TabIndex = 6;
            this.btnLayoutsEnvados.Text = "Classificações Enviadas";
            this.btnLayoutsEnvados.UseVisualStyleBackColor = true;
            this.btnLayoutsEnvados.Click += new System.EventHandler(this.btnLayoutsEnvados_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnFechar.Location = new System.Drawing.Point(776, 259);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(94, 45);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 316);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLayoutsEnvados);
            this.Controls.Add(this.frmListaDeClassificacoes);
            this.Controls.Add(this.btnBaixarClassFiscal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(898, 355);
            this.MinimumSize = new System.Drawing.Size(898, 355);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klassifis Consultor";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaixarClassFiscal;
        private System.Windows.Forms.Button frmListaDeClassificacoes;
        private System.Windows.Forms.Button btnLayoutsEnvados;
        private System.Windows.Forms.Button btnFechar;
    }
}

