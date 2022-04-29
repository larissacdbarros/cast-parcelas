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

namespace Aula40
{
    public partial class Form1 : Form
    {
        public double Valor { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //criar um arrayList
            ArrayList formaPgto = new ArrayList();
            formaPgto.Add(new FormaPgto(1, "Escolha uma opção"));
            formaPgto.Add(new FormaPgto(1, "Dinheiro"));
            formaPgto.Add(new FormaPgto(2, "Cartão"));
            formaPgto.Add(new FormaPgto(3, "Boleto"));
            formaPgto.Add(new FormaPgto(4, "Pix"));


            //vincular ao combobox
            comboBox1.DataSource = formaPgto;
            comboBox1.DisplayMember = "descrição";
            comboBox1.ValueMember = "descricao";

            
            //comboBoxParcelas.DisplayMember = IDataAdapter;


        }
        public class FormaPgto
        {
            public int ID { get; set; }
            public string Descricao { get; set; }

            public FormaPgto(int iD, string descricao)
            {
                this.ID = iD;
                this.Descricao = descricao;
            }

        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolha = comboBox1.SelectedIndex;
           
            switch (escolha)
            {
                case 0:
                    comboBox1.Text = "Escolha uma opção";
                    break;
                case 1:
                    lblescolha.Text = "Dinheiro"; 
                    lblInformaValor.Text = $"O valor total é: R${txtValortotal.Text}";
                    break;
                case 2:
                    lblescolha.Text = "Cartão";
                    TelaParcelas telaParcelas = new TelaParcelas();
                    telaParcelas.ShowDialog();
                    break;
                case 3:
                    lblescolha.Text = "Boleto";
                    lblInformaValor.Text = $"O valor total é: R${txtValortotal.Text}";
                    break;
                case 4:
                    lblescolha.Text = "Pix";
                    lblInformaValor.Text = $"O valor total é: R${txtValortotal.Text}";
                    lblPix.Text = "A chave PIX é: 896.652.698-98";
                    break;
                default:
                    lblescolha.Text = "";
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Valor = double.Parse(txtValortotal.Text);
            //int escolha = comboBox1.SelectedIndex;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValortotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
