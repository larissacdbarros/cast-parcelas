namespace Aula40
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblescolha = new System.Windows.Forms.Label();
            this.txtValortotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInformaValor = new System.Windows.Forms.Label();
            this.lblPix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a Forma de Pagamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forma de pagamento escolhida:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblescolha
            // 
            this.lblescolha.AutoSize = true;
            this.lblescolha.Location = new System.Drawing.Point(316, 142);
            this.lblescolha.Name = "lblescolha";
            this.lblescolha.Size = new System.Drawing.Size(0, 20);
            this.lblescolha.TabIndex = 3;
            // 
            // txtValortotal
            // 
            this.txtValortotal.Location = new System.Drawing.Point(27, 46);
            this.txtValortotal.Name = "txtValortotal";
            this.txtValortotal.Size = new System.Drawing.Size(100, 26);
            this.txtValortotal.TabIndex = 7;
            this.txtValortotal.TextChanged += new System.EventHandler(this.txtValortotal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Informe o valor";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInformaValor
            // 
            this.lblInformaValor.AutoSize = true;
            this.lblInformaValor.Location = new System.Drawing.Point(195, 207);
            this.lblInformaValor.Name = "lblInformaValor";
            this.lblInformaValor.Size = new System.Drawing.Size(0, 20);
            this.lblInformaValor.TabIndex = 8;
            // 
            // lblPix
            // 
            this.lblPix.AutoSize = true;
            this.lblPix.Location = new System.Drawing.Point(195, 253);
            this.lblPix.Name = "lblPix";
            this.lblPix.Size = new System.Drawing.Size(0, 20);
            this.lblPix.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 328);
            this.Controls.Add(this.lblPix);
            this.Controls.Add(this.lblInformaValor);
            this.Controls.Add(this.txtValortotal);
            this.Controls.Add(this.lblescolha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblescolha;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtValortotal;
        private System.Windows.Forms.Label lblInformaValor;
        private System.Windows.Forms.Label lblPix;
    }
}

