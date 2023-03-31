namespace LabSLL
{
    public class Tests
    {
        private LinkedList sll;

        [SetUp]
        public void Setup()
        {
            sll = new LinkedList();
        }

        [Test]
        public void TestPrepending()
        {
            string name = "Joe Blow";

            sll.AddFirst(name);

            // Assert that it was added or the SLL is bigger
            Assert.IsNotNull(sll.Head);

            Assert.AreEqual(1, sll.Count);

            Assert.AreNotEqual(0, sll.Count);

            // Assert that the first node value is "Joe Blow"
            Node first = sll.Head;

            string value = first.Value;
            Assert.AreEqual(name, value);

            // Assert there's no next of first node
            Assert.IsNull(first.Next);

        }

        [Test]
        public void TestPrependingToNonEmptyList()
        {
            string firstNameAdded = "Joe Blow";
            string secondNameAdded = "John Smith";
            sll.AddFirst(firstNameAdded);
            sll.AddFirst(secondNameAdded);

            Node nameAddedLast = sll.Head;
            string value = nameAddedLast.Value;

            Assert.AreEqual(secondNameAdded, value);
            Assert.AreNotEqual(firstNameAdded, value);


        }

        [Test]
        public void TestAppending()
        {
            string firstName = "Joe Schmoe";
            string secondName = "John Smith";
            sll.AddLast(firstName);
            sll.AddLast(secondName);

            Node node = sll.Head;

            while (node.Next != null)
            {
                node = node.Next;
            }

            string value = node.Value;
        
            Assert.AreEqual(secondName, value);
            Assert.AreNotEqual("Joe Blow", value);
            Assert.AreEqual(2, sll.Count);
        }


        [Test]
        public void TestRemoveFirst()
        {
            string firstName = "Joe Blow";
            string secondName = "Joe Schmoe";
            string thirdName = "John Smith";
            string fourthName = "Jane Doe";

            sll.AddLast(firstName);
            sll.AddLast(secondName);
            sll.AddLast(thirdName);
            sll.AddLast(fourthName);

            sll.RemoveFirst();

            Assert.AreEqual(3, sll.Count);

            Node node = sll.Head;

            string value = node.Value;

            Assert.AreEqual(secondName, value);
            Assert.AreNotEqual(firstName, value);

        }

        [Test]
        public void TestRemoveLast()
        {
            string firstName = "Joe Blow";
            string secondName = "Joe Schmoe";
            string thirdName = "John Smith";
            string fourthName = "Jane Doe";

            sll.AddLast(firstName);
            sll.AddLast(secondName);
            sll.AddLast(thirdName);
            sll.AddLast(fourthName);

            sll.RemoveLast();

            Assert.AreEqual(3, sll.Count);

            Node node = sll.Head;

            while (node.Next != null)
            {
                node = node.Next;
            }

            string value = node.Value;

            Assert.AreEqual(thirdName, value);
            Assert.AreNotEqual(fourthName, value);
        }

        [Test]
        public void TestRetriveValueAtIndex()
        {
            string firstName = "Joe Blow";
            string secondName = "Joe Schmoe";
            string thirdName = "John Smith";
            string fourthName = "Jane Doe";

            sll.AddLast(firstName);
            sll.AddLast(secondName);
            sll.AddLast(thirdName);
            sll.AddLast(fourthName);

            string value = sll.GetValue(2);

            Assert.AreEqual(thirdName, value);
            Assert.AreNotEqual(secondName, value);

        }

        [Test]
        public void TestSizeOfList()
        {
            string firstName = "Joe Blow";
            string secondName = "Joe Schmoe";
            string thirdName = "John Smith";
            string fourthName = "Jane Doe";

            sll.AddLast(firstName);
            sll.AddLast(secondName);
            sll.AddLast(thirdName);
            sll.AddLast(fourthName);

            ulong value = sll.Count;

            Assert.AreEqual(4, value);
            Assert.AreNotEqual(3, value);

        }

        [TearDown]
        public void Teardown()
        {
            //sll.Clear();
            sll.Head = null;
            sll.Count = 0;
        }
    }
}