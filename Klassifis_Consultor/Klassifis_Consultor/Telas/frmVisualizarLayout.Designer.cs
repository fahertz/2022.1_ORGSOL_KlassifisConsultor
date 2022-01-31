namespace Klassifis_Consultor.Telas
{
    partial class frmVisualizarForms
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.chkExato = new System.Windows.Forms.CheckBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnAbrirExcel = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblLayoutFiscal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(560, 77);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 123;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // chkExato
            // 
            this.chkExato.AutoSize = true;
            this.chkExato.Location = new System.Drawing.Point(63, 61);
            this.chkExato.Name = "chkExato";
            this.chkExato.Size = new System.Drawing.Size(135, 17);
            this.chkExato.TabIndex = 122;
            this.chkExato.Text = "Correspondência exata";
            this.chkExato.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(9, 60);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(47, 16);
            this.lblFiltro.TabIndex = 121;
            this.lblFiltro.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 79);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(542, 20);
            this.txtFiltro.TabIndex = 120;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // btnAbrirExcel
            // 
            this.btnAbrirExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirExcel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAbrirExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbrirExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirExcel.Font = new System.Drawing.Font("Century Schoolbook", 7F, System.Drawing.FontStyle.Bold);
            this.btnAbrirExcel.ForeColor = System.Drawing.Color.White;
            this.btnAbrirExcel.Location = new System.Drawing.Point(135, 468);
            this.btnAbrirExcel.Name = "btnAbrirExcel";
            this.btnAbrirExcel.Size = new System.Drawing.Size(117, 24);
            this.btnAbrirExcel.TabIndex = 119;
            this.btnAbrirExcel.Text = "Abrir em Excel";
            this.btnAbrirExcel.UseVisualStyleBackColor = false;
            this.btnAbrirExcel.Click += new System.EventHandler(this.btnAbrirExcel_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportarExcel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Schoolbook", 7F, System.Drawing.FontStyle.Bold);
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(12, 468);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(117, 24);
            this.btnExportarExcel.TabIndex = 118;
            this.btnExportarExcel.Text = "Exportar";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.DarkGray;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(728, 468);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 35);
            this.btnFechar.TabIndex = 117;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            this.dgvProdutos.Location = new System.Drawing.Point(12, 105);
            this.dgvProdutos.MinimumSize = new System.Drawing.Size(807, 357);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(807, 357);
            this.dgvProdutos.TabIndex = 116;
            // 
            // lblLayoutFiscal
            // 
            this.lblLayoutFiscal.AutoSize = true;
            this.lblLayoutFiscal.BackColor = System.Drawing.Color.DarkGray;
            this.lblLayoutFiscal.Font = new System.Drawing.Font("Century Schoolbook", 25F, System.Drawing.FontStyle.Bold);
            this.lblLayoutFiscal.Location = new System.Drawing.Point(12, 11);
            this.lblLayoutFiscal.Name = "lblLayoutFiscal";
            this.lblLayoutFiscal.Size = new System.Drawing.Size(259, 40);
            this.lblLayoutFiscal.TabIndex = 115;
            this.lblLayoutFiscal.Text = "Layout Fiscal";
            // 
            // frmVisualizarForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 515);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.chkExato);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAbrirExcel);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblLayoutFiscal);
            this.MinimumSize = new System.Drawing.Size(847, 554);
            this.Name = "frmVisualizarForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klassifis Consultor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVisualizarForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox chkExato;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnAbrirExcel;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblLayoutFiscal;
    }
}