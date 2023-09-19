using Alkeeva.DB.Model;

namespace Alkeeva
{
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var faculty = new Faculty { Name = textBox2.Text };
                    db.Faculties.Add(faculty);
                    db.SaveChanges();
                    MessageBox.Show($"Добавлен новый факультет {textBox2.Text}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var faculty = db.Faculties
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (faculty is null)
                    {
                        MessageBox.Show("Нет такого факультета");
                        return;
                    }


                    faculty.Name = textBox2.Text;

                    db.Faculties.Update(faculty);
                    db.SaveChanges();
                    MessageBox.Show($"Изменен факультет {textBox2.Text}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var faculty = db.Faculties
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (faculty is null)
                    {
                        MessageBox.Show("Нет такого факультета");
                        return;
                    }

                    db.Faculties.Remove(faculty);
                    db.SaveChanges();
                    MessageBox.Show($"Удален факультет {faculty.Name}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }

            }
        }
    }
}
