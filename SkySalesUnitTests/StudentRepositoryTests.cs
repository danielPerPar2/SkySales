using System;
using System.Collections.Generic;
using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SkySales.Common.Models;
using SkySales.Infrastructure.Repository;

namespace SkySalesUnitTests
{
    [TestClass]
    public class StudentRepositoryTests
    {
        private IRepository<Student> mockObject;
        private AutoMock mock;

        [TestInitialize]
        public void Setup()
        {
            mock = AutoMock.GetLoose();

            mock.Mock<IRepository<Student>>().Setup(x => x.Add(It.IsAny<Student>())).Returns<Student>(x => x);
            mock.Mock<IRepository<Student>>().Setup(x => x.GetById(It.IsAny<Int32>())).Returns(new Student());
            mock.Mock<IRepository<Student>>().Setup(x => x.GetAll()).Returns(new List<Student>());
            mock.Mock<IRepository<Student>>().Setup(x => x.Update(It.IsAny<Student>())).Returns(new Student());
            mock.Mock<IRepository<Student>>().Setup(x => x.Delete(It.IsAny<Int32>())).Returns(new Student());

            mockObject = mock.Create<IRepository<Student>>();          
        }

        [TestCleanup]
        public void CleanUp()
        {
            mock.Dispose();
        }
      
        //Without autofac       
        /*
        [TestInitialize]
        public void Setup()
        {
            var mock = new Mock<IRepository<Student>>();

            mock.Setup(x => x.Add(It.IsAny<Student>())).Returns<Student>(x => x);               
            mock.Setup(x => x.GetById(It.IsAny<Int32>())).Returns(new Student());
            mock.Setup(x => x.GetAll()).Returns(new List<Student>());
            mock.Setup(x => x.Update(It.IsAny<Student>())).Returns(new Student());
            mock.Setup(x => x.Delete(It.IsAny<Int32>())).Returns(new Student());

            mockObject = mock.Object;
        }
        */
        [TestMethod]
        public void AddTest()
        {
            Student student = new Student(1, "Test", "Test", 10);
            var result = mockObject.Add(student);
            Assert.AreEqual(result, student);          
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var result = mockObject.GetById(0);
            Assert.IsInstanceOfType(result, typeof(Student));           
        }

        [TestMethod]
        public void GetAllTest()
        {
            var result = mockObject.GetAll();
            Assert.IsInstanceOfType(result, typeof(List<Student>));            
        }

        [TestMethod]
        public void UpdateTest()
        {
            Student student = new Student(1, "Test", "Test", 10);
            var result = mockObject.Update(student);
            Assert.IsInstanceOfType(result, typeof(Student));           
        }

        [TestMethod]
        public void DeleteTest()
        {
            var result = mockObject.Delete(0);
            Assert.IsInstanceOfType(result, typeof(Student));            
        }
    }
}
