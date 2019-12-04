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
    }
}