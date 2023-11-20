namespace Practica_10__unidad_3
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
            listBox1 = new ListBox();
            label3 = new Label();
            listBox2 = new ListBox();
            label4 = new Label();
            listBox3 = new ListBox();
            label5 = new Label();
            listBox4 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 47);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "z=x^2 + x^3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 94);
            label2.Name = "label2";
            label2.Size = new Size(20, 21);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 255, 192);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(44, 118);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(96, 109);
            listBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 94);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 3;
            label3.Text = "X^2";
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(255, 255, 192);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(173, 118);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(91, 109);
            listBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(328, 94);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 5;
            label4.Text = "X^3";
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.FromArgb(255, 255, 192);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(301, 118);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(89, 109);
            listBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(458, 94);
            label5.Name = "label5";
            label5.Size = new Size(20, 21);
            label5.TabIndex = 7;
            label5.Text = "Z";
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.FromArgb(255, 255, 192);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(433, 118);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(89, 109);
            listBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(196, 257);
            button1.Name = "button1";
            button1.Size = new Size(162, 38);
            button1.TabIndex = 9;
            button1.Text = "Calcular Valores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox4);
            Controls.Add(label5);
            Controls.Add(listBox3);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calcular Valores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private ListBox listBox2;
        private Label label4;
        private ListBox listBox3;
        private Label label5;
        private ListBox listBox4;
        private Button button1;
    }
}