using SkySales.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace SkySales.Infrastructure.Repository
{
   public class StudentRepository : IRepository<Student>
    {
        public Student Add(Student model)
        {
            Student student = new Student();
            //cadena de conexión al Web.config
            using (SqlConnection connection = new SqlConnection(@WebConfigurationManager.AppSettings["SQLConection"]))
            {
                connection.Open();//lanza excepciones - en el try catch logariamos el student y la excepción
                using (SqlCommand command = new SqlCommand("INSERT INTO Students (Name, Surname, Age)VALUES(@name, @surname, @age)", connection))
                {
                    command.Parameters.AddWithValue("@name", model.Name);
                    command.Parameters.AddWithValue("@surname", model.Surname);
                    command.Parameters.AddWithValue("@age", model.Age);

                    command.ExecuteNonQuery();
                    //habria que buscar el user insertado y retornarlo
                }
              student=  GetById(model.StudentId);
            }
            return student;
        }

        public Student Delete(int id)
        {
            Student student;
            student = GetById(id);
            //cadena de conexión al Web.config
            using (SqlConnection connection = new SqlConnection(@WebConfigurationManager.AppSettings["SQLConection"]))
            {
                connection.Open();//lanza excepciones - en el try catch logariamos el student y la excepción
                
                using (SqlCommand command = new SqlCommand("DELETE FROM Students WHERE StudentID=@id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    //habria que buscar el user insertado y retornarlo
                }

                return student;
            }
        }

       

        public List<Student> GetAll()
        {
            //poner cadena de conexión en el Web.config
            using (var connection = new SqlConnection(WebConfigurationManager.AppSettings["SQLConection"]))
            {
                var studentList = new List<Student>();
                connection.Open();//lanza excepciones - en el try catch logariamos el student y la excepción
                using (var command = new SqlCommand("SELECT * FROM Student", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {                       
                        while(reader.Read())
                        {
                            var student = new Student();
                            student.StudentId=Int32.Parse( reader["StudentID"].ToString());
                            student.Name = reader["Name"].ToString();
                            student.Surname = reader["Surname"].ToString();
                            student.Age = Int32.Parse(reader["Age"].ToString());
                            studentList.Add(student);
                        }
                    }                    
                }

                return studentList;
            }
        }

        public Student GetById(int id)
        {
            var student = new Student();
            using (SqlConnection connection = new SqlConnection(@WebConfigurationManager.AppSettings["SQLConection"]))
            {
                connection.Open();//lanza excepciones - en el try catch logariamos el student y la excepción
                using (SqlCommand command = new SqlCommand("SELECT * FROM Students WHERE StudentID=@id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student.StudentId = Int32.Parse(reader["StudentID"].ToString());
                            student.Name = reader["Name"].ToString();
                            student.Surname = reader["Surname"].ToString();
                            student.Age = Int32.Parse(reader["Age"].ToString());
                        }
                    }
                    //habria que buscar el user insertado y retornarlo
                }

                return student;
            }
        }

     

        public Student Update(Student student)
        {
            Student newStudent;
            using (SqlConnection connection = new SqlConnection(@WebConfigurationManager.AppSettings["SQLConection"]))
            {
                connection.Open();//lanza excepciones - en el try catch logariamos el student y la excepción
                using (SqlCommand command = new SqlCommand("UPDATE Students SET  Name=@name, Surname=@surname, Age=@age WHERE StudentID=@id", connection))
                {
                    command.Parameters.AddWithValue("@id",student.StudentId);
                    command.Parameters.AddWithValue("@name", student.Name);
                    command.Parameters.AddWithValue("@surname", student.Surname);
                    command.Parameters.AddWithValue("@age", student.Age);


                    command.ExecuteNonQuery();
                    //habria que buscar el user insertado y retornarlo
                }
                newStudent = GetById(student.StudentId);

               return newStudent;
            }

        }
    }
}
