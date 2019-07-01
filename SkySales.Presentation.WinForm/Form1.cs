using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkySales.Presentation.WinForm.StudentWebServiceReference;

namespace SkySales.Presentation.WinForm
{
    public partial class Form1 : Form
    {
        private IStudentWebService studentWebService = new StudentWebServiceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            StudentWS student = new StudentWS()
            {
                Name = txtStudentName.Text,
                Surname = txtStudentSurname.Text,
                Age = Int32.Parse(txtStudentAge.Text)
            };
            StudentWS addedStudent = studentWebService.Add(student);
            ShowStudentInTextBoxes(addedStudent);
        }

        private void BtnGetAll_Click(object sender, EventArgs e)
        {           
            GetAllStudents();
        }

        private void BtnGetById_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtStudentId.Text);
            StudentWS student = studentWebService.GetById(id);
            ShowStudentInTextBoxes(student);
        }
        private void BtnUpdateStudent_Click(object sender, EventArgs e)
        {
            StudentWS student = new StudentWS()
            {
                StudentId = Int32.Parse(txtStudentId.Text),
                Name = txtStudentName.Text,
                Surname = txtStudentSurname.Text,
                Age = Int32.Parse(txtStudentAge.Text)
            };
            StudentWS updatedStudent = studentWebService.Update(student);
            ShowStudentInTextBoxes(updatedStudent);
            GetAllStudents();
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtStudentId.Text);
            StudentWS deletedStudent = studentWebService.Delete(id);           
            ShowStudentInTextBoxes(deletedStudent);
        }

        private void ShowStudentInTextBoxes(StudentWS student)
        {
            txtStudentId.Text = student.StudentId.ToString();
            txtStudentName.Text = student.Name;
            txtStudentSurname.Text = student.Surname;
            txtStudentAge.Text = student.Age.ToString();
        }

        private void ListViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listViewStudents.SelectedItems[0].Text;
            string[] split = selectedItem.Split(new char[] { ' ' });
            StudentWS student = new StudentWS()
            {
                StudentId = Int32.Parse(split[0]),
                Name = split[1],
                Surname = split[2],
                Age = Int32.Parse(split[3])
            };

            ShowStudentInTextBoxes(student);            
            GetAllStudents();
        }

        private void GetAllStudents()
        {
            listViewStudents.Clear();
            List<StudentWS> students = studentWebService.GetAll();
            foreach (StudentWS st in students)
            {
                listViewStudents.Items.Add(st.StudentId + " " + st.Name + " " + st.Surname + " " + st.Age);
            }
        }
    }
}
