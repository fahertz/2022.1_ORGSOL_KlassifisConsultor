﻿namespace Klassifis_Consultor.Telas
{
    partial class frmBaixarClassificacaoFiscal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFiltrarCNPJ = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblListaLayouts = new System.Windows.Forms.Label();
            this.lblBaixando = new System.Windows.Forms.Label();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBaixados = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.Button();
            this.mtxCNPJ = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrarCNPJ
            // 
            this.lblFiltrarCNPJ.AutoSize = true;
            this.lblFiltrarCNPJ.Location = new System.Drawing.Point(17, 81);
            this.lblFiltrarCNPJ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFiltrarCNPJ.Name = "lblFiltrarCNPJ";
            this.lblFiltrarCNPJ.Size = new System.Drawing.Size(78, 16);
            this.lblFiltrarCNPJ.TabIndex = 56;
            this.lblFiltrarCNPJ.Text = "Filtrar CNPJ";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(1005, 101);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(133, 34);
            this.btnCarregar.TabIndex = 54;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.DarkGray;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(977, 635);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(161, 53);
            this.btnFechar.TabIndex = 53;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownload.Location = new System.Drawing.Point(17, 635);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(133, 34);
            this.btnDownload.TabIndex = 52;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDados.Location = new System.Drawing.Point(17, 145);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1121, 480);
            this.dgvDados.TabIndex = 51;
            // 
            // lblListaLayouts
            // 
            this.lblListaLayouts.AutoSize = true;
            this.lblListaLayouts.BackColor = System.Drawing.Color.DarkGray;
            this.lblListaLayouts.Font = new System.Drawing.Font("Century Schoolbook", 25F, System.Drawing.FontStyle.Bold);
            this.lblListaLayouts.Location = new System.Drawing.Point(17, 15);
            this.lblListaLayouts.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblListaLayouts.Name = "lblListaLayouts";
            this.lblListaLayouts.Size = new System.Drawing.Size(312, 40);
            this.lblListaLayouts.TabIndex = 50;
            this.lblListaLayouts.Text = "Lista de Layouts";
            // 
            // lblBaixando
            // 
            this.lblBaixando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBaixando.AutoSize = true;
            this.lblBaixando.Location = new System.Drawing.Point(23, 677);
            this.lblBaixando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaixando.Name = "lblBaixando";
            this.lblBaixando.Size = new System.Drawing.Size(108, 16);
            this.lblBaixando.TabIndex = 57;
            this.lblBaixando.Text = "Baixando .... (0/0)";
            // 
            // lblCarregando
            // 
            this.lblCarregando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Location = new System.Drawing.Point(1001, 80);
            this.lblCarregando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(123, 16);
            this.lblCarregando.TabIndex = 58;
            this.lblCarregando.Text = "Carregando .... (0/0)";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(161, 635);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 34);
            this.btnLimpar.TabIndex = 59;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBaixados
            // 
            this.btnBaixados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBaixados.Location = new System.Drawing.Point(305, 635);
            this.btnBaixados.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBaixados.Name = "btnBaixados";
            this.btnBaixados.Size = new System.Drawing.Size(164, 34);
            this.btnBaixados.TabIndex = 60;
            this.btnBaixados.Text = "Layouts baixados";
            this.btnBaixados.UseVisualStyleBackColor = true;
            this.btnBaixados.Click += new System.EventHandler(this.btnBaixados_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(176, 101);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(84, 30);
            this.txtFiltrar.TabIndex = 61;
            this.txtFiltrar.Text = "Filtrar";
            this.txtFiltrar.UseVisualStyleBackColor = true;
            this.txtFiltrar.Click += new System.EventHandler(this.txtFiltrar_Click);
            // 
            // mtxCNPJ
            // 
            this.mtxCNPJ.Location = new System.Drawing.Point(21, 103);
            this.mtxCNPJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxCNPJ.Mask = "00.000.000/0000-00";
            this.mtxCNPJ.Name = "mtxCNPJ";
            this.mtxCNPJ.Size = new System.Drawing.Size(145, 22);
            this.mtxCNPJ.TabIndex = 62;
            this.mtxCNPJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxCNPJ_KeyDown);
            // 
            // frmBaixarClassificacaoFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 704);
            this.Controls.Add(this.mtxCNPJ);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.btnBaixados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.lblBaixando);
            this.Controls.Add(this.lblFiltrarCNPJ);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblListaLayouts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1172, 743);
            this.Name = "frmBaixarClassificacaoFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klassifis Consultor";
            this.Load += new System.EventHandler(this.frmBaixarClassificacaoFiscal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrarCNPJ;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblListaLayouts;
        private System.Windows.Forms.Label lblBaixando;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBaixados;
        private System.Windows.Forms.Button txtFiltrar;
        private System.Windows.Forms.MaskedTextBox mtxCNPJ;
    }
}