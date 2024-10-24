using BTBuoi8.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTBuoi8
{
    public partial class Form1 : Form
    {
        private int currentIndex = 0;
        private List<Student> studentsList;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new SchoolContext())
            {
                studentsList = context.Students.ToList();
                dataGridViewStudents.DataSource = studentsList;

                if (studentsList.Count > 0)
                {
                    currentIndex = 0;
                    DisplayCurrentStudent();
                }
            }
        }

        private void DisplayCurrentStudent()
        {
            if (studentsList != null && studentsList.Count > 0)
            {
                var currentStudent = studentsList[currentIndex];
                textBoxFullName.Text = currentStudent.FullName;
                textBoxAge.Text = currentStudent.Age.ToString();
                comboBoxMajor.SelectedItem = currentStudent.Major;

                // Chọn dòng tương ứng trên DataGridView
                dataGridViewStudents.ClearSelection();
                if (currentIndex >= 0 && currentIndex < dataGridViewStudents.Rows.Count)
                {
                    dataGridViewStudents.Rows[currentIndex].Selected = true;
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student
                {
                    FullName = textBoxFullName.Text,
                    Age = int.Parse(textBoxAge.Text),
                    Major = comboBoxMajor.SelectedItem.ToString()
                };
                context.Students.Add(student);
                context.SaveChanges();
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                using (var context = new SchoolContext())
                {
                    int studentId = (int)dataGridViewStudents.CurrentRow.Cells[0].Value;
                    var student = context.Students.Find(studentId);
                    if (student != null)
                    {
                        context.Students.Remove(student);
                        context.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                using (var context = new SchoolContext())
                {
                    int studentId = (int)dataGridViewStudents.CurrentRow.Cells[0].Value;
                    var student = context.Students.Find(studentId);
                    if (student != null)
                    {
                        student.FullName = textBoxFullName.Text;
                        student.Age = int.Parse(textBoxAge.Text);
                        student.Major = comboBoxMajor.SelectedItem.ToString();
                        context.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (studentsList != null && studentsList.Count > 0)
            {
                currentIndex++;
                if (currentIndex >= studentsList.Count)
                {
                    currentIndex = 0; // Quay về đầu danh sách nếu vượt quá cuối
                }
                DisplayCurrentStudent();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (studentsList != null && studentsList.Count > 0)
            {
                currentIndex--;
                if (currentIndex < 0)
                {
                    currentIndex = studentsList.Count - 1; // Quay về cuối danh sách nếu vượt quá đầu
                }
                DisplayCurrentStudent();
            }
        }
    }
}
