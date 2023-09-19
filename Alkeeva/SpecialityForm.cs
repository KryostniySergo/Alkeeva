using Alkeeva.DB.Model;

namespace Alkeeva
{
    public partial class SpecialityForm : Form
    {
        public SpecialityForm()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var fac = db.Faculties.ToList();
                comboBox1.DataSource = Enum.GetValues(typeof(Items)).Cast<Items>().ToList();
                comboBox2.DataSource = fac.Select(s => s.Name).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var speciality = new Speciality
                    {
                        Name = textBox2.Text,
                        BudgetPlaces = int.Parse(textBox3.Text),
                        NessasaryItem = Enum.GetValues(typeof(Items)).Cast<Items>().ToList()[comboBox1.SelectedIndex],
                        FacultyId = comboBox2.SelectedIndex + 1
                    };
                    db.Specialities.Add(speciality);
                    db.SaveChanges();
                    MessageBox.Show($"Добавлено новое направление {speciality.Name}");
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
                    var speciality = db.Specialities
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (speciality is null)
                    {
                        MessageBox.Show("Нет такого направления");
                        return;
                    }

                    speciality.Name = textBox2.Text;
                    speciality.BudgetPlaces = int.Parse(textBox3.Text);
                    speciality.NessasaryItem = Enum.GetValues(typeof(Items)).Cast<Items>().ToList()[comboBox1.SelectedIndex];
                    speciality.FacultyId = comboBox2.SelectedIndex + 1;

                    db.Specialities.Update(speciality);
                    db.SaveChanges();
                    MessageBox.Show($"Изменено направление {speciality.Name}");
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
                    var speciality = db.Specialities
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (speciality is null)
                    {
                        MessageBox.Show("Нет такого факультета");
                        return;
                    }

                    db.Specialities.Remove(speciality);
                    db.SaveChanges();
                    MessageBox.Show($"Удалено направление {speciality.Name}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }

            }
        }
    }
}
