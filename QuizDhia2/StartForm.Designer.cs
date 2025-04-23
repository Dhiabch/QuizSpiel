namespace QuizDhia2
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lKeywords = new System.Windows.Forms.Label();
            this.lQuestion = new System.Windows.Forms.Label();
            this.bSubmitQuestion = new System.Windows.Forms.Button();
            this.tKeywords = new System.Windows.Forms.TextBox();
            this.tQuestion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListQuestions = new System.Windows.Forms.ListBox();
            this.bStartQuiz = new System.Windows.Forms.Button();
            this.ldashboard = new System.Windows.Forms.Label();
            this.pFragen = new System.Windows.Forms.Panel();
            this.pFragen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Siemens AD Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(117, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Willkommen !";
            // 
            // lKeywords
            // 
            this.lKeywords.AutoSize = true;
            this.lKeywords.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKeywords.ForeColor = System.Drawing.Color.Navy;
            this.lKeywords.Location = new System.Drawing.Point(21, 99);
            this.lKeywords.Name = "lKeywords";
            this.lKeywords.Size = new System.Drawing.Size(122, 21);
            this.lKeywords.TabIndex = 3;
            this.lKeywords.Text = "Keywords eingeben";
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lQuestion.ForeColor = System.Drawing.Color.Navy;
            this.lQuestion.Location = new System.Drawing.Point(21, 23);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(99, 21);
            this.lQuestion.TabIndex = 2;
            this.lQuestion.Text = "Frage eingeben";
            // 
            // bSubmitQuestion
            // 
            this.bSubmitQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.bSubmitQuestion.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmitQuestion.ForeColor = System.Drawing.Color.Navy;
            this.bSubmitQuestion.Location = new System.Drawing.Point(342, 248);
            this.bSubmitQuestion.Name = "bSubmitQuestion";
            this.bSubmitQuestion.Size = new System.Drawing.Size(85, 32);
            this.bSubmitQuestion.TabIndex = 3;
            this.bSubmitQuestion.Text = "Submit";
            this.bSubmitQuestion.UseVisualStyleBackColor = false;
            // 
            // tKeywords
            // 
            this.tKeywords.BackColor = System.Drawing.SystemColors.Control;
            this.tKeywords.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tKeywords.Location = new System.Drawing.Point(24, 123);
            this.tKeywords.Multiline = true;
            this.tKeywords.Name = "tKeywords";
            this.tKeywords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tKeywords.Size = new System.Drawing.Size(403, 119);
            this.tKeywords.TabIndex = 1;
            // 
            // tQuestion
            // 
            this.tQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.tQuestion.Location = new System.Drawing.Point(24, 47);
            this.tQuestion.Multiline = true;
            this.tQuestion.Name = "tQuestion";
            this.tQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tQuestion.Size = new System.Drawing.Size(403, 38);
            this.tQuestion.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(132, 509);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ListQuestions
            // 
            this.ListQuestions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListQuestions.FormattingEnabled = true;
            this.ListQuestions.Location = new System.Drawing.Point(123, 461);
            this.ListQuestions.Name = "ListQuestions";
            this.ListQuestions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListQuestions.Size = new System.Drawing.Size(446, 132);
            this.ListQuestions.TabIndex = 5;
            // 
            // bStartQuiz
            // 
            this.bStartQuiz.BackColor = System.Drawing.SystemColors.Control;
            this.bStartQuiz.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStartQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bStartQuiz.Location = new System.Drawing.Point(484, 599);
            this.bStartQuiz.Name = "bStartQuiz";
            this.bStartQuiz.Size = new System.Drawing.Size(85, 32);
            this.bStartQuiz.TabIndex = 6;
            this.bStartQuiz.Text = "Start Quiz!";
            this.bStartQuiz.UseVisualStyleBackColor = false;
            // 
            // ldashboard
            // 
            this.ldashboard.AutoSize = true;
            this.ldashboard.BackColor = System.Drawing.Color.Transparent;
            this.ldashboard.Font = new System.Drawing.Font("Siemens AD Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldashboard.ForeColor = System.Drawing.Color.GhostWhite;
            this.ldashboard.Location = new System.Drawing.Point(269, 439);
            this.ldashboard.Name = "ldashboard";
            this.ldashboard.Size = new System.Drawing.Size(153, 19);
            this.ldashboard.TabIndex = 7;
            this.ldashboard.Text = "Themen Übersicht";
            // 
            // pFragen
            // 
            this.pFragen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pFragen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pFragen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFragen.Controls.Add(this.bSubmitQuestion);
            this.pFragen.Controls.Add(this.lKeywords);
            this.pFragen.Controls.Add(this.tQuestion);
            this.pFragen.Controls.Add(this.lQuestion);
            this.pFragen.Controls.Add(this.tKeywords);
            this.pFragen.Location = new System.Drawing.Point(123, 90);
            this.pFragen.Name = "pFragen";
            this.pFragen.Size = new System.Drawing.Size(446, 303);
            this.pFragen.TabIndex = 8;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.pFragen);
            this.Controls.Add(this.ldashboard);
            this.Controls.Add(this.bStartQuiz);
            this.Controls.Add(this.ListQuestions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "HappyA+";
            this.pFragen.ResumeLayout(false);
            this.pFragen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tQuestion;
        private System.Windows.Forms.Button bSubmitQuestion;
        private System.Windows.Forms.TextBox tKeywords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListQuestions;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Label lKeywords;
        private System.Windows.Forms.Button bStartQuiz;
        private System.Windows.Forms.Label ldashboard;
        private System.Windows.Forms.Panel pFragen;
    }
}