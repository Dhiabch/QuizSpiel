namespace QuizDhia2
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitleWelc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bQuiz = new System.Windows.Forms.Button();
            this.lAnswer = new System.Windows.Forms.Label();
            this.tUserAnswer = new System.Windows.Forms.TextBox();
            this.lQuestionQuiz = new System.Windows.Forms.Label();
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
            // bQuiz
            // 
            this.bQuiz.BackColor = System.Drawing.SystemColors.Control;
            this.bQuiz.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuiz.ForeColor = System.Drawing.Color.Navy;
            this.bQuiz.Location = new System.Drawing.Point(610, 547);
            this.bQuiz.Margin = new System.Windows.Forms.Padding(4);
            this.bQuiz.Name = "bQuiz";
            this.bQuiz.Size = new System.Drawing.Size(113, 39);
            this.bQuiz.TabIndex = 6;
            this.bQuiz.Text = "Nächste";
            this.bQuiz.UseVisualStyleBackColor = false;
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAnswer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lAnswer.Location = new System.Drawing.Point(185, 351);
            this.lAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(224, 29);
            this.lAnswer.TabIndex = 7;
            this.lAnswer.Text = "Antwort eingeben:";
            // 
            // tUserAnswer
            // 
            this.tUserAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.tUserAnswer.Location = new System.Drawing.Point(190, 401);
            this.tUserAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.tUserAnswer.Multiline = true;
            this.tUserAnswer.Name = "tUserAnswer";
            this.tUserAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tUserAnswer.Size = new System.Drawing.Size(533, 108);
            this.tUserAnswer.TabIndex = 8;
            // 
            // lQuestionQuiz
            // 
            this.lQuestionQuiz.AutoSize = true;
            this.lQuestionQuiz.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lQuestionQuiz.ForeColor = System.Drawing.Color.Navy;
            this.lQuestionQuiz.Location = new System.Drawing.Point(306, 270);
            this.lQuestionQuiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQuestionQuiz.Name = "lQuestionQuiz";
            this.lQuestionQuiz.Size = new System.Drawing.Size(307, 63);
            this.lQuestionQuiz.TabIndex = 9;
            this.lQuestionQuiz.Text = "Frage eingeben";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(912, 814);
            this.Controls.Add(this.lQuestionQuiz);
            this.Controls.Add(this.tUserAnswer);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.bQuiz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lTitleWelc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuizForm";
            this.Text = "HappyA+";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitleWelc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bQuiz;
        private System.Windows.Forms.Label lAnswer;
        private System.Windows.Forms.TextBox tUserAnswer;
        private System.Windows.Forms.Label lQuestionQuiz;
    }
}