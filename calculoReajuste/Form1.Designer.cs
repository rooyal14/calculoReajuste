
namespace calculoReajuste
{
    partial class Form1
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercentReaj = new System.Windows.Forms.Label();
            this.lblTotalComReaj = new System.Windows.Forms.Label();
            this.lblTotalSemReaj = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(13, 13);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(503, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(522, 12);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(29, 23);
            this.btnBrowseFiles.TabIndex = 1;
            this.btnBrowseFiles.Text = "...";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.01708F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.82732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.96584F));
            this.tableLayoutPanel1.Controls.Add(this.lblPercentReaj, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComReaj, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSemReaj, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.38596F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.61404F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPercentReaj
            // 
            this.lblPercentReaj.AutoSize = true;
            this.lblPercentReaj.BackColor = System.Drawing.SystemColors.Control;
            this.lblPercentReaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPercentReaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPercentReaj.Location = new System.Drawing.Point(356, 21);
            this.lblPercentReaj.Name = "lblPercentReaj";
            this.lblPercentReaj.Size = new System.Drawing.Size(177, 18);
            this.lblPercentReaj.TabIndex = 7;
            this.lblPercentReaj.Text = "X,XX%";
            this.lblPercentReaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalComReaj
            // 
            this.lblTotalComReaj.AutoSize = true;
            this.lblTotalComReaj.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalComReaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalComReaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalComReaj.Location = new System.Drawing.Point(180, 21);
            this.lblTotalComReaj.Name = "lblTotalComReaj";
            this.lblTotalComReaj.Size = new System.Drawing.Size(170, 18);
            this.lblTotalComReaj.TabIndex = 6;
            this.lblTotalComReaj.Text = "R$ XX.XXX,XX";
            this.lblTotalComReaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalSemReaj
            // 
            this.lblTotalSemReaj.AutoSize = true;
            this.lblTotalSemReaj.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalSemReaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalSemReaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalSemReaj.Location = new System.Drawing.Point(3, 21);
            this.lblTotalSemReaj.Name = "lblTotalSemReaj";
            this.lblTotalSemReaj.Size = new System.Drawing.Size(171, 18);
            this.lblTotalSemReaj.TabIndex = 4;
            this.lblTotalSemReaj.Text = "R$ XX.XXX,XX";
            this.lblTotalSemReaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Percentual reajuste";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total com reajuste";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total sem reajuste";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(13, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 41);
            this.panel1.TabIndex = 2;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos de texto|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionários";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 238);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 384);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPercentReaj;
        private System.Windows.Forms.Label lblTotalComReaj;
        private System.Windows.Forms.Label lblTotalSemReaj;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

