using System;
using System.Collections.Generic;
using System.Text;
using BCUnit.Framework.SDK;

namespace TestingUser
{

    [TestClass]
    public class TestCase1
    {

        [BeforeAllTests]
        public void Initialize()
        {
            Console.WriteLine("Launching initializer...");
        }
        [TestMethod(Order = 1)]
        public void TestMethod1()
        {
            Console.WriteLine("Running method 1");
        }


        [TestMethod(Order = 3)]
        public void TestMethod2()
        {
            Console.WriteLine("Running method 2");
        }


        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("Running method 3");
        }


        [TestMethod]
        public void TestMethod4()
        {
            Console.WriteLine("Running method 4");
        }

        [TestMethod(Order = 2)]
        public void TestMethod5()
        {
            Console.WriteLine("Running method 5");
        }



        [AfterAllTests]
        public void CleanResouces()
        {
            Console.WriteLine("Launching CleanRescouces...");
        }
    }
}
