namespace LabCSharp0._6
{
    partial class Form1
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
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(590, 164);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 38);
            this.up.TabIndex = 0;
            this.up.Text = "Up";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(590, 244);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 41);
            this.down.TabIndex = 1;
            this.down.Text = "Down";
            this.down.UseVisualStyleBackColor = true;
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Location = new System.Drawing.Point(12, 20);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(151, 20);
            this.welcomeText.TabIndex = 2;
            this.welcomeText.Text = "Welcome to the app";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Label welcomeText;
    }
}

