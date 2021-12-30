
namespace NumberGuessingGame
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRngNum = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLivesRemaining = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpboxHint = new System.Windows.Forms.GroupBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.btnSubmitGuess = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpboxHint.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRngNum
            // 
            this.txtRngNum.Enabled = false;
            this.txtRngNum.Location = new System.Drawing.Point(126, 101);
            this.txtRngNum.Name = "txtRngNum";
            this.txtRngNum.Size = new System.Drawing.Size(100, 23);
            this.txtRngNum.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(187, 17);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "&Go!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generate a Random Number";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lives remaining:";
            // 
            // lblLivesRemaining
            // 
            this.lblLivesRemaining.AutoSize = true;
            this.lblLivesRemaining.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLivesRemaining.Location = new System.Drawing.Point(380, 21);
            this.lblLivesRemaining.Name = "lblLivesRemaining";
            this.lblLivesRemaining.Size = new System.Drawing.Size(14, 15);
            this.lblLivesRemaining.TabIndex = 4;
            this.lblLivesRemaining.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter your guess:";
            // 
            // grpboxHint
            // 
            this.grpboxHint.Controls.Add(this.lblHint);
            this.grpboxHint.Location = new System.Drawing.Point(23, 46);
            this.grpboxHint.Name = "grpboxHint";
            this.grpboxHint.Size = new System.Drawing.Size(370, 49);
            this.grpboxHint.TabIndex = 6;
            this.grpboxHint.TabStop = false;
            this.grpboxHint.Text = "Hint";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(11, 23);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 15);
            this.lblHint.TabIndex = 0;
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRandomNumber.ForeColor = System.Drawing.Color.Black;
            this.lblRandomNumber.Location = new System.Drawing.Point(452, 139);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(116, 61);
            this.lblRandomNumber.TabIndex = 7;
            this.lblRandomNumber.Text = "???";
            this.lblRandomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRandomNumber.Visible = false;
            // 
            // btnSubmitGuess
            // 
            this.btnSubmitGuess.Enabled = false;
            this.btnSubmitGuess.Location = new System.Drawing.Point(242, 101);
            this.btnSubmitGuess.Name = "btnSubmitGuess";
            this.btnSubmitGuess.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitGuess.TabIndex = 8;
            this.btnSubmitGuess.Text = "Guess";
            this.btnSubmitGuess.UseVisualStyleBackColor = true;
            this.btnSubmitGuess.Click += new System.EventHandler(this.btnSubmitGuess_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(26, 139);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 15);
            this.lblFeedback.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(463, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Answer";
            this.label4.Visible = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSubmitGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 336);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSubmitGuess);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.grpboxHint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLivesRemaining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtRngNum);
            this.MinimumSize = new System.Drawing.Size(620, 375);
            this.Name = "frmMain";
            this.Text = "Number Guessing Game!";
            this.grpboxHint.ResumeLayout(false);
            this.grpboxHint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRngNum;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLivesRemaining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpboxHint;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label label4;
    }
}

