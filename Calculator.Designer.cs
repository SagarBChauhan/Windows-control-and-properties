namespace Practical3
{
    partial class FormCalculator
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
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnPer = new System.Windows.Forms.Button();
            this.BtnRoot = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.Btn1byx = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnPlusMin = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnComa = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAnsDis = new System.Windows.Forms.Label();
            this.LblVal1 = new System.Windows.Forms.Label();
            this.LblVal2 = new System.Windows.Forms.Label();
            this.GroupVirtualCal = new System.Windows.Forms.GroupBox();
            this.GroupSelectType = new System.Windows.Forms.GroupBox();
            this.RadioVirtual = new System.Windows.Forms.RadioButton();
            this.RadioPhysical = new System.Windows.Forms.RadioButton();
            this.GroupPhysical = new System.Windows.Forms.GroupBox();
            this.Txtvalue1 = new System.Windows.Forms.TextBox();
            this.LblValue1 = new System.Windows.Forms.Label();
            this.TxtValue2 = new System.Windows.Forms.TextBox();
            this.LblValue2 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDisAnsPhy = new System.Windows.Forms.Label();
            this.GroupOpration = new System.Windows.Forms.GroupBox();
            this.RadioAdd = new System.Windows.Forms.RadioButton();
            this.RadioSub = new System.Windows.Forms.RadioButton();
            this.RadioMul = new System.Windows.Forms.RadioButton();
            this.RadioDiv = new System.Windows.Forms.RadioButton();
            this.GroupVirtualCal.SuspendLayout();
            this.GroupSelectType.SuspendLayout();
            this.GroupPhysical.SuspendLayout();
            this.GroupOpration.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.Location = new System.Drawing.Point(6, 21);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(362, 61);
            this.TxtDisplay.TabIndex = 1;
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay.TextChanged += new System.EventHandler(this.TxtDisplay_TextChanged);
            this.TxtDisplay.Enter += new System.EventHandler(this.btnEqual_Click);
            // 
            // BtnPer
            // 
            this.BtnPer.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPer.Location = new System.Drawing.Point(6, 106);
            this.BtnPer.Name = "BtnPer";
            this.BtnPer.Size = new System.Drawing.Size(86, 70);
            this.BtnPer.TabIndex = 2;
            this.BtnPer.Text = "%";
            this.BtnPer.UseVisualStyleBackColor = true;
            this.BtnPer.Click += new System.EventHandler(this.BtnPer_Click);
            // 
            // BtnRoot
            // 
            this.BtnRoot.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoot.Location = new System.Drawing.Point(98, 106);
            this.BtnRoot.Name = "BtnRoot";
            this.BtnRoot.Size = new System.Drawing.Size(86, 70);
            this.BtnRoot.TabIndex = 2;
            this.BtnRoot.Text = "√";
            this.BtnRoot.UseVisualStyleBackColor = true;
            this.BtnRoot.Click += new System.EventHandler(this.BtnRoot_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquare.Location = new System.Drawing.Point(190, 106);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(86, 70);
            this.BtnSquare.TabIndex = 2;
            this.BtnSquare.Text = "x2";
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // Btn1byx
            // 
            this.Btn1byx.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1byx.Location = new System.Drawing.Point(282, 106);
            this.Btn1byx.Name = "Btn1byx";
            this.Btn1byx.Size = new System.Drawing.Size(86, 70);
            this.Btn1byx.TabIndex = 2;
            this.Btn1byx.Text = "1/x";
            this.Btn1byx.UseVisualStyleBackColor = true;
            this.Btn1byx.Click += new System.EventHandler(this.Btn1byx_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn7.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(6, 258);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(86, 70);
            this.Btn7.TabIndex = 2;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn8.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(98, 258);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(86, 70);
            this.Btn8.TabIndex = 2;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn9.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(190, 258);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(86, 70);
            this.Btn9.TabIndex = 2;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMul.Location = new System.Drawing.Point(282, 258);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(86, 70);
            this.BtnMul.TabIndex = 2;
            this.BtnMul.Text = "×";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn4.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(6, 334);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(86, 70);
            this.Btn4.TabIndex = 2;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn5.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(98, 334);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(86, 70);
            this.Btn5.TabIndex = 2;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn6.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(190, 334);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(86, 70);
            this.Btn6.TabIndex = 2;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.Location = new System.Drawing.Point(282, 334);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(86, 70);
            this.BtnMinus.TabIndex = 2;
            this.BtnMinus.Text = "–";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(6, 410);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(86, 70);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(98, 410);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(86, 70);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(190, 410);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(86, 70);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.Location = new System.Drawing.Point(282, 410);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(86, 70);
            this.BtnPlus.TabIndex = 2;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnPlusMin
            // 
            this.BtnPlusMin.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlusMin.Location = new System.Drawing.Point(6, 486);
            this.BtnPlusMin.Name = "BtnPlusMin";
            this.BtnPlusMin.Size = new System.Drawing.Size(86, 70);
            this.BtnPlusMin.TabIndex = 2;
            this.BtnPlusMin.Text = "±";
            this.BtnPlusMin.UseVisualStyleBackColor = true;
            this.BtnPlusMin.Click += new System.EventHandler(this.BtnPlusMin_Click);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.Location = new System.Drawing.Point(98, 182);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(86, 70);
            this.BtnC.TabIndex = 2;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(190, 182);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(86, 70);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "«";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(282, 182);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(86, 70);
            this.BtnDiv.TabIndex = 2;
            this.BtnDiv.Text = "÷";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.Location = new System.Drawing.Point(6, 182);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(86, 70);
            this.BtnCE.TabIndex = 2;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn0.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(98, 486);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(86, 70);
            this.Btn0.TabIndex = 2;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnComa
            // 
            this.BtnComa.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComa.Location = new System.Drawing.Point(190, 486);
            this.BtnComa.Name = "BtnComa";
            this.BtnComa.Size = new System.Drawing.Size(86, 70);
            this.BtnComa.TabIndex = 2;
            this.BtnComa.Text = ".";
            this.BtnComa.UseVisualStyleBackColor = true;
            this.BtnComa.Click += new System.EventHandler(this.BtnComa_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(282, 486);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(86, 70);
            this.btnEqual.TabIndex = 2;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Answer:";
            // 
            // LblAnsDis
            // 
            this.LblAnsDis.AutoSize = true;
            this.LblAnsDis.Location = new System.Drawing.Point(482, 106);
            this.LblAnsDis.Name = "LblAnsDis";
            this.LblAnsDis.Size = new System.Drawing.Size(0, 17);
            this.LblAnsDis.TabIndex = 4;
            // 
            // LblVal1
            // 
            this.LblVal1.AutoSize = true;
            this.LblVal1.Location = new System.Drawing.Point(411, 26);
            this.LblVal1.Name = "LblVal1";
            this.LblVal1.Size = new System.Drawing.Size(0, 17);
            this.LblVal1.TabIndex = 4;
            // 
            // LblVal2
            // 
            this.LblVal2.AutoSize = true;
            this.LblVal2.Location = new System.Drawing.Point(411, 65);
            this.LblVal2.Name = "LblVal2";
            this.LblVal2.Size = new System.Drawing.Size(0, 17);
            this.LblVal2.TabIndex = 4;
            // 
            // GroupVirtualCal
            // 
            this.GroupVirtualCal.Controls.Add(this.TxtDisplay);
            this.GroupVirtualCal.Controls.Add(this.LblVal2);
            this.GroupVirtualCal.Controls.Add(this.BtnPer);
            this.GroupVirtualCal.Controls.Add(this.LblVal1);
            this.GroupVirtualCal.Controls.Add(this.Btn7);
            this.GroupVirtualCal.Controls.Add(this.LblAnsDis);
            this.GroupVirtualCal.Controls.Add(this.Btn4);
            this.GroupVirtualCal.Controls.Add(this.label1);
            this.GroupVirtualCal.Controls.Add(this.Btn1);
            this.GroupVirtualCal.Controls.Add(this.btnEqual);
            this.GroupVirtualCal.Controls.Add(this.BtnPlusMin);
            this.GroupVirtualCal.Controls.Add(this.BtnDiv);
            this.GroupVirtualCal.Controls.Add(this.BtnCE);
            this.GroupVirtualCal.Controls.Add(this.BtnPlus);
            this.GroupVirtualCal.Controls.Add(this.BtnRoot);
            this.GroupVirtualCal.Controls.Add(this.BtnMinus);
            this.GroupVirtualCal.Controls.Add(this.Btn8);
            this.GroupVirtualCal.Controls.Add(this.BtnMul);
            this.GroupVirtualCal.Controls.Add(this.Btn5);
            this.GroupVirtualCal.Controls.Add(this.Btn1byx);
            this.GroupVirtualCal.Controls.Add(this.Btn2);
            this.GroupVirtualCal.Controls.Add(this.BtnComa);
            this.GroupVirtualCal.Controls.Add(this.BtnC);
            this.GroupVirtualCal.Controls.Add(this.BtnBack);
            this.GroupVirtualCal.Controls.Add(this.Btn0);
            this.GroupVirtualCal.Controls.Add(this.Btn3);
            this.GroupVirtualCal.Controls.Add(this.BtnSquare);
            this.GroupVirtualCal.Controls.Add(this.Btn6);
            this.GroupVirtualCal.Controls.Add(this.Btn9);
            this.GroupVirtualCal.Location = new System.Drawing.Point(12, 81);
            this.GroupVirtualCal.Name = "GroupVirtualCal";
            this.GroupVirtualCal.Size = new System.Drawing.Size(520, 560);
            this.GroupVirtualCal.TabIndex = 5;
            this.GroupVirtualCal.TabStop = false;
            this.GroupVirtualCal.Text = "virtual";
            // 
            // GroupSelectType
            // 
            this.GroupSelectType.Controls.Add(this.RadioPhysical);
            this.GroupSelectType.Controls.Add(this.RadioVirtual);
            this.GroupSelectType.Location = new System.Drawing.Point(164, 12);
            this.GroupSelectType.Name = "GroupSelectType";
            this.GroupSelectType.Size = new System.Drawing.Size(187, 53);
            this.GroupSelectType.TabIndex = 6;
            this.GroupSelectType.TabStop = false;
            // 
            // RadioVirtual
            // 
            this.RadioVirtual.AutoSize = true;
            this.RadioVirtual.Location = new System.Drawing.Point(102, 21);
            this.RadioVirtual.Name = "RadioVirtual";
            this.RadioVirtual.Size = new System.Drawing.Size(69, 21);
            this.RadioVirtual.TabIndex = 0;
            this.RadioVirtual.Text = "Virtual";
            this.RadioVirtual.UseVisualStyleBackColor = true;
            this.RadioVirtual.CheckedChanged += new System.EventHandler(this.RadioVirtual_CheckedChanged);
            // 
            // RadioPhysical
            // 
            this.RadioPhysical.AutoSize = true;
            this.RadioPhysical.Checked = true;
            this.RadioPhysical.Location = new System.Drawing.Point(15, 21);
            this.RadioPhysical.Name = "RadioPhysical";
            this.RadioPhysical.Size = new System.Drawing.Size(81, 21);
            this.RadioPhysical.TabIndex = 0;
            this.RadioPhysical.TabStop = true;
            this.RadioPhysical.Text = "Physical";
            this.RadioPhysical.UseVisualStyleBackColor = true;
            this.RadioPhysical.CheckedChanged += new System.EventHandler(this.RadioMorden_CheckedChanged);
            // 
            // GroupPhysical
            // 
            this.GroupPhysical.Controls.Add(this.GroupOpration);
            this.GroupPhysical.Controls.Add(this.BtnCalculate);
            this.GroupPhysical.Controls.Add(this.LblValue2);
            this.GroupPhysical.Controls.Add(this.LblValue1);
            this.GroupPhysical.Controls.Add(this.TxtValue2);
            this.GroupPhysical.Controls.Add(this.Txtvalue1);
            this.GroupPhysical.Controls.Add(this.LblDisAnsPhy);
            this.GroupPhysical.Controls.Add(this.label2);
            this.GroupPhysical.Location = new System.Drawing.Point(12, 71);
            this.GroupPhysical.Name = "GroupPhysical";
            this.GroupPhysical.Size = new System.Drawing.Size(520, 574);
            this.GroupPhysical.TabIndex = 7;
            this.GroupPhysical.TabStop = false;
            this.GroupPhysical.Text = "Physical";
            // 
            // Txtvalue1
            // 
            this.Txtvalue1.Location = new System.Drawing.Point(181, 62);
            this.Txtvalue1.Name = "Txtvalue1";
            this.Txtvalue1.Size = new System.Drawing.Size(100, 22);
            this.Txtvalue1.TabIndex = 0;
            // 
            // LblValue1
            // 
            this.LblValue1.AutoSize = true;
            this.LblValue1.Location = new System.Drawing.Point(95, 65);
            this.LblValue1.Name = "LblValue1";
            this.LblValue1.Size = new System.Drawing.Size(56, 17);
            this.LblValue1.TabIndex = 1;
            this.LblValue1.Text = "Value1:";
            // 
            // TxtValue2
            // 
            this.TxtValue2.Location = new System.Drawing.Point(181, 96);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(100, 22);
            this.TxtValue2.TabIndex = 0;
            // 
            // LblValue2
            // 
            this.LblValue2.AutoSize = true;
            this.LblValue2.Location = new System.Drawing.Point(95, 99);
            this.LblValue2.Name = "LblValue2";
            this.LblValue2.Size = new System.Drawing.Size(56, 17);
            this.LblValue2.TabIndex = 1;
            this.LblValue2.Text = "Value2:";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(181, 197);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(78, 31);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer:";
            // 
            // LblDisAnsPhy
            // 
            this.LblDisAnsPhy.AutoSize = true;
            this.LblDisAnsPhy.Location = new System.Drawing.Point(174, 265);
            this.LblDisAnsPhy.Name = "LblDisAnsPhy";
            this.LblDisAnsPhy.Size = new System.Drawing.Size(0, 17);
            this.LblDisAnsPhy.TabIndex = 4;
            // 
            // GroupOpration
            // 
            this.GroupOpration.Controls.Add(this.RadioDiv);
            this.GroupOpration.Controls.Add(this.RadioMul);
            this.GroupOpration.Controls.Add(this.RadioSub);
            this.GroupOpration.Controls.Add(this.RadioAdd);
            this.GroupOpration.Location = new System.Drawing.Point(98, 129);
            this.GroupOpration.Name = "GroupOpration";
            this.GroupOpration.Size = new System.Drawing.Size(257, 54);
            this.GroupOpration.TabIndex = 5;
            this.GroupOpration.TabStop = false;
            // 
            // RadioAdd
            // 
            this.RadioAdd.AutoSize = true;
            this.RadioAdd.Location = new System.Drawing.Point(15, 21);
            this.RadioAdd.Name = "RadioAdd";
            this.RadioAdd.Size = new System.Drawing.Size(54, 21);
            this.RadioAdd.TabIndex = 0;
            this.RadioAdd.TabStop = true;
            this.RadioAdd.Text = "Add";
            this.RadioAdd.UseVisualStyleBackColor = true;
            // 
            // RadioSub
            // 
            this.RadioSub.AutoSize = true;
            this.RadioSub.Location = new System.Drawing.Point(75, 21);
            this.RadioSub.Name = "RadioSub";
            this.RadioSub.Size = new System.Drawing.Size(54, 21);
            this.RadioSub.TabIndex = 0;
            this.RadioSub.TabStop = true;
            this.RadioSub.Text = "Sub";
            this.RadioSub.UseVisualStyleBackColor = true;
            // 
            // RadioMul
            // 
            this.RadioMul.AutoSize = true;
            this.RadioMul.Location = new System.Drawing.Point(135, 21);
            this.RadioMul.Name = "RadioMul";
            this.RadioMul.Size = new System.Drawing.Size(51, 21);
            this.RadioMul.TabIndex = 0;
            this.RadioMul.TabStop = true;
            this.RadioMul.Text = "Mul";
            this.RadioMul.UseVisualStyleBackColor = true;
            // 
            // RadioDiv
            // 
            this.RadioDiv.AutoSize = true;
            this.RadioDiv.Location = new System.Drawing.Point(192, 21);
            this.RadioDiv.Name = "RadioDiv";
            this.RadioDiv.Size = new System.Drawing.Size(49, 21);
            this.RadioDiv.TabIndex = 0;
            this.RadioDiv.TabStop = true;
            this.RadioDiv.Text = "Div";
            this.RadioDiv.UseVisualStyleBackColor = true;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(542, 654);
            this.Controls.Add(this.GroupPhysical);
            this.Controls.Add(this.GroupSelectType);
            this.Controls.Add(this.GroupVirtualCal);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.GroupVirtualCal.ResumeLayout(false);
            this.GroupVirtualCal.PerformLayout();
            this.GroupSelectType.ResumeLayout(false);
            this.GroupSelectType.PerformLayout();
            this.GroupPhysical.ResumeLayout(false);
            this.GroupPhysical.PerformLayout();
            this.GroupOpration.ResumeLayout(false);
            this.GroupOpration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnPer;
        private System.Windows.Forms.Button BtnRoot;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button Btn1byx;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnPlusMin;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnComa;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAnsDis;
        private System.Windows.Forms.Label LblVal1;
        private System.Windows.Forms.Label LblVal2;
        private System.Windows.Forms.GroupBox GroupVirtualCal;
        private System.Windows.Forms.GroupBox GroupPhysical;
        private System.Windows.Forms.GroupBox GroupOpration;
        private System.Windows.Forms.RadioButton RadioDiv;
        private System.Windows.Forms.RadioButton RadioMul;
        private System.Windows.Forms.RadioButton RadioSub;
        private System.Windows.Forms.RadioButton RadioAdd;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label LblValue2;
        private System.Windows.Forms.Label LblValue1;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.TextBox Txtvalue1;
        private System.Windows.Forms.Label LblDisAnsPhy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GroupSelectType;
        private System.Windows.Forms.RadioButton RadioPhysical;
        private System.Windows.Forms.RadioButton RadioVirtual;

    }
}