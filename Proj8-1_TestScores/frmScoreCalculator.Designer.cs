namespace Proj8_1_TestScores
{
    partial class frmScoreCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplaySortedScores = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMinMax = new System.Windows.Forms.Label();
            this.btnDisplayUnsortedScores = new System.Windows.Forms.Button();
            this.txtPreviousScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A.M. Dudda -- Project 8-1: Accumulate Test Score Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Score:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(90, 37);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(47, 20);
            this.txtScore.TabIndex = 2;
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(90, 88);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(47, 20);
            this.txtScoreTotal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score total:";
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(90, 114);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(47, 20);
            this.txtScoreCount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Score count:";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(90, 143);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(47, 20);
            this.txtAverage.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Average:";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(159, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add Score";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplaySortedScores
            // 
            this.btnDisplaySortedScores.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDisplaySortedScores.Location = new System.Drawing.Point(159, 65);
            this.btnDisplaySortedScores.Name = "btnDisplaySortedScores";
            this.btnDisplaySortedScores.Size = new System.Drawing.Size(113, 36);
            this.btnDisplaySortedScores.TabIndex = 10;
            this.btnDisplaySortedScores.Text = "Display &Sorted Scores";
            this.btnDisplaySortedScores.UseVisualStyleBackColor = true;
            this.btnDisplaySortedScores.Click += new System.EventHandler(this.btnDisplaySortedScores_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearScores.Location = new System.Drawing.Point(159, 150);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(112, 23);
            this.btnClearScores.TabIndex = 11;
            this.btnClearScores.Text = "&Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(159, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMinMax
            // 
            this.lblMinMax.AutoSize = true;
            this.lblMinMax.Location = new System.Drawing.Point(6, 188);
            this.lblMinMax.Name = "lblMinMax";
            this.lblMinMax.Size = new System.Drawing.Size(114, 13);
            this.lblMinMax.TabIndex = 13;
            this.lblMinMax.Text = "No scores entered yet.";
            // 
            // btnDisplayUnsortedScores
            // 
            this.btnDisplayUnsortedScores.Location = new System.Drawing.Point(159, 106);
            this.btnDisplayUnsortedScores.Name = "btnDisplayUnsortedScores";
            this.btnDisplayUnsortedScores.Size = new System.Drawing.Size(111, 39);
            this.btnDisplayUnsortedScores.TabIndex = 14;
            this.btnDisplayUnsortedScores.Text = "Display &Unsorted Scores";
            this.btnDisplayUnsortedScores.UseVisualStyleBackColor = true;
            this.btnDisplayUnsortedScores.Click += new System.EventHandler(this.btnDisplayUnsortedScores_Click);
            // 
            // txtPreviousScore
            // 
            this.txtPreviousScore.Location = new System.Drawing.Point(90, 62);
            this.txtPreviousScore.Name = "txtPreviousScore";
            this.txtPreviousScore.ReadOnly = true;
            this.txtPreviousScore.Size = new System.Drawing.Size(47, 20);
            this.txtPreviousScore.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Previous Score:";
            // 
            // frmScoreCalculator
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtPreviousScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDisplayUnsortedScores);
            this.Controls.Add(this.lblMinMax);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnDisplaySortedScores);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmScoreCalculator";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplaySortedScores;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMinMax;
        private System.Windows.Forms.Button btnDisplayUnsortedScores;
        private System.Windows.Forms.TextBox txtPreviousScore;
        private System.Windows.Forms.Label label6;
    }
}

