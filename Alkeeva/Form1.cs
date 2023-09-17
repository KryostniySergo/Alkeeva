using Alkeeva.DB.Model;
using Microsoft.EntityFrameworkCore;


namespace Alkeeva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var spec = db.Specialities.ToList();
                comboBox1.DataSource = spec.Select(s => s.Name).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.Rows.Clear();
                var abiturs = db.Abiturients
                    .Where(s => s.SpecialityId == comboBox1.SelectedIndex + 1)
                    .Include(s => s.Speciality)
                    .ToList();
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Id";
                dataGridView1.Columns[1].Name = "ФИО";
                dataGridView1.Columns[2].Name = "Русский";
                dataGridView1.Columns[3].Name = "Математика";
                if (abiturs[0].Speciality.NessasaryItem != Items.Social)
                    dataGridView1.Columns[4].Name = abiturs[0].Speciality.NessasaryItem == Items.Informatics ? "Информатика" : "Физика";
                else
                    dataGridView1.Columns[4].Name = "Обществознание";
                dataGridView1.Columns[5].Name = "Всего баллов";

                foreach (var item in abiturs)
                {
                    if (abiturs[0].Speciality.NessasaryItem != Items.Social)
                    {
                        dataGridView1.Rows.Add(
                            item.Id,
                            item.FIO,
                            item.Russian,
                            item.Math,
                            item.Speciality.NessasaryItem == Items.Informatics ? item.Informatics : item.Physics,
                            item.Speciality.Name
                            );
                    }
                    else
                    {
                        dataGridView1.Rows.Add(
                            item.Id,
                            item.FIO,
                            item.Russian,
                            item.Math,
                            item.Social,
                            item.Speciality.Name
                            );
                    }
                         
                }
            }
            //Ab.aa(dataGridView1);
            //dataGridView1.Visible = !dataGridView1.Visible;
        }
    }

    public class Ab
    {
        public static void aa(DataGridView dataGridView1)
        {
            dataGridView1.Visible = !dataGridView1.Visible;
            //dataGridView1.ColumnCount = 2;
            //dataGridView1.Columns[0].Name = "Release Dat231321e";
            //dataGridView1.Columns[1].Name = "Trac21312k";
        }
    }
}