namespace calculator
{
    partial class CalculatorUI
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
            display = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            AdditionButton = new Button();
            DecimalButton = new Button();
            button0 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            DivideButton = new Button();
            MinusButton = new Button();
            MultiplicationButton = new Button();
            DelButton = new Button();
            ClearButton = new Button();
            SumButton = new Button();
            SuspendLayout();
            // 
            // display
            // 
            display.BorderStyle = BorderStyle.FixedSingle;
            display.Font = new Font("Segoe UI", 20F);
            display.Location = new Point(12, 12);
            display.Multiline = true;
            display.Name = "display";
            display.ReadOnly = true;
            display.Size = new Size(393, 113);
            display.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(12, 145);
            button1.Name = "button1";
            button1.Size = new Size(72, 67);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(90, 145);
            button2.Name = "button2";
            button2.Size = new Size(72, 67);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(168, 145);
            button3.Name = "button3";
            button3.Size = new Size(72, 67);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(12, 218);
            button4.Name = "button4";
            button4.Size = new Size(72, 67);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F);
            button5.Location = new Point(90, 218);
            button5.Name = "button5";
            button5.Size = new Size(72, 67);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F);
            button6.Location = new Point(168, 218);
            button6.Name = "button6";
            button6.Size = new Size(72, 67);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // AdditionButton
            // 
            AdditionButton.Font = new Font("Segoe UI", 14F);
            AdditionButton.Location = new Point(333, 291);
            AdditionButton.Name = "AdditionButton";
            AdditionButton.Size = new Size(72, 67);
            AdditionButton.TabIndex = 12;
            AdditionButton.Text = "+";
            AdditionButton.UseVisualStyleBackColor = true;
            AdditionButton.Click += AdditionButton_Click;
            // 
            // DecimalButton
            // 
            DecimalButton.Font = new Font("Segoe UI", 14F);
            DecimalButton.Location = new Point(90, 364);
            DecimalButton.Name = "DecimalButton";
            DecimalButton.Size = new Size(72, 67);
            DecimalButton.TabIndex = 11;
            DecimalButton.Text = ".";
            DecimalButton.UseVisualStyleBackColor = true;
            DecimalButton.Click += DecimalButton_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 14F);
            button0.Location = new Point(12, 364);
            button0.Name = "button0";
            button0.Size = new Size(72, 67);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14F);
            button9.Location = new Point(168, 291);
            button9.Name = "button9";
            button9.Size = new Size(72, 67);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14F);
            button8.Location = new Point(90, 291);
            button8.Name = "button8";
            button8.Size = new Size(72, 67);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F);
            button7.Location = new Point(12, 291);
            button7.Name = "button7";
            button7.Size = new Size(72, 67);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // DivideButton
            // 
            DivideButton.Font = new Font("Segoe UI", 14F);
            DivideButton.Location = new Point(255, 218);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(72, 67);
            DivideButton.TabIndex = 13;
            DivideButton.Text = "÷";
            DivideButton.UseVisualStyleBackColor = true;
            // 
            // MinusButton
            // 
            MinusButton.Font = new Font("Segoe UI", 14F);
            MinusButton.Location = new Point(255, 291);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(72, 67);
            MinusButton.TabIndex = 14;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // MultiplicationButton
            // 
            MultiplicationButton.Font = new Font("Segoe UI", 14F);
            MultiplicationButton.Location = new Point(333, 218);
            MultiplicationButton.Name = "MultiplicationButton";
            MultiplicationButton.Size = new Size(72, 67);
            MultiplicationButton.TabIndex = 15;
            MultiplicationButton.Text = "×";
            MultiplicationButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            DelButton.Font = new Font("Segoe UI", 14F);
            DelButton.Location = new Point(168, 364);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(72, 67);
            DelButton.TabIndex = 16;
            DelButton.Text = "DEL";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 14F);
            ClearButton.Location = new Point(255, 145);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(150, 67);
            ClearButton.TabIndex = 17;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SumButton
            // 
            SumButton.Font = new Font("Segoe UI", 14F);
            SumButton.Location = new Point(255, 364);
            SumButton.Name = "SumButton";
            SumButton.Size = new Size(150, 67);
            SumButton.TabIndex = 18;
            SumButton.Text = "=";
            SumButton.UseVisualStyleBackColor = true;
            SumButton.Click += SumButton_Click;
            // 
            // CalculatorUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(SumButton);
            Controls.Add(ClearButton);
            Controls.Add(DelButton);
            Controls.Add(MultiplicationButton);
            Controls.Add(MinusButton);
            Controls.Add(DivideButton);
            Controls.Add(AdditionButton);
            Controls.Add(DecimalButton);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(display);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalculatorUI";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button AdditionButton;
        private Button DecimalButton;
        private Button button0;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button DivideButton;
        private Button MinusButton;
        private Button MultiplicationButton;
        private Button DelButton;
        private Button ClearButton;
        private Button SumButton;
    }
}
