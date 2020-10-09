namespace Practical3
{
    partial class Random
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
            this.LblNum1 = new System.Windows.Forms.Label();
            this.LblNum2 = new System.Windows.Forms.Label();
            this.LblNum3 = new System.Windows.Forms.Label();
            this.BtnSpin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNum1
            // 
            this.LblNum1.AutoSize = true;
            this.LblNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNum1.Location = new System.Drawing.Point(126, 76);
            this.LblNum1.Name = "LblNum1";
            this.LblNum1.Size = new System.Drawing.Size(38, 41);
            this.LblNum1.TabIndex = 0;
            this.LblNum1.Text = "0";
            // 
            // LblNum2
            // 
            this.LblNum2.AutoSize = true;
            this.LblNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNum2.Location = new System.Drawing.Point(197, 76);
            this.LblNum2.Name = "LblNum2";
            this.LblNum2.Size = new System.Drawing.Size(38, 41);
            this.LblNum2.TabIndex = 0;
            this.LblNum2.Text = "0";
            // 
            // LblNum3
            // 
            this.LblNum3.AutoSize = true;
            this.LblNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNum3.Location = new System.Drawing.Point(269, 76);
            this.LblNum3.Name = "LblNum3";
            this.LblNum3.Size = new System.Drawing.Size(38, 41);
            this.LblNum3.TabIndex = 0;
            this.LblNum3.Text = "0";
            // 
            // BtnSpin
            // 
            this.BtnSpin.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSpin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BtnSpin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSpin.Location = new System.Drawing.Point(126, 146);
            this.BtnSpin.Name = "BtnSpin";
            this.BtnSpin.Size = new System.Drawing.Size(179, 36);
            this.BtnSpin.TabIndex = 1;
            this.BtnSpin.Text = "Spin";
            this.BtnSpin.UseVisualStyleBackColor = true;
            this.BtnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 253);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSpin);
            this.Controls.Add(this.LblNum3);
            this.Controls.Add(this.LblNum2);
            this.Controls.Add(this.LblNum1);
            this.Name = "Random";
            this.Text = "Random";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNum1;
        private System.Windows.Forms.Label LblNum2;
        private System.Windows.Forms.Label LblNum3;
        private System.Windows.Forms.Button BtnSpin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}