namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private int initialLength;
        private Database database;

        [SetUp]
        public void Initialize()
        {
            database = new Database(3, 3);
            initialLength = database.Count;
        }

        [Test]
        public void When_AddMethodIsCalled_Element_ShouldBeAdded()
        {
            database.Add(3);
            Assert.AreNotSame(database.Count, initialLength);
        }

        [Test]
        [TestCase(new int[] { 16, 19, 1, 2, 5, 16, 19, 1, 2, 5, 16, 19, 1, 2, 5, 3 })]
        public void When_DatabaseIsFull_AndAddMethodIsCalled_Exception_ShouldBeThrown(int[] array)
        {
            database = new Database(array);

            TestDelegate testDelegate = () =>
            {
                database.Add(3);
            };

            Assert.Throws<InvalidOperationException>(testDelegate);
        }

        [Test]
        public void When_RemoveMethodIsCalled_ShouldRemoveElementAtTheLastIndex()
        {
            database.Remove();
            Assert.AreNotEqual(database.Count, initialLength);
        }

        [Test]
        public void When_DatabaseIsEmpty_AndRemoveMethodIsCalled_Exception_ShouldBeThrown()
        {
            database.Remove();
            database.Remove();
            TestDelegate testDelegate = () =>
            {
                database.Remove();
            };

            Assert.Throws<InvalidOperationException>(testDelegate);
        }

        [Test]
        public void When_FetchMethodIsCalled_ElementsAsAnArray_ShouldBeReturned()
        {
            int[] array = database.Fetch();

            Assert.IsTrue(array.Length > 0);
        }
    }
}