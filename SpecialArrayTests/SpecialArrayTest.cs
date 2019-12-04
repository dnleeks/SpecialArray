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

        [TestMethod]
        public void SpecialArrayShouldReturnSize()
        {
            // Arrange
            var items = new List<int>(new[] { 1, 3, 5, 7 });
            SpecialArray.Collections.SpecialArray array = SpecialArray.Collections.SpecialArray.From(items);
            const int expected = 4;

            // Act
            int actual = array.Size();

            // Assert 
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void SpecialArrayShouldSwapElements()
        {
            // Arrange
            var items = new List<int>(new[] { 1, 3, 5, 7 });
            SpecialArray.Collections.SpecialArray array = SpecialArray.Collections.SpecialArray.From(items);
            var expectedItems = new List<int>(new[] { 5, 3, 1, 7 });
            const int swapIndex = 2;

            // Act
            array.Swap(swapIndex);

            // Assert 
            array.Items.Should().BeEquivalentTo(expectedItems);
        }
    }

    [TestClass]
    public class ArrayActionsTest
    {
        [TestMethod]
        public void SortArrayWithTwoElementsShouldSortTheArray()
        {
            // Arrange
            var items = new List<int>(new[] { 3,1 });
            SpecialArray.Collections.SpecialArray array = SpecialArray.Collections.SpecialArray.From(items);
            var expectedItems = new List<int>(new[] { 1,3});

            // Act
            ArrayActions.Sort(array);

            // Assert 
            array.Items.Should().BeEquivalentTo(expectedItems);

        }
    }
}
