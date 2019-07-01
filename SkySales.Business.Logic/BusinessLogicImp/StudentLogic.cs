﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkySales.Common.Models;
using SkySales.Infrastructure.Repository;

namespace SkySales.Business.Logic
{
    public class StudentLogic : IBusinessLogic<Student>
    {
        IRepository<Student> studentRepository = new StudentRepository();

        public Student Add(Student student)
        {
           Student newStudent = studentRepository.Add(student);
            return newStudent;
        }

        public Student Delete(int id)
        {
            Student student = new Student();
            student = studentRepository.Delete(id);
            return student;
        }

        public List<Student> GetAll()
        {
            List<Student> studentsList = new List<Student>();
            studentsList = studentRepository.GetAll();
            return studentsList;
        }

        public Student GetById(int id)
        {
            Student student = new Student();
            student = studentRepository.GetById(id);
            return student;
        }

        public Student Update(Student student)
        {
            student = studentRepository.Update(student);
            return student;
        }
    }
}