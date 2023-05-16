namespace projcarol
{
    partial class conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conta));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.senha2 = new System.Windows.Forms.TextBox();
            this.criar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 680);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.Black;
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.ForeColor = System.Drawing.Color.White;
            this.usuario.Location = new System.Drawing.Point(830, 253);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(290, 13);
            this.usuario.TabIndex = 3;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Black;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(830, 323);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(290, 13);
            this.email.TabIndex = 4;
            // 
            // senha
            // 
            this.senha.BackColor = System.Drawing.Color.Black;
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.ForeColor = System.Drawing.Color.White;
            this.senha.Location = new System.Drawing.Point(830, 404);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(290, 13);
            this.senha.TabIndex = 5;
            // 
            // senha2
            // 
            this.senha2.BackColor = System.Drawing.Color.Black;
            this.senha2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha2.ForeColor = System.Drawing.Color.White;
            this.senha2.Location = new System.Drawing.Point(830, 482);
            this.senha2.Name = "senha2";
            this.senha2.PasswordChar = '*';
            this.senha2.Size = new System.Drawing.Size(290, 13);
            this.senha2.TabIndex = 6;
            // 
            // criar
            // 
            this.criar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("criar.BackgroundImage")));
            this.criar.FlatAppearance.BorderSize = 0;
            this.criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criar.Location = new System.Drawing.Point(830, 564);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(290, 33);
            this.criar.TabIndex = 7;
            this.criar.UseVisualStyleBackColor = true;
            this.criar.Click += new System.EventHandler(this.criar_Click);
            // 
            // voltar
            // 
            this.voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltar.BackgroundImage")));
            this.voltar.FlatAppearance.BorderSize = 0;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Location = new System.Drawing.Point(687, 37);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(82, 38);
            this.voltar.TabIndex = 8;
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // fechar
            // 
            this.fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechar.BackgroundImage")));
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Location = new System.Drawing.Point(1253, 0);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(21, 23);
            this.fechar.TabIndex = 9;
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // minimizar
            // 
            this.minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizar.BackgroundImage")));
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Location = new System.Drawing.Point(1206, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(21, 23);
            this.minimizar.TabIndex = 10;
            this.minimizar.UseVisualStyleBackColor = true;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.criar);
            this.Controls.Add(this.senha2);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.email);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "conta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox senha2;
        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button minimizar;
    }
}