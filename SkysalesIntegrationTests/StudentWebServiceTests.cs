using System;
using System.Collections.Generic;
using Integration.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkySales.Common.Models;
using SkySales.Web.Services;
using SkysalesIntegrationTests.Modules;

namespace SkysalesIntegrationTests
{
    [TestClass]
    public class StudentWebServiceTests : IoCSupportedTest<TestModule>
    {
        //Ojo!! el service no se registra como tipo de interfaz, vamos a usar namespace.clase
        private StudentsServiceReference.StudentWebServiceClient studentService;
        private List<Student> testStudents = new List<Student>();

        [TestInitialize]
        public void Setup()
        {
            studentService = Resolve<StudentsServiceReference.StudentWebServiceClient>();          
            testStudents = AddTestStudents();
        }

        [TestCleanup]
        public void CleanUp()
        {
            studentService.Close();
            ShutdownIoC();
        }

        [TestMethod]
        public void AddTest()
        {
            Student student = new Student("Elisa", "Gómez", 64);
            Student addedStudent = studentService.Add(student);
            student.StudentId = addedStudent.StudentId;
            Assert.AreEqual(student, addedStudent);
        }

        [TestMethod]
        public void GetAllTest()
        {
            List<Student> studentList;
            studentList = studentService.GetAll();
            Assert.IsInstanceOfType(studentList, typeof(List<Student>));

        }

        [TestMethod]
        public void GetByIdTest()
        {
            Student testStudent = testStudents[0];
            Student recoveredStudent = studentService.GetById(testStudent.StudentId);
            Assert.AreEqual(testStudent, recoveredStudent);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Student testStudent = testStudents[0];
            testStudent.Age = 100;
            Student updatedStudent = studentService.Update(testStudent);
            Assert.AreEqual(testStudent, updatedStudent);
        }

        [TestMethod]
        public void DeleteTest()
        {
            Student testStudent = testStudents[0];
            studentService.Delete(testStudent.StudentId);
            List<Student> students = studentService.GetAll();
            foreach (var st in students)
            {
                if (st.Equals(testStudent))
                    Assert.Fail();
            }
        }

        private List<Student> AddTestStudents()
        {
            List<Student> testStudents = new List<Student>();
            Student testStudent1 = studentService.Add(new Student("TestName1", "TestSurname1", 1));
            testStudents.Add(testStudent1);
            Student testStudent2 = studentService.Add(new Student("TestName2", "TestSurname2", 2));
            testStudents.Add(testStudent2);

            return testStudents;
        }
    }
}
