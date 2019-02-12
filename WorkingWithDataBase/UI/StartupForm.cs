using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorkingWithDataBase.BLL;
using WorkingWithDataBase.Model;

namespace WorkingWithDataBase.UI
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            GetAllData();
        }



        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student()
            {
                Name = nameTextBox.Text,
                ContactNo = contactNoTextBox.Text,
            };
            StudentSave aStudentSave = new StudentSave();
            int result = aStudentSave.Save(aStudent);
            if (result > 0)
            {
                resultLabel.Text = "Student is successfully saved,";
            }
            else
            {
                resultLabel.Text = "Student is failed to saved,";
            }
            GetAllData();
        }

        private void GetAllData()
        {
            StudentBll aStudentBll = new StudentBll();
            List<Student> allStudents = aStudentBll.GetMoreThenOneStudent();
            dataGridView1.DataSource = allStudents;
        }
    }
}