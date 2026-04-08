namespace guh2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sarve = new System.Windows.Forms.ToolStripMenuItem();
            this.abre = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivsToolStripMenuItem
            // 
            this.arquivsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sarve,
            this.abre});
            this.arquivsToolStripMenuItem.Name = "arquivsToolStripMenuItem";
            this.arquivsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.arquivsToolStripMenuItem.Text = "Arquivs";
            this.arquivsToolStripMenuItem.Click += new System.EventHandler(this.arquivsToolStripMenuItem_Click);
            // 
            // sarve
            // 
            this.sarve.Name = "sarve";
            this.sarve.Size = new System.Drawing.Size(180, 22);
            this.sarve.Text = "Salvr";
            this.sarve.Click += new System.EventHandler(this.salvrToolStripMenuItem_Click);
            // 
            // abre
            // 
            this.abre.Name = "abre";
            this.abre.Size = new System.Drawing.Size(180, 22);
            this.abre.Text = "Abrr";
            this.abre.Click += new System.EventHandler(this.abrrToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sarve;
        private System.Windows.Forms.ToolStripMenuItem abre;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

