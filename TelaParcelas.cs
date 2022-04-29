using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static Aula40.Form1;

namespace Aula40
{
    public partial class TelaParcelas : Form
    {
        public TelaParcelas()
        {
            InitializeComponent();
        }

        private void comboBoxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Form1 telaInicial = new Form1();
            
            
            for (int i = 0; i < comboBoxParcelas.Items.Count; i++)
            {
                double valorParcela;
                if (comboBoxParcelas.SelectedIndex >= 1)
                {
                    valorParcela = double.Parse(telaInicial.txtValortotal.Text) / (i + 1);
                    lblValorParcela.Text = $"R${valorParcela}";
                }
                else
                {
                    lblValorParcela.Text = "R$" + telaInicial.txtValortotal.Text;
                }
            }
        }

        private void TelaParcelas_Load(object sender, EventArgs e)
        {
            ArrayList parcelas = new ArrayList();
            parcelas.Add(1);
            parcelas.Add(2);
            parcelas.Add(3);
            parcelas.Add(4);
            parcelas.Add(5);
            parcelas.Add(6);
            parcelas.Add(7);
            parcelas.Add(8);
            parcelas.Add(9);
            parcelas.Add(10);
            parcelas.Add(11);
            parcelas.Add(12);
            comboBoxParcelas.DataSource = parcelas;
        }
    }
}
