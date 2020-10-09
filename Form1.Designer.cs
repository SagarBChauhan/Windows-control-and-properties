namespace Practical3
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
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblS3 = new System.Windows.Forms.Label();
            this.LblS2 = new System.Windows.Forms.Label();
            this.LblS1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnQuit
            // 
            this.BtnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuit.Location = new System.Drawing.Point(414, 380);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(81, 30);
            this.BtnQuit.TabIndex = 5;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(274, 380);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(82, 30);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Spin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblS3
            // 
            this.LblS3.AutoSize = true;
            this.LblS3.BackColor = System.Drawing.Color.DarkGray;
            this.LblS3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblS3.Location = new System.Drawing.Point(426, 189);
            this.LblS3.Name = "LblS3";
            this.LblS3.Size = new System.Drawing.Size(38, 41);
            this.LblS3.TabIndex = 3;
            this.LblS3.Text = "0";
            // 
            // LblS2
            // 
            this.LblS2.AutoSize = true;
            this.LblS2.BackColor = System.Drawing.Color.DarkGray;
            this.LblS2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblS2.Location = new System.Drawing.Point(368, 189);
            this.LblS2.Name = "LblS2";
            this.LblS2.Size = new System.Drawing.Size(38, 41);
            this.LblS2.TabIndex = 2;
            this.LblS2.Text = "0";
            // 
            // LblS1
            // 
            this.LblS1.AutoSize = true;
            this.LblS1.BackColor = System.Drawing.Color.DarkGray;
            this.LblS1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblS1.Location = new System.Drawing.Point(306, 189);
            this.LblS1.Name = "LblS1";
            this.LblS1.Size = new System.Drawing.Size(38, 41);
            this.LblS1.TabIndex = 4;
            this.LblS1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 599);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblS3);
            this.Controls.Add(this.LblS2);
            this.Controls.Add(this.LblS1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblS3;
        private System.Windows.Forms.Label LblS2;
        private System.Windows.Forms.Label LblS1;
    }
}