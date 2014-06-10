using System;
using NUnit.Framework;
using RestSharp;
using UnleashedApi.Services;

namespace UnleashedApi.Tests
{
    [TestFixture]
    public class RestClientExtensions
    {
        [TestCase]
        public void ExtractPropertiesFromObject()
        {
            //Arrange
            var source = new { prop1 = "val1", prop2 = "val2", prop3 = "val3" };
            var request = new RestRequest();

            //Act
            request.AddParameters(source);

            //Assert
            Assert.AreEqual("prop1", request.Parameters[0].Name);
            Assert.AreEqual("val1", request.Parameters[0].Value);
            Assert.AreEqual("prop2", request.Parameters[1].Name);
            Assert.AreEqual("val2", request.Parameters[1].Value);
            Assert.AreEqual("prop3", request.Parameters[2].Name);
            Assert.AreEqual("val3", request.Parameters[2].Value);
        }

        [TestCase]
        public void ExtractPropertiesFromObjectNullableTypes()
        {
            //Arrange
            var source = new { prop1 = new Int32?(), prop2 = new Int32?(), prop3 = 32 };
            var request = new RestRequest();

            //Act
            request.AddParameters(source);

            //Assert
            Assert.AreEqual("prop3", request.Parameters[0].Name);
            Assert.AreEqual("32", request.Parameters[0].Value);
        }
    }
}
