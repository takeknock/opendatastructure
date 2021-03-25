using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ArrayStackTest
    {
        [TestMethod]
        public void Get()
        {
            Csharp.ArrayStack<int> arrayStack = new Csharp.ArrayStack<int>(10);
            arrayStack.Get(0);

        }
        [TestMethod]
        public void Set()
        {

        }
        [TestMethod]
        public void Add()
        {

        }
        [TestMethod]
        public void Remove()
        {

        }
    }
}
