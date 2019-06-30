using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SkySales.Web.Services;

namespace SkySalesUnitTests
{
    [TestClass]
    public class StudentWebServiceTest
    {
        private IStudentWebService mockObject;

        [TestInitialize]
        public void Setup()
        {
            var mock = new Mock<IStudentWebService>();

            mock.Setup(x => x.Add(It.IsAny<StudentWS>())).Returns<StudentWS>(x => x);
            mock.Setup(x => x.GetById(It.IsAny<Int32>())).Returns(new StudentWS());
            mock.Setup(x => x.GetAll()).Returns(new List<StudentWS>());
            mock.Setup(x => x.Update(It.IsAny<StudentWS>())).Returns(new StudentWS());
            mock.Setup(x => x.Delete(It.IsAny<Int32>())).Returns(new StudentWS());

            mockObject = mock.Object;
        }

        [TestMethod]
        public void AddTest()
        {
            StudentWS student = new StudentWS(1, "Test", "Test", 10);
            var result = mockObject.Add(student);
            Assert.AreEqual(result, student);
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var result = mockObject.GetById(0);
            Assert.IsInstanceOfType(result, typeof(StudentWS));
        }

        [TestMethod]
        public void GetAllTest()
        {
            var result = mockObject.GetAll();
            Assert.IsInstanceOfType(result, typeof(List<StudentWS>));
        }

        [TestMethod]
        public void UpdateTest()
        {
            var result = mockObject.Update(new StudentWS());
            Assert.IsInstanceOfType(result, typeof(StudentWS));
        }

        [TestMethod]
        public void DeleteTest()
        {
            var result = mockObject.Delete(0);
            Assert.IsInstanceOfType(result, typeof(StudentWS));
        }

    }
}
