
namespace reajuste
{
    partial class frmReajusteFolhaPagamento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
            this.lblPr = new System.Windows.Forms.Label();
            this.lblTcr = new System.Windows.Forms.Label();
            this.lblTsr = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 54);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.23927F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.76073F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComReajuste, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTcr, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPercentualReajuste, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPr, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSemReajuste, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTsr, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 53);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.Location = new System.Drawing.Point(322, 25);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(139, 27);
            this.lblPercentualReajuste.TabIndex = 6;
            this.lblPercentualReajuste.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPr
            // 
            this.lblPr.BackColor = System.Drawing.Color.Yellow;
            this.lblPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPr.Location = new System.Drawing.Point(322, 0);
            this.lblPr.Name = "lblPr";
            this.lblPr.Size = new System.Drawing.Size(145, 16);
            this.lblPr.TabIndex = 3;
            this.lblPr.Text = "Percentual reajuste";
            this.lblPr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTcr
            // 
            this.lblTcr.BackColor = System.Drawing.Color.Yellow;
            this.lblTcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTcr.Location = new System.Drawing.Point(154, 0);
            this.lblTcr.Name = "lblTcr";
            this.lblTcr.Size = new System.Drawing.Size(162, 16);
            this.lblTcr.TabIndex = 2;
            this.lblTcr.Text = "Total com reajuste";
            this.lblTcr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTsr
            // 
            this.lblTsr.BackColor = System.Drawing.Color.Yellow;
            this.lblTsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTsr.Location = new System.Drawing.Point(3, 0);
            this.lblTsr.Name = "lblTsr";
            this.lblTsr.Size = new System.Drawing.Size(145, 17);
            this.lblTsr.TabIndex = 1;
            this.lblTsr.Text = "Total sem reajuste";
            this.lblTsr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTsr.Click += new System.EventHandler(this.lblTsr_Click);
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.Location = new System.Drawing.Point(154, 25);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(162, 27);
            this.lblTotalComReajuste.TabIndex = 5;
            this.lblTotalComReajuste.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(3, 25);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(145, 27);
            this.lblTotalSemReajuste.TabIndex = 4;
            this.lblTotalSemReajuste.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(12, 6);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(429, 20);
            this.txtArquivo.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.LightGray;
            this.btn.Location = new System.Drawing.Point(449, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(35, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "...";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 92);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(471, 251);
            this.dgvDados.TabIndex = 3;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = " *.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionários";
            // 
            // frmReajusteFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(494, 353);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.panel1);
            this.Name = "frmReajusteFolhaPagamento";
            this.Text = "Reajuste de Folha de Pagamento";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Label lblPr;
        private System.Windows.Forms.Label lblTcr;
        private System.Windows.Forms.Label lblTsr;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
    }
}

