namespace Practical3
{
    partial class palindrome
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
            this.LblStr = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblStr
            // 
            this.LblStr.AutoSize = true;
            this.LblStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStr.Location = new System.Drawing.Point(32, 39);
            this.LblStr.Name = "LblStr";
            this.LblStr.Size = new System.Drawing.Size(56, 17);
            this.LblStr.TabIndex = 0;
            this.LblStr.Text = "String:";
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(107, 34);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(100, 22);
            this.TxtValue.TabIndex = 1;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(107, 81);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnCheck.TabIndex = 2;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplay.Location = new System.Drawing.Point(104, 134);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(0, 17);
            this.LblDisplay.TabIndex = 0;
            // 
            // palindrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 179);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.LblDisplay);
            this.Controls.Add(this.LblStr);
            this.Name = "palindrome";
            this.Text = "palindrome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStr;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label LblDisplay;
    }
}