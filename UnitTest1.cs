using Microsoft.VisualStudio.TestTools.UnitTesting;
using Final_Project;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateNode_WithData_DataSaved_True()
        {
            //Arrange
            double data = 1.01;
            Node<double> node = new Node<double>(data);

            //Assert
            Assert.AreEqual(1.01, node.data);
        }

        [TestMethod]
        public void Enqueue_DataSaved_True()
        {
            //Arrange
            Queue<string> l = new Queue<string>();

            //Act
            l.enqueue(new Node<string>("Hello"));
            l.enqueue(new Node<string>("World\n"));

            //Assert
            StringAssert.Equals("Hello", l.getNode(0));
        }

        [TestMethod]
        public void Dequeue_DataSaved_True()
        {
            //Arrange
            Queue<string> l = new Queue<string>();

            //Act
            l.enqueue(new Node<string>("Hello"));
            l.enqueue(new Node<string>("World\n"));

            //Assert
            StringAssert.Equals("World", l.getNode(0));
        }

        [TestMethod]
        public void RunMap_AddFunction_True()
        {
            //Arrange
            int AddTwo(int value)
            {
                return value + 2;
            }
            int data = 1;
            Node<int> node = new Node<int>(data);
            Node<int> result = new Node<int>(0);
            Map<int> mymap = new Map<int>(node, AddTwo, result);

            //Act
            Node<int> final_result = mymap.run();

            //Assert
            Assert.AreEqual(3, final_result.data);
        }
    }
}
