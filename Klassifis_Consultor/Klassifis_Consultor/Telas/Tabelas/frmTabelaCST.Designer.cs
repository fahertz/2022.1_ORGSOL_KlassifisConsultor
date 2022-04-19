namespace Klassifis_Consultor.Telas.Tabelas
{
    partial class frmTabelaCST
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
            this.lblTabelaCST = new System.Windows.Forms.Label();
            this.btnCST_PIS_COFINS = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCST_IPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTabelaCST
            // 
            this.lblTabelaCST.AutoSize = true;
            this.lblTabelaCST.BackColor = System.Drawing.Color.DarkGray;
            this.lblTabelaCST.Font = new System.Drawing.Font("Century Schoolbook", 25F, System.Drawing.FontStyle.Bold);
            this.lblTabelaCST.Location = new System.Drawing.Point(13, 9);
            this.lblTabelaCST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabelaCST.Name = "lblTabelaCST";
            this.lblTabelaCST.Size = new System.Drawing.Size(358, 50);
            this.lblTabelaCST.TabIndex = 85;
            this.lblTabelaCST.Text = "Tabelas de CST";
            // 
            // btnCST_PIS_COFINS
            // 
            this.btnCST_PIS_COFINS.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnCST_PIS_COFINS.Location = new System.Drawing.Point(13, 75);
            this.btnCST_PIS_COFINS.Margin = new System.Windows.Forms.Padding(4);
            this.btnCST_PIS_COFINS.Name = "btnCST_PIS_COFINS";
            this.btnCST_PIS_COFINS.Size = new System.Drawing.Size(358, 75);
            this.btnCST_PIS_COFINS.TabIndex = 86;
            this.btnCST_PIS_COFINS.Text = "Tabela CST de PIS e COFINS";
            this.btnCST_PIS_COFINS.UseVisualStyleBackColor = true;
            this.btnCST_PIS_COFINS.Click += new System.EventHandler(this.btnCST_PIS_COFINS_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.DarkGray;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(404, 454);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(121, 43);
            this.btnFechar.TabIndex = 94;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCST_IPI
            // 
            this.btnCST_IPI.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnCST_IPI.Location = new System.Drawing.Point(13, 158);
            this.btnCST_IPI.Margin = new System.Windows.Forms.Padding(4);
            this.btnCST_IPI.Name = "btnCST_IPI";
            this.btnCST_IPI.Size = new System.Drawing.Size(358, 75);
            this.btnCST_IPI.TabIndex = 95;
            this.btnCST_IPI.Text = "Tabela CST de IPI";
            this.btnCST_IPI.UseVisualStyleBackColor = true;
            this.btnCST_IPI.Click += new System.EventHandler(this.btnCST_IPI_Click);
            // 
            // frmTabelaCST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 510);
            this.Controls.Add(this.btnCST_IPI);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCST_PIS_COFINS);
            this.Controls.Add(this.lblTabelaCST);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(556, 557);
            this.MinimumSize = new System.Drawing.Size(556, 557);
            this.Name = "frmTabelaCST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klassifis Consultor";
            this.Load += new System.EventHandler(this.frmTabelaCST_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabelaCST;
        private System.Windows.Forms.Button btnCST_PIS_COFINS;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCST_IPI;
    }
}