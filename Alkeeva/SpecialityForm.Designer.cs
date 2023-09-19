namespace Alkeeva
{
    partial class SpecialityForm
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 249);
            button3.Name = "button3";
            button3.Size = new Size(257, 23);
            button3.TabIndex = 13;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 210);
            button2.Name = "button2";
            button2.Size = new Size(257, 23);
            button2.TabIndex = 12;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 172);
            button1.Name = "button1";
            button1.Size = new Size(257, 23);
            button1.TabIndex = 11;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 50);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 9;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 6);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 6);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 15;
            label3.Text = "Необходимый предмет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 50);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 16;
            label4.Text = "Факультет";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(133, 68);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(136, 23);
            comboBox2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 94);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 18;
            label5.Text = "Бюджетные места";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            textBox3.Text = "1";
            // 
            // SpecialityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 289);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "SpecialityForm";
            Text = "SpecialityForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private TextBox textBox3;
    }
}