namespace QuizDhia
{
    partial class LoginForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Username = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.bSignUp = new System.Windows.Forms.Button();
            this.bild_Logo = new System.Windows.Forms.PictureBox();
            this.lBenutzername = new System.Windows.Forms.Label();
            this.lPasswort = new System.Windows.Forms.Label();
            this.lHinweis = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbViewPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bild_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AccessibleName = "";
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(176, 332);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(433, 36);
            this.Username.TabIndex = 0;
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.SystemColors.Control;
            this.bLogin.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.Color.Navy;
            this.bLogin.Location = new System.Drawing.Point(176, 501);
            this.bLogin.Margin = new System.Windows.Forms.Padding(4);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(124, 47);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "Anmelden";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bSignUp
            // 
            this.bSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.bSignUp.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSignUp.ForeColor = System.Drawing.Color.Navy;
            this.bSignUp.Location = new System.Drawing.Point(487, 501);
            this.bSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.bSignUp.Name = "bSignUp";
            this.bSignUp.Size = new System.Drawing.Size(124, 47);
            this.bSignUp.TabIndex = 3;
            this.bSignUp.Text = "Registrieren";
            this.bSignUp.UseVisualStyleBackColor = true;
            this.bSignUp.Click += new System.EventHandler(this.bSignUp_Click);
            // 
            // bild_Logo
            // 
            this.bild_Logo.BackColor = System.Drawing.Color.Transparent;
            this.bild_Logo.Image = ((System.Drawing.Image)(resources.GetObject("bild_Logo.Image")));
            this.bild_Logo.Location = new System.Drawing.Point(173, 65);
            this.bild_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.bild_Logo.Name = "bild_Logo";
            this.bild_Logo.Size = new System.Drawing.Size(460, 260);
            this.bild_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bild_Logo.TabIndex = 4;
            this.bild_Logo.TabStop = false;
            // 
            // lBenutzername
            // 
            this.lBenutzername.AutoSize = true;
            this.lBenutzername.BackColor = System.Drawing.Color.Transparent;
            this.lBenutzername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lBenutzername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBenutzername.ForeColor = System.Drawing.Color.White;
            this.lBenutzername.Location = new System.Drawing.Point(172, 308);
            this.lBenutzername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBenutzername.Name = "lBenutzername";
            this.lBenutzername.Size = new System.Drawing.Size(121, 23);
            this.lBenutzername.TabIndex = 5;
            this.lBenutzername.Text = "Benutzername";
            // 
            // lPasswort
            // 
            this.lPasswort.AutoSize = true;
            this.lPasswort.BackColor = System.Drawing.Color.Transparent;
            this.lPasswort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lPasswort.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasswort.ForeColor = System.Drawing.Color.White;
            this.lPasswort.Location = new System.Drawing.Point(172, 391);
            this.lPasswort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPasswort.Name = "lPasswort";
            this.lPasswort.Size = new System.Drawing.Size(78, 23);
            this.lPasswort.TabIndex = 6;
            this.lPasswort.Text = "Passwort";
            // 
            // lHinweis
            // 
            this.lHinweis.AutoSize = true;
            this.lHinweis.BackColor = System.Drawing.Color.Transparent;
            this.lHinweis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lHinweis.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHinweis.ForeColor = System.Drawing.Color.White;
            this.lHinweis.Location = new System.Drawing.Point(172, 455);
            this.lHinweis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHinweis.Name = "lHinweis";
            this.lHinweis.Size = new System.Drawing.Size(0, 23);
            this.lHinweis.TabIndex = 7;
            this.lHinweis.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(173, 416);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(436, 35);
            this.txtPassword.TabIndex = 8;
            // 
            // cbViewPassword
            // 
            this.cbViewPassword.AutoSize = true;
            this.cbViewPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbViewPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViewPassword.ForeColor = System.Drawing.Color.White;
            this.cbViewPassword.Location = new System.Drawing.Point(619, 428);
            this.cbViewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cbViewPassword.Name = "cbViewPassword";
            this.cbViewPassword.Size = new System.Drawing.Size(65, 24);
            this.cbViewPassword.TabIndex = 9;
            this.cbViewPassword.Text = "View";
            this.cbViewPassword.UseVisualStyleBackColor = false;
            this.cbViewPassword.CheckedChanged += new System.EventHandler(this.cbViewPasswort_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.Controls.Add(this.cbViewPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lHinweis);
            this.Controls.Add(this.lPasswort);
            this.Controls.Add(this.lBenutzername);
            this.Controls.Add(this.bild_Logo);
            this.Controls.Add(this.bSignUp);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "HappyA+";
            ((System.ComponentModel.ISupportInitialize)(this.bild_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bSignUp;
        private System.Windows.Forms.PictureBox bild_Logo;
        private System.Windows.Forms.Label lBenutzername;
        private System.Windows.Forms.Label lPasswort;
        private System.Windows.Forms.Label lHinweis;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbViewPassword;
    }
}

