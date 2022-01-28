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
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaixarClassFiscal
            // 
            this.btnBaixarClassFiscal.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnBaixarClassFiscal.Location = new System.Drawing.Point(12, 32);
            this.btnBaixarClassFiscal.Name = "btnBaixarClassFiscal";
            this.btnBaixarClassFiscal.Size = new System.Drawing.Size(245, 61);
            this.btnBaixarClassFiscal.TabIndex = 2;
            this.btnBaixarClassFiscal.Text = "Baixar Classificação Fiscal";
            this.btnBaixarClassFiscal.UseVisualStyleBackColor = true;
            this.btnBaixarClassFiscal.Click += new System.EventHandler(this.btnBaixarClassFiscal_Click);
            // 
            // frmListaDeClassificacoes
            // 
            this.frmListaDeClassificacoes.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.frmListaDeClassificacoes.Location = new System.Drawing.Point(12, 99);
            this.frmListaDeClassificacoes.Name = "frmListaDeClassificacoes";
            this.frmListaDeClassificacoes.Size = new System.Drawing.Size(245, 61);
            this.frmListaDeClassificacoes.TabIndex = 4;
            this.frmListaDeClassificacoes.Text = "Lista de Classificações";
            this.frmListaDeClassificacoes.UseVisualStyleBackColor = true;
            this.frmListaDeClassificacoes.Click += new System.EventHandler(this.frmListaDeClassificacoes_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnFechar.Location = new System.Drawing.Point(492, 156);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 36);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 203);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.frmListaDeClassificacoes);
            this.Controls.Add(this.btnBaixarClassFiscal);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klassifis Consultor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaixarClassFiscal;
        private System.Windows.Forms.Button frmListaDeClassificacoes;
        private System.Windows.Forms.Button btnFechar;
    }
}

