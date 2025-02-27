namespace QuizDhia2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tfBenutzername = new System.Windows.Forms.TextBox();
            this.tfPasswort = new System.Windows.Forms.TextBox();
            this.bAnmelden = new System.Windows.Forms.Button();
            this.bRegestrieren = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tfBenutzername
            // 
            this.tfBenutzername.AccessibleName = "";
            this.tfBenutzername.BackColor = System.Drawing.Color.White;
            this.tfBenutzername.Location = new System.Drawing.Point(152, 325);
            this.tfBenutzername.Multiline = true;
            this.tfBenutzername.Name = "tfBenutzername";
            this.tfBenutzername.Size = new System.Drawing.Size(288, 30);
            this.tfBenutzername.TabIndex = 0;
            this.tfBenutzername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tfPasswort
            // 
            this.tfPasswort.Location = new System.Drawing.Point(152, 387);
            this.tfPasswort.Multiline = true;
            this.tfPasswort.Name = "tfPasswort";
            this.tfPasswort.Size = new System.Drawing.Size(288, 30);
            this.tfPasswort.TabIndex = 1;
            this.tfPasswort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bAnmelden
            // 
            this.bAnmelden.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnmelden.ForeColor = System.Drawing.Color.Navy;
            this.bAnmelden.Location = new System.Drawing.Point(357, 445);
            this.bAnmelden.Name = "bAnmelden";
            this.bAnmelden.Size = new System.Drawing.Size(83, 38);
            this.bAnmelden.TabIndex = 2;
            this.bAnmelden.Text = "Anmelden";
            this.bAnmelden.UseVisualStyleBackColor = true;
            this.bAnmelden.Click += new System.EventHandler(this.button1_Click);
            // 
            // bRegestrieren
            // 
            this.bRegestrieren.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegestrieren.ForeColor = System.Drawing.Color.Navy;
            this.bRegestrieren.Location = new System.Drawing.Point(152, 445);
            this.bRegestrieren.Name = "bRegestrieren";
            this.bRegestrieren.Size = new System.Drawing.Size(83, 38);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Benutzername";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passwort";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bRegestrieren);
            this.Controls.Add(this.bAnmelden);
            this.Controls.Add(this.tfPasswort);
            this.Controls.Add(this.tfBenutzername);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HappyA+";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tfBenutzername;
        private System.Windows.Forms.TextBox tfPasswort;
        private System.Windows.Forms.Button bAnmelden;
        private System.Windows.Forms.Button bRegestrieren;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

