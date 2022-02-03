
namespace BullsEye
{
    partial class GameBoardForm
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
            this.computersGuessPanel = new System.Windows.Forms.Panel();
            this.computerGuess1 = new System.Windows.Forms.Button();
            this.computerGuess2 = new System.Windows.Forms.Button();
            this.computerGuess3 = new System.Windows.Forms.Button();
            this.computerGuess4 = new System.Windows.Forms.Button();
            this.computersGuessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // computersGuessPanel
            // 
            this.computersGuessPanel.Controls.Add(this.computerGuess1);
            this.computersGuessPanel.Controls.Add(this.computerGuess2);
            this.computersGuessPanel.Controls.Add(this.computerGuess3);
            this.computersGuessPanel.Controls.Add(this.computerGuess4);
            this.computersGuessPanel.Enabled = false;
            this.computersGuessPanel.Location = new System.Drawing.Point(12, 12);
            this.computersGuessPanel.Name = "computersGuessPanel";
            this.computersGuessPanel.Size = new System.Drawing.Size(338, 90);
            this.computersGuessPanel.TabIndex = 1;
            // 
            // computerGuess1
            // 
            this.computerGuess1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.computerGuess1.Location = new System.Drawing.Point(3, 3);
            this.computerGuess1.Name = "computerGuess1";
            this.computerGuess1.Size = new System.Drawing.Size(75, 75);
            this.computerGuess1.TabIndex = 4;
            this.computerGuess1.UseVisualStyleBackColor = false;
            // 
            // computerGuess2
            // 
            this.computerGuess2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.computerGuess2.Location = new System.Drawing.Point(85, 3);
            this.computerGuess2.Name = "computerGuess2";
            this.computerGuess2.Size = new System.Drawing.Size(75, 75);
            this.computerGuess2.TabIndex = 3;
            this.computerGuess2.UseVisualStyleBackColor = false;
            // 
            // computerGuess3
            // 
            this.computerGuess3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.computerGuess3.Location = new System.Drawing.Point(167, 3);
            this.computerGuess3.Name = "computerGuess3";
            this.computerGuess3.Size = new System.Drawing.Size(75, 75);
            this.computerGuess3.TabIndex = 2;
            this.computerGuess3.UseVisualStyleBackColor = false;
            // 
            // computerGuess4
            // 
            this.computerGuess4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.computerGuess4.Location = new System.Drawing.Point(248, 3);
            this.computerGuess4.Name = "computerGuess4";
            this.computerGuess4.Size = new System.Drawing.Size(75, 75);
            this.computerGuess4.TabIndex = 1;
            this.computerGuess4.UseVisualStyleBackColor = false;
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 104);
            this.Controls.Add(this.computersGuessPanel);
            this.Name = "GameBoardForm";
            this.Text = "Bool Pgia";
            this.computersGuessPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel computersGuessPanel;
        private System.Windows.Forms.Button computerGuess2;
        private System.Windows.Forms.Button computerGuess4;
        private System.Windows.Forms.Button computerGuess3;
        private System.Windows.Forms.Button computerGuess1;
    }
}