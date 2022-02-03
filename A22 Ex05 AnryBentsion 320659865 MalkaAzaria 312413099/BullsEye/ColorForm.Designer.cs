
namespace BullsEye
{
    partial class ColorForm
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
            this.buttonFuchsia = new System.Windows.Forms.Button();
            this.buttonMaroon = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonLime = new System.Windows.Forms.Button();
            this.buttonAqua = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.panelcolors = new System.Windows.Forms.Panel();
            this.panelcolors.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFuchsia
            // 
            this.buttonFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonFuchsia.Location = new System.Drawing.Point(7, 11);
            this.buttonFuchsia.Name = "buttonFuchsia";
            this.buttonFuchsia.Size = new System.Drawing.Size(75, 75);
            this.buttonFuchsia.TabIndex = 0;
            this.buttonFuchsia.UseVisualStyleBackColor = false;
            this.buttonFuchsia.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonMaroon
            // 
            this.buttonMaroon.BackColor = System.Drawing.Color.Maroon;
            this.buttonMaroon.Location = new System.Drawing.Point(169, 92);
            this.buttonMaroon.Name = "buttonMaroon";
            this.buttonMaroon.Size = new System.Drawing.Size(75, 75);
            this.buttonMaroon.TabIndex = 1;
            this.buttonMaroon.UseVisualStyleBackColor = false;
            this.buttonMaroon.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(88, 92);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(75, 75);
            this.buttonYellow.TabIndex = 2;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(7, 92);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(75, 75);
            this.buttonBlue.TabIndex = 3;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(250, 92);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(75, 75);
            this.buttonWhite.TabIndex = 4;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonLime
            // 
            this.buttonLime.BackColor = System.Drawing.Color.Lime;
            this.buttonLime.Location = new System.Drawing.Point(169, 11);
            this.buttonLime.Name = "buttonLime";
            this.buttonLime.Size = new System.Drawing.Size(75, 75);
            this.buttonLime.TabIndex = 5;
            this.buttonLime.UseVisualStyleBackColor = false;
            this.buttonLime.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonAqua
            // 
            this.buttonAqua.BackColor = System.Drawing.Color.Aqua;
            this.buttonAqua.Location = new System.Drawing.Point(250, 11);
            this.buttonAqua.Name = "buttonAqua";
            this.buttonAqua.Size = new System.Drawing.Size(75, 75);
            this.buttonAqua.TabIndex = 6;
            this.buttonAqua.UseVisualStyleBackColor = false;
            this.buttonAqua.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(88, 11);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(75, 75);
            this.buttonRed.TabIndex = 7;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // panelcolors
            // 
            this.panelcolors.Controls.Add(this.buttonWhite);
            this.panelcolors.Controls.Add(this.buttonRed);
            this.panelcolors.Controls.Add(this.buttonFuchsia);
            this.panelcolors.Controls.Add(this.buttonAqua);
            this.panelcolors.Controls.Add(this.buttonMaroon);
            this.panelcolors.Controls.Add(this.buttonLime);
            this.panelcolors.Controls.Add(this.buttonYellow);
            this.panelcolors.Controls.Add(this.buttonBlue);
            this.panelcolors.Location = new System.Drawing.Point(84, 18);
            this.panelcolors.Name = "panelcolors";
            this.panelcolors.Size = new System.Drawing.Size(337, 183);
            this.panelcolors.TabIndex = 8;
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 219);
            this.Controls.Add(this.panelcolors);
            this.Name = "ColorForm";
            this.Text = "Pick A Color";
            this.panelcolors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFuchsia;
        private System.Windows.Forms.Button buttonMaroon;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonLime;
        private System.Windows.Forms.Button buttonAqua;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Panel panelcolors;
    }
}