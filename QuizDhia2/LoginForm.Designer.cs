namespace QuizDhia2
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
            this.txtUserID = new System.Windows.Forms.TextBox();
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
            // txtUserID
            // 
            this.txtUserID.AccessibleName = "";
            this.txtUserID.BackColor = System.Drawing.Color.White;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(132, 270);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(326, 30);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bLogin
            // 
            this.bLogin.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.Color.Navy;
            this.bLogin.Location = new System.Drawing.Point(132, 407);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(93, 38);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "Anmelden";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSignUp
            // 
            this.bSignUp.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSignUp.ForeColor = System.Drawing.Color.Navy;
            this.bSignUp.Location = new System.Drawing.Point(365, 407);
            this.bSignUp.Name = "bSignUp";
            this.bSignUp.Size = new System.Drawing.Size(93, 38);
            this.bSignUp.TabIndex = 3;
            this.bSignUp.Text = "Registrieren";
            this.bSignUp.UseVisualStyleBackColor = true;
            this.bSignUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // bild_Logo
            // 
            this.bild_Logo.BackColor = System.Drawing.Color.Transparent;
            this.bild_Logo.Image = ((System.Drawing.Image)(resources.GetObject("bild_Logo.Image")));
            this.bild_Logo.Location = new System.Drawing.Point(130, 53);
            this.bild_Logo.Name = "bild_Logo";
            this.bild_Logo.Size = new System.Drawing.Size(345, 211);
            this.bild_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bild_Logo.TabIndex = 4;
            this.bild_Logo.TabStop = false;
            this.bild_Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lBenutzername
            // 
            this.lBenutzername.AutoSize = true;
            this.lBenutzername.BackColor = System.Drawing.Color.Transparent;
            this.lBenutzername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lBenutzername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBenutzername.ForeColor = System.Drawing.Color.White;
            this.lBenutzername.Location = new System.Drawing.Point(129, 250);
            this.lBenutzername.Name = "lBenutzername";
            this.lBenutzername.Size = new System.Drawing.Size(96, 17);
            this.lBenutzername.TabIndex = 5;
            this.lBenutzername.Text = "Benutzername";
            this.lBenutzername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lPasswort
            // 
            this.lPasswort.AutoSize = true;
            this.lPasswort.BackColor = System.Drawing.Color.Transparent;
            this.lPasswort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lPasswort.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasswort.ForeColor = System.Drawing.Color.White;
            this.lPasswort.Location = new System.Drawing.Point(129, 318);
            this.lPasswort.Name = "lPasswort";
            this.lPasswort.Size = new System.Drawing.Size(63, 17);
            this.lPasswort.TabIndex = 6;
            this.lPasswort.Text = "Passwort";
            this.lPasswort.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lHinweis
            // 
            this.lHinweis.AutoSize = true;
            this.lHinweis.BackColor = System.Drawing.Color.Transparent;
            this.lHinweis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lHinweis.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHinweis.ForeColor = System.Drawing.Color.White;
            this.lHinweis.Location = new System.Drawing.Point(271, 387);
            this.lHinweis.Name = "lHinweis";
            this.lHinweis.Size = new System.Drawing.Size(187, 17);
            this.lHinweis.TabIndex = 7;
            this.lHinweis.Text = "kein Konto? erstelllen Sie eins";
            this.lHinweis.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(130, 338);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(328, 29);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cbViewPassword
            // 
            this.cbViewPassword.AutoSize = true;
            this.cbViewPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbViewPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViewPassword.ForeColor = System.Drawing.Color.White;
            this.cbViewPassword.Location = new System.Drawing.Point(464, 348);
            this.cbViewPassword.Name = "cbViewPassword";
            this.cbViewPassword.Size = new System.Drawing.Size(51, 19);
            this.cbViewPassword.TabIndex = 9;
            this.cbViewPassword.Text = "View";
            this.cbViewPassword.UseVisualStyleBackColor = false;
            this.cbViewPassword.CheckedChanged += new System.EventHandler(this.cbViewPasswort_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.cbViewPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lHinweis);
            this.Controls.Add(this.lPasswort);
            this.Controls.Add(this.lBenutzername);
            this.Controls.Add(this.bild_Logo);
            this.Controls.Add(this.bSignUp);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.txtUserID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "HappyA+";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bild_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserID;
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

