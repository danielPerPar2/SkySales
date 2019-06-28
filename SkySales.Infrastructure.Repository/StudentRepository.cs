using SkySales.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SkySales.Infrastructure.Repository
{
    class StudentRepository : IRepository<Student>
    {
        public Student Add(Student model)
        {
            //cadena de conexión al Web.config
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-EAR76KC;Initial Catalog=Vueling;Integrated Security=True"))
            {
                connection.Open();//lanza excepciones - en el try catch logariamos el student y la excepción
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.ExecuteNonQuery();
                    //habria que buscar el user insertado y retornarlo
                }

                  throw new NotImplementedException();
            }         
        }

        public List<Student> GetAll()
        {
            //poner cadena de conexión en el Web.config
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-EAR76KC;Initial Catalog=Vueling;Integrated Security=True"))
            {
                var studentList = new List<Student>();
                connection.Open();//lanza excepciones - en el try catch logariamos el student y la excepción
                using (var command = new SqlCommand("", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {                       
                        while(reader.Read())
                        {
                            var student = new Student();
                            student.Name = reader["Name"].ToString();
                            studentList.Add(student);
                        }
                    }                    
                }

                return studentList;
            }
        }
    }
}
