namespace QuizDhia
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
            this.lTitleWelc = new System.Windows.Forms.Label();
            this.gbCreateQuestion = new System.Windows.Forms.GroupBox();
            this.lKeywords = new System.Windows.Forms.Label();
            this.lQuestion = new System.Windows.Forms.Label();
            this.bSubmitQuestion = new System.Windows.Forms.Button();
            this.tCorrectAnswer = new System.Windows.Forms.TextBox();
            this.tQuestion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.bStartQuiz = new System.Windows.Forms.Button();
            this.ldashboard = new System.Windows.Forms.Label();
            this.gbCreateQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitleWelc
            // 
            this.lTitleWelc.AutoSize = true;
            this.lTitleWelc.BackColor = System.Drawing.Color.Transparent;
            this.lTitleWelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitleWelc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lTitleWelc.Location = new System.Drawing.Point(156, 65);
            this.lTitleWelc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitleWelc.Name = "lTitleWelc";
            this.lTitleWelc.Size = new System.Drawing.Size(0, 46);
            this.lTitleWelc.TabIndex = 0;
            // 
            // gbCreateQuestion
            // 
            this.gbCreateQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCreateQuestion.Controls.Add(this.lKeywords);
            this.gbCreateQuestion.Controls.Add(this.lQuestion);
            this.gbCreateQuestion.Controls.Add(this.bSubmitQuestion);
            this.gbCreateQuestion.Controls.Add(this.tCorrectAnswer);
            this.gbCreateQuestion.Controls.Add(this.tQuestion);
            this.gbCreateQuestion.Location = new System.Drawing.Point(164, 127);
            this.gbCreateQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.gbCreateQuestion.Name = "gbCreateQuestion";
            this.gbCreateQuestion.Padding = new System.Windows.Forms.Padding(4);
            this.gbCreateQuestion.Size = new System.Drawing.Size(595, 345);
            this.gbCreateQuestion.TabIndex = 2;
            this.gbCreateQuestion.TabStop = false;
            // 
            // lKeywords
            // 
            this.lKeywords.AutoSize = true;
            this.lKeywords.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKeywords.ForeColor = System.Drawing.Color.Navy;
            this.lKeywords.Location = new System.Drawing.Point(28, 97);
            this.lKeywords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lKeywords.Name = "lKeywords";
            this.lKeywords.Size = new System.Drawing.Size(153, 25);
            this.lKeywords.TabIndex = 3;
            this.lKeywords.Text = "Keywords eingeben";
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lQuestion.ForeColor = System.Drawing.Color.Navy;
            this.lQuestion.Location = new System.Drawing.Point(28, 17);
            this.lQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(125, 25);
            this.lQuestion.TabIndex = 2;
            this.lQuestion.Text = "Frage eingeben";
            // 
            // bSubmitQuestion
            // 
            this.bSubmitQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.bSubmitQuestion.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmitQuestion.ForeColor = System.Drawing.Color.Navy;
            this.bSubmitQuestion.Location = new System.Drawing.Point(457, 281);
            this.bSubmitQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.bSubmitQuestion.Name = "bSubmitQuestion";
            this.bSubmitQuestion.Size = new System.Drawing.Size(113, 39);
            this.bSubmitQuestion.TabIndex = 3;
            this.bSubmitQuestion.Text = "Submit";
            this.bSubmitQuestion.UseVisualStyleBackColor = false;
            this.bSubmitQuestion.Click += new System.EventHandler(this.bSubmitQuestion_Click);
            // 
            // tCorrectAnswer
            // 
            this.tCorrectAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.tCorrectAnswer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tCorrectAnswer.Location = new System.Drawing.Point(33, 127);
            this.tCorrectAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.tCorrectAnswer.Multiline = true;
            this.tCorrectAnswer.Name = "tCorrectAnswer";
            this.tCorrectAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tCorrectAnswer.Size = new System.Drawing.Size(536, 146);
            this.tCorrectAnswer.TabIndex = 1;
            // 
            // tQuestion
            // 
            this.tQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.tQuestion.Location = new System.Drawing.Point(33, 47);
            this.tQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.tQuestion.Multiline = true;
            this.tQuestion.Name = "tQuestion";
            this.tQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tQuestion.Size = new System.Drawing.Size(533, 46);
            this.tQuestion.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(176, 626);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbQuestions
            // 
            this.lbQuestions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.ItemHeight = 16;
            this.lbQuestions.Location = new System.Drawing.Point(164, 539);
            this.lbQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbQuestions.Size = new System.Drawing.Size(593, 164);
            this.lbQuestions.TabIndex = 5;
            // 
            // bStartQuiz
            // 
            this.bStartQuiz.BackColor = System.Drawing.SystemColors.Control;
            this.bStartQuiz.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStartQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bStartQuiz.Location = new System.Drawing.Point(621, 724);
            this.bStartQuiz.Margin = new System.Windows.Forms.Padding(4);
            this.bStartQuiz.Name = "bStartQuiz";
            this.bStartQuiz.Size = new System.Drawing.Size(113, 39);
            this.bStartQuiz.TabIndex = 6;
            this.bStartQuiz.Text = "Start Quiz!";
            this.bStartQuiz.UseVisualStyleBackColor = false;
            // 
            // ldashboard
            // 
            this.ldashboard.AutoSize = true;
            this.ldashboard.BackColor = System.Drawing.Color.Transparent;
            this.ldashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldashboard.ForeColor = System.Drawing.Color.GhostWhite;
            this.ldashboard.Location = new System.Drawing.Point(159, 510);
            this.ldashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldashboard.Name = "ldashboard";
            this.ldashboard.Size = new System.Drawing.Size(227, 29);
            this.ldashboard.TabIndex = 7;
            this.ldashboard.Text = "Themen Übersicht";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(912, 814);
            this.Controls.Add(this.ldashboard);
            this.Controls.Add(this.bStartQuiz);
            this.Controls.Add(this.lbQuestions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCreateQuestion);
            this.Controls.Add(this.lTitleWelc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartForm";
            this.Text = "HappyA+";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.gbCreateQuestion.ResumeLayout(false);
            this.gbCreateQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitleWelc;
        private System.Windows.Forms.GroupBox gbCreateQuestion;
        private System.Windows.Forms.TextBox tQuestion;
        private System.Windows.Forms.Button bSubmitQuestion;
        private System.Windows.Forms.TextBox tCorrectAnswer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbQuestions;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Label lKeywords;
        private System.Windows.Forms.Button bStartQuiz;
        private System.Windows.Forms.Label ldashboard;
    }
}