namespace Klassifis_Consultor.Telas.Consultas
{
    partial class frmConsultarCatProduto
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblCategoriaDoProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.DarkGray;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(772, 446);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 35);
            this.btnFechar.TabIndex = 102;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDados.Location = new System.Drawing.Point(12, 110);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(851, 329);
            this.dgvDados.TabIndex = 101;
            this.dgvDados.DoubleClick += new System.EventHandler(this.dgvDados_DoubleClick);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(10, 62);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(99, 21);
            this.lblPesquisar.TabIndex = 100;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPesquisar.Location = new System.Drawing.Point(12, 81);
            this.txtPesquisar.MaxLength = 20;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(384, 23);
            this.txtPesquisar.TabIndex = 99;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // lblCategoriaDoProduto
            // 
            this.lblCategoriaDoProduto.AutoSize = true;
            this.lblCategoriaDoProduto.BackColor = System.Drawing.Color.DarkGray;
            this.lblCategoriaDoProduto.Font = new System.Drawing.Font("Century Schoolbook", 25F, System.Drawing.FontStyle.Bold);
            this.lblCategoriaDoProduto.Location = new System.Drawing.Point(12, 8);
            this.lblCategoriaDoProduto.Name = "lblCategoriaDoProduto";
            this.lblCategoriaDoProduto.Size = new System.Drawing.Size(498, 50);
            this.lblCategoriaDoProduto.TabIndex = 98;
            this.lblCategoriaDoProduto.Text = "Categoria do Produto";
            // 
            // frmConsultarCatProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 493);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblCategoriaDoProduto);
            this.MaximizeBox = false;
            this.Name = "frmConsultarCatProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klassifis Consultor";
            this.Load += new System.EventHandler(this.frmConsultarCatProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblCategoriaDoProduto;
    }
}