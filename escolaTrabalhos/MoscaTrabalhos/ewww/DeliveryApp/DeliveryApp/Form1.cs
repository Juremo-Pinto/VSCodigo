using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class Form1 : Form
    {
        double precoTotal = 00.00;
        public Form1()
        {
            InitializeComponent();
            label17.Text = precoTotal.ToString("N2");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Delivery ou Retirada?";
            button2.Show();
            button3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaCompras.Items.Add("Hamburguer");
            precoTotal += 19.99;
            label17.Text = precoTotal.ToString("N2");
        }

        private void Burrito_Click(object sender, EventArgs e)
        {
            listaCompras.Items.Add("Burrito");
            precoTotal += 17.90;
            label17.Text = precoTotal.ToString("N2");
        }

        private void Fricassê_Click(object sender, EventArgs e)
        {
            listaCompras.Items.Add("Fricassê");
            precoTotal += 24.90;
            label17.Text = precoTotal.ToString("N2");
        }

        private void Lasagna_Click(object sender, EventArgs e)
        {
            listaCompras.Items.Add("Lasagna");
            precoTotal += 24.90;
            label17.Text = precoTotal.ToString("N2");
        }

        private void Feijoada_Click(object sender, EventArgs e)
        {
            listaCompras.Items.Add("Feijoada");
            precoTotal += 24.90;
            label17.Text = precoTotal.ToString("N2");
        }

        private void BatataFrita_Click(object sender, EventArgs e)
        {
            listaCompras.Items.Add("Batata Frita");
            precoTotal += 15.00;
            label17.Text = precoTotal.ToString("N2");
        }

        private void Refrigerante_Click(object sender, EventArgs e)
        {
            {
                listaCompras.Items.Add("Refrigerante 2L");
                precoTotal += 15.00;
                label17.Text = precoTotal.ToString("N2");
            }
        }

        private void PurêBatata_Click(object sender, EventArgs e)
        {
            {
                listaCompras.Items.Add("Purê de Batata");
                precoTotal += 15.00;
                label17.Text = precoTotal.ToString("N2");
            }
        }

        private void Cebola_Click(object sender, EventArgs e)
        {
            {
                listaCompras.Items.Add("Anel de Cebola");
                precoTotal += 15.00;
                label17.Text = precoTotal.ToString("N2");
            }
        }

        private void Maionese_Click(object sender, EventArgs e)
        {
            {
                listaCompras.Items.Add("Maionese");
                precoTotal += 15.00;
                label17.Text = precoTotal.ToString("N2");
            }
        }

        private void Salada_Click(object sender, EventArgs e)
        {
            {
                listaCompras.Items.Add("Salada");
                precoTotal += 10.00;
                label17.Text = precoTotal.ToString("N2");
            }
        }

        private void listaCompras_DoubleClick(object sender, EventArgs e)
        {
            if (listaCompras.SelectedItem != null)
            {
                var nomeComida = listaCompras.SelectedItem.ToString();
                switch (nomeComida)
                {
                    case "Hamburguer":
                        precoTotal -= 19.99;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Burrito":
                        precoTotal -= 17.90;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Fricassê":
                        precoTotal -= 24.90;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Lasagna":
                        precoTotal -= 24.90;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Feijoada":
                        precoTotal -= 24.90;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Batata Frita":
                        precoTotal -= 15.00;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Refrigerante 2L":
                        precoTotal -= 15.00;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Purê de Batata":
                        precoTotal -= 15.00;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Anel de Cebola":
                        precoTotal -= 15.00;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Maionese":
                        precoTotal -= 15.00;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "Salada":
                        precoTotal -= 10.00;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "PF Bife":
                        precoTotal -= 19.99;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                    case "PF Parmegiana":
                        precoTotal -= 19.99;
                        label17.Text = precoTotal.ToString("N2");
                        break;
                }
                listaCompras.Items.Remove(listaCompras.SelectedItem);
            }
        }

        private void PFbife_Click(object sender, EventArgs e)
        {
            listaCompras.Items.Add("PF Bife");
            precoTotal += 19.99;
            label17.Text = precoTotal.ToString("N2");
        }

        private void PFparmegiana_Click(object sender, EventArgs e)
        {
            listaCompras.Items.Add("PF Parmegiana");
            precoTotal += 19.99;
            label17.Text = precoTotal.ToString("N2");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            precoTotal = 0;
            listaCompras.Items.Clear();
            label17.Text = precoTotal.ToString("N2");

            button2.Hide();
            button3.Hide();

            button1.Text = "Seu pedido será entregado em breve!";
            await Task.Delay(1000);
            button1.Text = "COMPRAR AGORA";
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            precoTotal = 0;
            listaCompras.Items.Clear();
            label17.Text = precoTotal.ToString("N2");

            button2.Hide();
            button3.Hide();

            button1.Text = "Seu pedido estará pronto em breve!";
            await Task.Delay(1000);
            button1.Text = "COMPRAR AGORA";
        }
    }
}
