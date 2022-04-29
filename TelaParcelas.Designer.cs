namespace Aula40
{
    partial class TelaParcelas
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxParcelas = new System.Windows.Forms.ComboBox();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValortest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selecione o parcelamento";
            // 
            // comboBoxParcelas
            // 
            this.comboBoxParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParcelas.FormattingEnabled = true;
            this.comboBoxParcelas.Location = new System.Drawing.Point(117, 72);
            this.comboBoxParcelas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxParcelas.Name = "comboBoxParcelas";
            this.comboBoxParcelas.Size = new System.Drawing.Size(247, 28);
            this.comboBoxParcelas.TabIndex = 11;
            this.comboBoxParcelas.SelectedIndexChanged += new System.EventHandler(this.comboBoxParcelas_SelectedIndexChanged);
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcela.Location = new System.Drawing.Point(278, 160);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(57, 20);
            this.lblValorParcela.TabIndex = 9;
            this.lblValorParcela.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor de cada parcela";
            // 
            // lblValortest
            // 
            this.lblValortest.AutoSize = true;
            this.lblValortest.Location = new System.Drawing.Point(209, 216);
            this.lblValortest.Name = "lblValortest";
            this.lblValortest.Size = new System.Drawing.Size(35, 13);
            this.lblValortest.TabIndex = 13;
            this.lblValortest.Text = "label1";
            // 
            // TelaParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 328);
            this.Controls.Add(this.lblValortest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxParcelas);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.label3);
            this.Name = "TelaParcelas";
            this.Text = "TelaParcelas";
            this.Load += new System.EventHandler(this.TelaParcelas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxParcelas;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValortest;
    }
}