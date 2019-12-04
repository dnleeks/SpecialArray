using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using SpecialArray.Collections;

namespace SpecialArrayTests
{
    [TestClass]
    public class SpecialArrayTest
    {
        [TestMethod]
        public void SpecialArrayWithValidIndexSpecifiedShouldReturnElement()
        {
            // Arrange
            var items = new List<int>(new []{ 1, 3, 5, 7 });
            SpecialArray.Collections.SpecialArray array = SpecialArray.Collections.SpecialArray.From(items);
            const int index = 3;
            const int expected = 7;

            // Act
            int actual = array[index];

            // Assert 
            actual.Should().Be(expected);
        }
    }
}
