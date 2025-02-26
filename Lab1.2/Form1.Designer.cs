namespace Lab1._2
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
            num1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(523, 32);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(306, 71);
            label2.Name = "label2";
            label2.Size = new Size(482, 32);
            label2.TabIndex = 1;
            label2.Text = "\r\n";
            label2.Click += label2_Click_1;
            // 
            // num1
            // 
            num1.Location = new Point(340, 368);
            num1.Name = "num1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 2;
            num1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(280, 359);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 3;
            label3.Text = "X =";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(234, 271);
            button1.Name = "button1";
            button1.Size = new Size(286, 42);
            button1.TabIndex = 4;
            button1.Text = "Виведення результату";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(229, 32);
            label4.TabIndex = 5;
            label4.Text = "2х + 3x^2- 4x^3 =";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 71);
            label5.Name = "label5";
            label5.Size = new Size(288, 32);
            label5.TabIndex = 6;
            label5.Text = "1 + 2х + 3х^2 +4х^3. =\r\n";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(num1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "Form1";
            Text = "Друге завдання";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox num1;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}
