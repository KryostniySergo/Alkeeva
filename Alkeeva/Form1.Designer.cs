namespace Alkeeva
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
            dataGridView1 = new DataGridView();
            SpecialityBox = new ComboBox();
            FacultyBox = new ComboBox();
            SpecialityLabel = new Label();
            FacultyLabel = new Label();
            ShowSpeciality = new Button();
            ShowFaculty = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(139, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(649, 426);
            dataGridView1.TabIndex = 0;
            // 
            // SpecialityBox
            // 
            SpecialityBox.FormattingEnabled = true;
            SpecialityBox.Location = new Point(12, 44);
            SpecialityBox.Name = "SpecialityBox";
            SpecialityBox.Size = new Size(121, 23);
            SpecialityBox.TabIndex = 1;
            // 
            // FacultyBox
            // 
            FacultyBox.FormattingEnabled = true;
            FacultyBox.Location = new Point(12, 136);
            FacultyBox.Name = "FacultyBox";
            FacultyBox.Size = new Size(121, 23);
            FacultyBox.TabIndex = 2;
            // 
            // SpecialityLabel
            // 
            SpecialityLabel.AutoSize = true;
            SpecialityLabel.Location = new Point(34, 26);
            SpecialityLabel.Name = "SpecialityLabel";
            SpecialityLabel.Size = new Size(81, 15);
            SpecialityLabel.TabIndex = 3;
            SpecialityLabel.Text = "Направления";
            // 
            // FacultyLabel
            // 
            FacultyLabel.AutoSize = true;
            FacultyLabel.Location = new Point(37, 118);
            FacultyLabel.Name = "FacultyLabel";
            FacultyLabel.Size = new Size(72, 15);
            FacultyLabel.TabIndex = 4;
            FacultyLabel.Text = "Факультеты";
            // 
            // ShowSpeciality
            // 
            ShowSpeciality.Location = new Point(34, 73);
            ShowSpeciality.Name = "ShowSpeciality";
            ShowSpeciality.Size = new Size(75, 23);
            ShowSpeciality.TabIndex = 5;
            ShowSpeciality.Text = "Показать";
            ShowSpeciality.UseVisualStyleBackColor = true;
            ShowSpeciality.Click += ShowSpeciality_Click;
            // 
            // ShowFaculty
            // 
            ShowFaculty.Location = new Point(34, 165);
            ShowFaculty.Name = "ShowFaculty";
            ShowFaculty.Size = new Size(75, 23);
            ShowFaculty.TabIndex = 6;
            ShowFaculty.Text = "Показать";
            ShowFaculty.UseVisualStyleBackColor = true;
            ShowFaculty.Click += ShowFaculty_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowFaculty);
            Controls.Add(ShowSpeciality);
            Controls.Add(FacultyLabel);
            Controls.Add(SpecialityLabel);
            Controls.Add(FacultyBox);
            Controls.Add(SpecialityBox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox SpecialityBox;
        private ComboBox FacultyBox;
        private Label SpecialityLabel;
        private Label FacultyLabel;
        private Button ShowSpeciality;
        private Button ShowFaculty;
    }
}