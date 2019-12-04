using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecialArray.Collections;

namespace SpecialArrayTests
{
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

        [TestMethod]
        public void SortArrayWithThreeElementsShouldSortTheArray()
        {
            // Arrange
            var items = new List<int>(new[] { 2, 3, 1 });
            SpecialArray.Collections.SpecialArray array = SpecialArray.Collections.SpecialArray.From(items);
            var expectedItems = new List<int>(new[] { 1, 2, 3 });

            // Act
            ArrayActions.Sort(array);

            // Assert 
            array.Items.Should().BeEquivalentTo(expectedItems);

        }

        [TestMethod]
        public void SortArrayWithManyElementsShouldSortTheArray()
        {
            // Arrange
            var items = new List<int>(new[] { 7, 8, -2, 6, 2, 3, 1 });
            SpecialArray.Collections.SpecialArray array = SpecialArray.Collections.SpecialArray.From(items);
            var expectedItems = new List<int>(new[] { -2, 1, 2, 3, 6, 7, 8 });

            // Act
            ArrayActions.Sort(array);

            // Assert 
            array.Items.Should().BeEquivalentTo(expectedItems);

        }
    }
}