namespace QuizDhia
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.txtCreatePWConfirm = new System.Windows.Forms.TextBox();
            this.lPasswortBestaetigen = new System.Windows.Forms.Label();
            this.txtCreatepassword = new System.Windows.Forms.TextBox();
            this.lPasswortEingabe = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lNachname = new System.Windows.Forms.Label();
            this.lBenutzerName = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lVorname = new System.Windows.Forms.Label();
            this.bKontoErstellen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbViewNewPassword = new System.Windows.Forms.CheckBox();
            this.lFehlMeldung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCreatePWConfirm
            // 
            this.txtCreatePWConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePWConfirm.Location = new System.Drawing.Point(63, 502);
            this.txtCreatePWConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreatePWConfirm.Multiline = true;
            this.txtCreatePWConfirm.Name = "txtCreatePWConfirm";
            this.txtCreatePWConfirm.PasswordChar = '*';
            this.txtCreatePWConfirm.Size = new System.Drawing.Size(255, 35);
            this.txtCreatePWConfirm.TabIndex = 12;
            // 
            // lPasswortBestaetigen
            // 
            this.lPasswortBestaetigen.AutoSize = true;
            this.lPasswortBestaetigen.BackColor = System.Drawing.Color.Transparent;
            this.lPasswortBestaetigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lPasswortBestaetigen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasswortBestaetigen.ForeColor = System.Drawing.Color.White;
            this.lPasswortBestaetigen.Location = new System.Drawing.Point(61, 478);
            this.lPasswortBestaetigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPasswortBestaetigen.Name = "lPasswortBestaetigen";
            this.lPasswortBestaetigen.Size = new System.Drawing.Size(163, 23);
            this.lPasswortBestaetigen.TabIndex = 11;
            this.lPasswortBestaetigen.Text = "Passwort bestätigen";
            // 
            // txtCreatepassword
            // 
            this.txtCreatepassword.AccessibleName = "";
            this.txtCreatepassword.BackColor = System.Drawing.Color.White;
            this.txtCreatepassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatepassword.Location = new System.Drawing.Point(65, 418);
            this.txtCreatepassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreatepassword.Multiline = true;
            this.txtCreatepassword.Name = "txtCreatepassword";
            this.txtCreatepassword.PasswordChar = '*';
            this.txtCreatepassword.Size = new System.Drawing.Size(252, 36);
            this.txtCreatepassword.TabIndex = 10;
            // 
            // lPasswortEingabe
            // 
            this.lPasswortEingabe.AutoSize = true;
            this.lPasswortEingabe.BackColor = System.Drawing.Color.Transparent;
            this.lPasswortEingabe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lPasswortEingabe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasswortEingabe.ForeColor = System.Drawing.Color.White;
            this.lPasswortEingabe.Location = new System.Drawing.Point(61, 394);
            this.lPasswortEingabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPasswortEingabe.Name = "lPasswortEingabe";
            this.lPasswortEingabe.Size = new System.Drawing.Size(78, 23);
            this.lPasswortEingabe.TabIndex = 13;
            this.lPasswortEingabe.Text = "Passwort";
            this.lPasswortEingabe.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(65, 341);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 35);
            this.txtUsername.TabIndex = 15;
            // 
            // txtLastname
            // 
            this.txtLastname.AccessibleName = "";
            this.txtLastname.BackColor = System.Drawing.Color.White;
            this.txtLastname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(65, 265);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(252, 36);
            this.txtLastname.TabIndex = 14;
            // 
            // lNachname
            // 
            this.lNachname.AutoSize = true;
            this.lNachname.BackColor = System.Drawing.Color.Transparent;
            this.lNachname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lNachname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNachname.ForeColor = System.Drawing.Color.White;
            this.lNachname.Location = new System.Drawing.Point(61, 240);
            this.lNachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNachname.Name = "lNachname";
            this.lNachname.Size = new System.Drawing.Size(93, 23);
            this.lNachname.TabIndex = 16;
            this.lNachname.Text = "Nachname";
            // 
            // lBenutzerName
            // 
            this.lBenutzerName.AutoSize = true;
            this.lBenutzerName.BackColor = System.Drawing.Color.Transparent;
            this.lBenutzerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lBenutzerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBenutzerName.ForeColor = System.Drawing.Color.White;
            this.lBenutzerName.Location = new System.Drawing.Point(61, 316);
            this.lBenutzerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBenutzerName.Name = "lBenutzerName";
            this.lBenutzerName.Size = new System.Drawing.Size(121, 23);
            this.lBenutzerName.TabIndex = 17;
            this.lBenutzerName.Text = "Benutzername";
            this.lBenutzerName.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(65, 185);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(252, 35);
            this.txtFirstname.TabIndex = 18;
            // 
            // lVorname
            // 
            this.lVorname.AutoSize = true;
            this.lVorname.BackColor = System.Drawing.Color.Transparent;
            this.lVorname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lVorname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVorname.ForeColor = System.Drawing.Color.White;
            this.lVorname.Location = new System.Drawing.Point(61, 160);
            this.lVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVorname.Name = "lVorname";
            this.lVorname.Size = new System.Drawing.Size(79, 23);
            this.lVorname.TabIndex = 19;
            this.lVorname.Text = "Vorname";
            // 
            // bKontoErstellen
            // 
            this.bKontoErstellen.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKontoErstellen.ForeColor = System.Drawing.Color.Navy;
            this.bKontoErstellen.Location = new System.Drawing.Point(168, 618);
            this.bKontoErstellen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bKontoErstellen.Name = "bKontoErstellen";
            this.bKontoErstellen.Size = new System.Drawing.Size(151, 31);
            this.bKontoErstellen.TabIndex = 20;
            this.bKontoErstellen.Text = "Konto erstellen";
            this.bKontoErstellen.UseVisualStyleBackColor = true;
            this.bKontoErstellen.Click += new System.EventHandler(this.bKontoErstellen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cbViewNewPassword
            // 
            this.cbViewNewPassword.AutoSize = true;
            this.cbViewNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbViewNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViewNewPassword.ForeColor = System.Drawing.Color.White;
            this.cbViewNewPassword.Location = new System.Drawing.Point(253, 463);
            this.cbViewNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbViewNewPassword.Name = "cbViewNewPassword";
            this.cbViewNewPassword.Size = new System.Drawing.Size(63, 21);
            this.cbViewNewPassword.TabIndex = 22;
            this.cbViewNewPassword.Text = "View";
            this.cbViewNewPassword.UseVisualStyleBackColor = false;
            this.cbViewNewPassword.CheckedChanged += new System.EventHandler(this.cbViewNewPassword_CheckedChanged);
            // 
            // lFehlMeldung
            // 
            this.lFehlMeldung.AutoSize = true;
            this.lFehlMeldung.BackColor = System.Drawing.Color.Transparent;
            this.lFehlMeldung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lFehlMeldung.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFehlMeldung.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lFehlMeldung.Location = new System.Drawing.Point(61, 550);
            this.lFehlMeldung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFehlMeldung.Name = "lFehlMeldung";
            this.lFehlMeldung.Size = new System.Drawing.Size(0, 19);
            this.lFehlMeldung.TabIndex = 24;
            this.lFehlMeldung.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(379, 690);
            this.Controls.Add(this.lFehlMeldung);
            this.Controls.Add(this.cbViewNewPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bKontoErstellen);
            this.Controls.Add(this.lVorname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lBenutzerName);
            this.Controls.Add(this.lNachname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lPasswortEingabe);
            this.Controls.Add(this.txtCreatePWConfirm);
            this.Controls.Add(this.lPasswortBestaetigen);
            this.Controls.Add(this.txtCreatepassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "HappyA+";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreatePWConfirm;
        private System.Windows.Forms.Label lPasswortBestaetigen;
        private System.Windows.Forms.TextBox txtCreatepassword;
        private System.Windows.Forms.Label lPasswortEingabe;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lNachname;
        private System.Windows.Forms.Label lBenutzerName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lVorname;
        private System.Windows.Forms.Button bKontoErstellen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbViewNewPassword;
        private System.Windows.Forms.Label lFehlMeldung;
    }
}