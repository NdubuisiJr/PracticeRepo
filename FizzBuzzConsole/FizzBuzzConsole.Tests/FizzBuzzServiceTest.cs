// <copyright file="FizzBuzzServiceTest.cs">Copyright ©  2015</copyright>

using System;
using FizzBuzzConsole.Model;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzConsole.Model.Tests
{
    [TestClass]
    [PexClass(typeof(FizzBuzzService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FizzBuzzServiceTest
    {

        [PexMethod]
        public string FormatNumber([PexAssumeUnderTest]FizzBuzzService target, int candidate)
        {
            string result = target.FormatNumber(candidate);
            return result;
            // TODO: add assertions to method FizzBuzzServiceTest.FormatNumber(FizzBuzzService, Int32)
        }
    }
}
