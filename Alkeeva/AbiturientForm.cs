using Alkeeva.DB.Model;

namespace Alkeeva
{
    public partial class AbiturientForm : Form
    {
        public AbiturientForm()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var specialities = db.Specialities.ToList();
                comboBox1.DataSource = specialities.Select(s => s.Name).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var abiturients = new Abiturients
                    {
                        FIO = textBox2.Text,
                        Russian = int.Parse(textBox3.Text),
                        Math = int.Parse(textBox4.Text),
                        Physics = int.Parse(textBox5.Text),
                        Social = int.Parse(textBox6.Text),
                        Informatics = int.Parse(textBox7.Text),
                        SpecialityId = comboBox1.SelectedIndex + 1
                    };
                    db.Abiturients.Add(abiturients);
                    db.SaveChanges();
                    MessageBox.Show($"Добавлен новый абитуриент {abiturients.FIO}");
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
                    var abiturients = db.Abiturients
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (abiturients is null)
                    {
                        MessageBox.Show("Нет такого направления");
                        return;
                    }

                    abiturients.FIO = textBox2.Text;
                    abiturients.Russian = int.Parse(textBox3.Text);
                    abiturients.Math = int.Parse(textBox4.Text);
                    abiturients.Physics = int.Parse(textBox5.Text);
                    abiturients.Social = int.Parse(textBox6.Text);
                    abiturients.Informatics = int.Parse(textBox7.Text);
                    abiturients.SpecialityId = comboBox1.SelectedIndex + 1;

                    db.Abiturients.Update(abiturients);
                    db.SaveChanges();
                    MessageBox.Show($"Изменен {abiturients.FIO}");
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
                    var abiturients = db.Abiturients
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (abiturients is null)
                    {
                        MessageBox.Show("Нет такого факультета");
                        return;
                    }

                    db.Abiturients.Remove(abiturients);
                    db.SaveChanges();
                    MessageBox.Show($"Удален  {abiturients.FIO}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }

            }
        }
    }
}
