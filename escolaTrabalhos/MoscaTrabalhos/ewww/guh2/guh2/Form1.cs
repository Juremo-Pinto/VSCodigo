using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guh2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arquivsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salvrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            saveFileDialog.Title = "Sarvar Arquio";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "arquio";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    writer.WriteLine(richTextBox1.Text);
                }

                MessageBox.Show("Arquio sarvo com sucexo!", "Sucexo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void abrrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "";
            openFileDialog.Title = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = openFileDialog.FileName;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
