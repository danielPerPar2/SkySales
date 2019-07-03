using System;
using System.Collections.Generic;
using Integration.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkySales.Business.Logic;
using SkySales.Common.Models;
using SkysalesIntegrationTests.Modules;

namespace SkysalesIntegrationTests
{
    [TestClass]
    public class StudentBusinessLogicTests : IoCSupportedTest<TestModule>
    {
        private IBusinessLogic<Student> studentBusinessObject;
        private List<Student> testStudents = new List<Student>();

        [TestInitialize]
        public void Setup()
        {
            studentBusinessObject = Resolve<IBusinessLogic<Student>>();
            testStudents = AddTestStudents();
        }

        [TestCleanup]
        public void CleanUp()
        {
            studentBusinessObject = null;
            ShutdownIoC();
        }

        [TestMethod]
        public void AddTest()
        {
            Student student = new Student("Elisa", "Gómez", 64);
            Student addedStudent = studentBusinessObject.Add(student);
            student.StudentId = addedStudent.StudentId;
            Assert.AreEqual(student, addedStudent);
        }

        [TestMethod]
        public void GetAllTest()
        {
            List<Student> studentList;
            studentList = studentBusinessObject.GetAll();
            Assert.IsInstanceOfType(studentList, typeof(List<Student>));

        }

        [TestMethod]
        public void GetByIdTest()
        {
            Student testStudent = testStudents[0];
            Student recoveredStudent = studentBusinessObject.GetById(testStudent.StudentId);
            Assert.AreEqual(testStudent, recoveredStudent);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Student testStudent = testStudents[0];
            testStudent.Age = 100;
            Student updatedStudent = studentBusinessObject.Update(testStudent);
            Assert.AreEqual(testStudent, updatedStudent);
        }

        [TestMethod]
        public void DeleteTest()
        {
            Student testStudent = testStudents[0];
            studentBusinessObject.Delete(testStudent.StudentId);
            List<Student> students = studentBusinessObject.GetAll();
            foreach (var st in students)
            {
                if (st.Equals(testStudent))
                    Assert.Fail();
            }
        }

        private List<Student> AddTestStudents()
        {
            List<Student> testStudents = new List<Student>();
            Student testStudent1 = studentBusinessObject.Add(new Student("TestName1", "TestSurname1", 1));
            testStudents.Add(testStudent1);
            Student testStudent2 = studentBusinessObject.Add(new Student("TestName2", "TestSurname2", 2));
            testStudents.Add(testStudent2);

            return testStudents;
        }
    }
}
