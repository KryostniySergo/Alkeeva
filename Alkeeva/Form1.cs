using Alkeeva.DB.Model;
using Microsoft.EntityFrameworkCore;


namespace Alkeeva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Report.Init(SpecialityBox, FacultyBox);

        }

        public void Refresh()
        {
            Report.Init(SpecialityBox, FacultyBox);
        }

        private void ShowSpeciality_Click(object sender, EventArgs e)
        {
            Report.MakeReportSpeciality(dataGridView1, SpecialityBox);
        }

        private void ShowFaculty_Click(object sender, EventArgs e)
        {
            Report.MakeReportFaculty(dataGridView1, FacultyBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FacultyForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SpecialityForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AbiturientForm().Show();
        }
    }
}