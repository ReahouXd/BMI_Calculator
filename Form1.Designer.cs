namespace EMI_Calculate
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            amountTextBox = new TextBox();
            rateTextBox = new TextBox();
            button1 = new Button();
            termnumericUpDown = new NumericUpDown();
            output = new TextBox();
            ((System.ComponentModel.ISupportInitialize)termnumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 128);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "Loan amount (P):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 212);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 1;
            label2.Text = "Amual rate (R) %:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 290);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 2;
            label3.Text = "Term (n):";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(203, 125);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(207, 34);
            amountTextBox.TabIndex = 3;
            // 
            // rateTextBox
            // 
            rateTextBox.Location = new Point(203, 209);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(207, 34);
            rateTextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(432, 125);
            button1.Name = "button1";
            button1.Size = new Size(150, 199);
            button1.TabIndex = 5;
            button1.Text = "Calculate EMI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // termnumericUpDown
            // 
            termnumericUpDown.Location = new Point(211, 290);
            termnumericUpDown.Name = "termnumericUpDown";
            termnumericUpDown.Size = new Size(190, 34);
            termnumericUpDown.TabIndex = 7;
            termnumericUpDown.ValueChanged += termnumericUpDown_ValueChanged;
            // 
            // output
            // 
            output.Location = new Point(616, 125);
            output.Multiline = true;
            output.Name = "output";
            output.RightToLeft = RightToLeft.No;
            output.Size = new Size(214, 199);
            output.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(880, 436);
            Controls.Add(output);
            Controls.Add(termnumericUpDown);
            Controls.Add(button1);
            Controls.Add(rateTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equated Monthly Installment Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)termnumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox amountTextBox;
        private TextBox rateTextBox;
        private Button button1;
        private NumericUpDown termnumericUpDown;
        private TextBox output;
    }
}
