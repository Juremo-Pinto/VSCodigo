namespace DeliveryApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Confirmar = new System.Windows.Forms.Button();
            this.Senha = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PFbife = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PFbife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(319, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.Color.White;
            this.Confirmar.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.Location = new System.Drawing.Point(228, 247);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(268, 72);
            this.Confirmar.TabIndex = 1;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(228, 200);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(268, 20);
            this.Senha.TabIndex = 3;
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            this.Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Senha_KeyPress);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(228, 146);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(268, 20);
            this.Usuario.TabIndex = 4;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            this.Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Usuario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // PFbife
            // 
            this.PFbife.BackColor = System.Drawing.Color.Transparent;
            this.PFbife.Image = global::DeliveryApp.Properties.Resources.paltyous;
            this.PFbife.Location = new System.Drawing.Point(218, 57);
            this.PFbife.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PFbife.Name = "PFbife";
            this.PFbife.Size = new System.Drawing.Size(113, 109);
            this.PFbife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PFbife.TabIndex = 47;
            this.PFbife.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DeliveryApp.Properties.Resources.paltyous;
            this.pictureBox1.Location = new System.Drawing.Point(397, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.BackColor = System.Drawing.Color.Transparent;
            this.errorText.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.Crimson;
            this.errorText.Location = new System.Drawing.Point(101, 322);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(527, 28);
            this.errorText.TabIndex = 49;
            this.errorText.Text = "Senha ou usuário incorretos! Tente novamente!";
            this.errorText.Visible = false;
            this.errorText.VisibleChanged += new System.EventHandler(this.errorText_VisibleChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeliveryApp.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PFbife);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PFbife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PFbife;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errorText;
    }
}