using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void FuncLogin(object sender, EventArgs e)
        {
            errorText.Visible = false;
            if (Usuario.Text == "admin" && Senha.Text == "senha")
            {
                Form1 catalogoComida = new Form1();
                catalogoComida.Show();
                this.Hide();
            }
            else
            {
                esconderErro(sender, e);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            FuncLogin(sender, e);
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Control.ModifierKeys == Keys.Enter)
            {
                FuncLogin(sender, e);
            }
        }

        private void errorText_VisibleChanged(object sender, EventArgs e)
        {
            
        }
        private async Task esconderErro(object sender, EventArgs e)
        {
            errorText.Visible = true;
            await Task.Delay(1000);
            errorText.Visible = false;
        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Enter)
            {
                FuncLogin(sender, e);
            }
        }

        private void Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Enter)
            {
                FuncLogin(sender, e);
            }
        }
    }
}
