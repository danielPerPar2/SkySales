using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SkySales.Common.Models;
using SkySales.Web.Services;
using SkySales.Web.Services.Utilities;

namespace SkySalesUnitTests
{
    [TestClass]
    public class MapperTest
    {
        private IMapper<Student, StudentWS> mockObject;

        [TestInitialize]
        public void Setup()
        {
            var mock = new Mock<IMapper<Student, StudentWS>>();

            mock.Setup(x => x.Map(It.IsAny<Student>())).Returns(new StudentWS());
            mock.Setup(x => x.Map(It.IsAny<List<Student>>())).Returns(new List<StudentWS>());
            mock.Setup(x => x.Map(It.IsAny<StudentWS>())).Returns(new Student());
            mock.Setup(x => x.Map(It.IsAny<List<StudentWS>>())).Returns(new List<Student>());

            mockObject = mock.Object;
        }

        [TestMethod]
        public void MapStudentToStudentWS_Test()
        {
            var result = mockObject.Map(new Student());
            Assert.IsInstanceOfType(result, typeof(StudentWS));
        }

        [TestMethod]
        public void MapListStudentToListStudentWS_Test()
        {
            var result = mockObject.Map(new List<Student>());
            Assert.IsInstanceOfType(result, typeof(List<StudentWS>));
        }

        [TestMethod]
        public void MapStudentWSToStudent_Test()
        {
            var result = mockObject.Map(new StudentWS());
            Assert.IsInstanceOfType(result, typeof(Student));
        }

        [TestMethod]
        public void MapListStudentWSToListStudent_Test()
        {
            var result = mockObject.Map(new List<StudentWS>());
            Assert.IsInstanceOfType(result, typeof(List<Student>));
        }
    }
}