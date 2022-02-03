
namespace BullsEye
{
    partial class NumberOfGuessesForm
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
            this.buttonNumberOfChances = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNumberOfChances
            // 
            this.buttonNumberOfChances.Location = new System.Drawing.Point(33, 28);
            this.buttonNumberOfChances.Name = "buttonNumberOfChances";
            this.buttonNumberOfChances.Size = new System.Drawing.Size(598, 46);
            this.buttonNumberOfChances.TabIndex = 0;
            this.buttonNumberOfChances.Text = "Number of chances: 4";
            this.buttonNumberOfChances.UseVisualStyleBackColor = true;
            this.buttonNumberOfChances.Click += new System.EventHandler(this.buttonNumberOfChances_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(481, 162);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(150, 46);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // NumberOfGuessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 231);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonNumberOfChances);
            this.Name = "NumberOfGuessesForm";
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNumberOfChances;
        private System.Windows.Forms.Button buttonStart;
    }
}