using CoffeeMachine;
using Xunit;
using System;

namespace CoffeeMachineTests
{
    public class ConteinerTest
    {
        [Fact]
        public void ContainerCapacitySet_Success()
        {
            // - Arrange
            const int expectedCapacity = 1000;
            var container = new Container(expectedCapacity);
            // - Actt
            var actualCapacity = container.Capacity;
            // - Assert
            Assert.Equal(expectedCapacity, actualCapacity);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(3001)]
        public void ContainerInvalidCapacity_ThrowsException(int capacity)
        {
            // - Act+Assert
            Assert.Throws<ArgumentException>(() => new Container(capacity));

        }

        [Fact]
        public void ContainerResourceCheck()
        {
            const int expectedCapacity = 1000;
            var container = new Container(expectedCapacity);
            container.LoadResource(250);
            Assert.Equal(250, container.getResourseLevel());
            container.TakeResource(100);
            Assert.Equal(150, container.getResourseLevel());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(1001)]
        public void ContainerLoadResours_ThrowsException(int resource)
        {
            const int expectedCapacity = 1000;
            var container = new Container(expectedCapacity);
            Assert.Throws<ArgumentException>(() => container.LoadResource(resource));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(251)]
        public void ContainerTakeResours_ThrowsException(int resource)
        {
            const int expectedCapacity = 1000;
            var container = new Container(expectedCapacity);
            container.LoadResource(250);
            Assert.Throws<ArgumentException>(() => container.TakeResource(resource));
        }
    }
}