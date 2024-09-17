namespace Rial
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(132, 47);
            button1.Name = "button1";
            button1.Size = new Size(232, 39);
            button1.TabIndex = 6;
            button1.Text = "تبدیل";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(16, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 23);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(470, 23);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(470, 23);
            textBox3.TabIndex = 8;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(470, 23);
            textBox4.TabIndex = 9;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(458, 89);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 10;
            label1.Text = "عدد";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 142);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 11;
            label2.Text = "ریال";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 193);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "تومان";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "UserControl1";
            RightToLeft = RightToLeft.No;
            Size = new Size(499, 249);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
