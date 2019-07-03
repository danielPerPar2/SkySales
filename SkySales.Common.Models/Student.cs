using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SkySales.Common.Models
{
    //usamos la misma entidad en la capa de servicios y la capa de common models.
    //Añadimos los atributos para serializar
    [DataContract]
    public class Student
    {
        public Student(){}
        public Student(int id, string name, string surnaName, int age)
        {
            StudentId = id;
            Name = name;
            Surname = surnaName;
            Age = age;
        }
        public Student(string name, string surname, int age)
        {
            StudentId = 0;
            Name = name;
            Surname = surname;
            Age = age;
        }

        [DataMember]
        public int StudentId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Age == student.Age;
        }

        public override int GetHashCode()
        {
            var hashCode = -1235398547;
            hashCode = hashCode * -1521134295 + StudentId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }
    }
}
