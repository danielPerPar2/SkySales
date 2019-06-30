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
            //MessageBox.Show(String.Format("Added student: {0}", student.ToString()));
        }

        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            List<StudentWS> students = studentWebService.GetAll();
            foreach(StudentWS st in students)
            {
                Console.WriteLine(st.StudentId + " " + st.Name + " " + st.Surname + " " + st.Age);
            }
        }

        private void BtnGetById_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtStudentId.Text);
            StudentWS student = studentWebService.GetById(id);
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
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtStudentId.Text);
            StudentWS deletedStudent = studentWebService.Delete(id);
        }
    }
}
