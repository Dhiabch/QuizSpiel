﻿namespace QuizDhia2
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
            this.gbCreateQuestion = new System.Windows.Forms.GroupBox();
            this.Question = new System.Windows.Forms.TextBox();
            this.SubmitQuestion = new System.Windows.Forms.Button();
            this.gbCreateQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Siemens AD Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(126, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hallo User";
            // 
            // gbCreateQuestion
            // 
            this.gbCreateQuestion.BackColor = System.Drawing.SystemColors.Desktop;
            this.gbCreateQuestion.Controls.Add(this.Question);
            this.gbCreateQuestion.Location = new System.Drawing.Point(132, 202);
            this.gbCreateQuestion.Name = "gbCreateQuestion";
            this.gbCreateQuestion.Size = new System.Drawing.Size(446, 210);
            this.gbCreateQuestion.TabIndex = 2;
            this.gbCreateQuestion.TabStop = false;
            this.gbCreateQuestion.Visible = false;
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(13, 17);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(418, 20);
            this.Question.TabIndex = 0;
            // 
            // SubmitQuestion
            // 
            this.SubmitQuestion.Location = new System.Drawing.Point(503, 418);
            this.SubmitQuestion.Name = "SubmitQuestion";
            this.SubmitQuestion.Size = new System.Drawing.Size(75, 23);
            this.SubmitQuestion.TabIndex = 3;
            this.SubmitQuestion.Text = "Submit";
            this.SubmitQuestion.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.SubmitQuestion);
            this.Controls.Add(this.gbCreateQuestion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "Form1";
            this.gbCreateQuestion.ResumeLayout(false);
            this.gbCreateQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCreateQuestion;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Button SubmitQuestion;
    }
}