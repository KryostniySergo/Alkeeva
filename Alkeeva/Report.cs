﻿using Alkeeva.DB.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkeeva
{
    public class Report
    {
        public static void Init(ComboBox comboBox1, ComboBox comboBox2)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var spec = db.Specialities.ToList();
                var fac = db.Faculties.ToList();
                comboBox1.DataSource = spec.Select(s => s.Name).ToList();
                comboBox2.DataSource = fac.Select(s => s.Name).ToList();
            }
        }

        public static void MakeReportSpeciality(DataGridView dataGridView1, ComboBox comboBox1)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.Rows.Clear();
                var speciality = db.Specialities.FirstOrDefault(s => s.Id == comboBox1.SelectedIndex + 1);
                var abiturs = db.Abiturients
                    .Where(s => s.SpecialityId == comboBox1.SelectedIndex + 1)
                    .OrderByDescending(s => (s.Russian + s.Math + s.Physics + s.Informatics + s.Social))
                    .ToList();
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Id";
                dataGridView1.Columns[1].Name = "ФИО";
                dataGridView1.Columns[2].Name = "Русский";
                dataGridView1.Columns[3].Name = "Математика";
                if (speciality.NessasaryItem != Items.Social)
                    dataGridView1.Columns[4].Name = speciality.NessasaryItem == Items.Informatics ? "Информатика" : "Физика";
                else
                    dataGridView1.Columns[4].Name = "Обществознание";
                dataGridView1.Columns[5].Name = "Всего баллов";

                for (int i = 0; i < abiturs.Count; i++)
                {
                    var item = abiturs[i];
                    if (speciality.NessasaryItem != Items.Social)
                    {
                        dataGridView1.Rows.Add(
                            item.Id,
                            item.FIO,
                            item.Russian,
                            item.Math,
                            item.Speciality.NessasaryItem == Items.Informatics ? item.Informatics : item.Physics,
                            (item.Russian + item.Math + item.Physics + item.Informatics + item.Social)
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
                            (item.Russian + item.Math + item.Physics + item.Informatics + item.Social)
                            );
                    }

                    if (i >= speciality.BudgetPlaces)
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                    else
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        public static void MakeReportFaculty(DataGridView dataGridView1, ComboBox comboBox2)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.Rows.Clear();
                var abiturs = db.Abiturients
                    .Include(s => s.Speciality)
                    .Where(s => s.Speciality.FacultyId == comboBox2.SelectedIndex + 1)
                    .OrderByDescending(s => (s.Russian + s.Math + s.Physics + s.Informatics + s.Social))
                    .ToList();
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "Id";
                dataGridView1.Columns[1].Name = "ФИО";
                dataGridView1.Columns[2].Name = "Русский";
                dataGridView1.Columns[3].Name = "Математика";
                dataGridView1.Columns[4].Name = "Физика";
                dataGridView1.Columns[5].Name = "Информатика";
                dataGridView1.Columns[6].Name = "Обществознание";
                dataGridView1.Columns[7].Name = "Всего баллов";

                for (int i = 0; i < abiturs.Count; i++)
                {
                    var item = abiturs[i];

                    dataGridView1.Rows.Add(
                           item.Id,
                           item.FIO,
                           item.Russian,
                           item.Math,
                           item.Physics,
                           item.Informatics,
                           item.Social,
                           (item.Russian + item.Math + item.Physics + item.Informatics + item.Social)
                           );
                }
            }
        }
    }
}
