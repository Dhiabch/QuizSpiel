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
            this.tfBenutzername = new System.Windows.Forms.TextBox();
            this.bAnmelden = new System.Windows.Forms.Button();
            this.bRegestrieren = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lBenutzername = new System.Windows.Forms.Label();
            this.lPasswort = new System.Windows.Forms.Label();
            this.lHinweis = new System.Windows.Forms.Label();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.cbViewPasswort = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tfBenutzername
            // 
            this.tfBenutzername.AccessibleName = "";
            this.tfBenutzername.BackColor = System.Drawing.Color.White;
            this.tfBenutzername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfBenutzername.Location = new System.Drawing.Point(114, 325);
            this.tfBenutzername.Multiline = true;
            this.tfBenutzername.Name = "tfBenutzername";
            this.tfBenutzername.Size = new System.Drawing.Size(326, 30);
            this.tfBenutzername.TabIndex = 0;
            this.tfBenutzername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bAnmelden
            // 
            this.bAnmelden.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnmelden.ForeColor = System.Drawing.Color.Navy;
            this.bAnmelden.Location = new System.Drawing.Point(114, 462);
            this.bAnmelden.Name = "bAnmelden";
            this.bAnmelden.Size = new System.Drawing.Size(93, 38);
            this.bAnmelden.TabIndex = 2;
            this.bAnmelden.Text = "Anmelden";
            this.bAnmelden.UseVisualStyleBackColor = true;
            this.bAnmelden.Click += new System.EventHandler(this.button1_Click);
            // 
            // bRegestrieren
            // 
            this.bRegestrieren.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegestrieren.ForeColor = System.Drawing.Color.Navy;
            this.bRegestrieren.Location = new System.Drawing.Point(347, 462);
            this.bRegestrieren.Name = "bRegestrieren";
            this.bRegestrieren.Size = new System.Drawing.Size(93, 38);
            this.bRegestrieren.TabIndex = 3;
            this.bRegestrieren.Text = "Registrieren";
            this.bRegestrieren.UseVisualStyleBackColor = true;
            this.bRegestrieren.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lBenutzername
            // 
            this.lBenutzername.AutoSize = true;
            this.lBenutzername.BackColor = System.Drawing.Color.Transparent;
            this.lBenutzername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lBenutzername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBenutzername.ForeColor = System.Drawing.Color.White;
            this.lBenutzername.Location = new System.Drawing.Point(111, 305);
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
            this.lPasswort.Location = new System.Drawing.Point(111, 373);
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
            this.lHinweis.Location = new System.Drawing.Point(253, 442);
            this.lHinweis.Name = "lHinweis";
            this.lHinweis.Size = new System.Drawing.Size(187, 17);
            this.lHinweis.TabIndex = 7;
            this.lHinweis.Text = "kein Konto? erstelllen Sie eins";
            this.lHinweis.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(112, 393);
            this.txtPasswort.Multiline = true;
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(328, 29);
            this.txtPasswort.TabIndex = 8;
            this.txtPasswort.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cbViewPasswort
            // 
            this.cbViewPasswort.AutoSize = true;
            this.cbViewPasswort.BackColor = System.Drawing.Color.Transparent;
            this.cbViewPasswort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViewPasswort.ForeColor = System.Drawing.Color.White;
            this.cbViewPasswort.Location = new System.Drawing.Point(446, 403);
            this.cbViewPasswort.Name = "cbViewPasswort";
            this.cbViewPasswort.Size = new System.Drawing.Size(51, 19);
            this.cbViewPasswort.TabIndex = 9;
            this.cbViewPasswort.Text = "View";
            this.cbViewPasswort.UseVisualStyleBackColor = false;
            this.cbViewPasswort.CheckedChanged += new System.EventHandler(this.cbViewPasswort_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.cbViewPasswort);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.lHinweis);
            this.Controls.Add(this.lPasswort);
            this.Controls.Add(this.lBenutzername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bRegestrieren);
            this.Controls.Add(this.bAnmelden);
            this.Controls.Add(this.tfBenutzername);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "HappyA+";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tfBenutzername;
        private System.Windows.Forms.Button bAnmelden;
        private System.Windows.Forms.Button bRegestrieren;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lBenutzername;
        private System.Windows.Forms.Label lPasswort;
        private System.Windows.Forms.Label lHinweis;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.CheckBox cbViewPasswort;
    }
}

