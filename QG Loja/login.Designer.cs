namespace projcarol
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Button();
            this.criar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 680);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.Black;
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.Color.White;
            this.usuario.Location = new System.Drawing.Point(820, 307);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(290, 19);
            this.usuario.TabIndex = 2;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // senha
            // 
            this.senha.BackColor = System.Drawing.Color.Black;
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.ForeColor = System.Drawing.Color.White;
            this.senha.Location = new System.Drawing.Point(820, 376);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(290, 19);
            this.senha.TabIndex = 3;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log.BackgroundImage")));
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.ForeColor = System.Drawing.Color.Transparent;
            this.log.Location = new System.Drawing.Point(811, 483);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(310, 36);
            this.log.TabIndex = 4;
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.button1_Click);
            // 
            // criar
            // 
            this.criar.BackColor = System.Drawing.Color.Transparent;
            this.criar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("criar.BackgroundImage")));
            this.criar.FlatAppearance.BorderSize = 0;
            this.criar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.criar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criar.Location = new System.Drawing.Point(961, 610);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(149, 19);
            this.criar.TabIndex = 5;
            this.criar.UseVisualStyleBackColor = false;
            this.criar.Click += new System.EventHandler(this.button2_Click);
            // 
            // minimizar
            // 
            this.minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizar.BackgroundImage")));
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Location = new System.Drawing.Point(1204, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(21, 23);
            this.minimizar.TabIndex = 6;
            this.minimizar.UseVisualStyleBackColor = true;
            this.minimizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // fechar
            // 
            this.fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechar.BackgroundImage")));
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Location = new System.Drawing.Point(1253, 0);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(21, 23);
            this.fechar.TabIndex = 7;
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.button4_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.criar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.log);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button fechar;
    }
}

