using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpTutorial.Tests;

namespace CSharpTutorial

{
    [TestClass()]
    class PetUnitTest
    {

        // unit test code  
        [TestMethod()]
        public void barkTest01()
        {
            Person owner0 = new Person();
            Dog ginger = new Dog("Ginger", owner0, 15, 30);
            
            var bark00 = "woof";
            
            // act  
            ginger.bark();

            // assert  
            testOutput(bark00, ginger);
        }


        // unit test code  
        [TestMethod]
        public void barkTest02()
        {
            // arrange
            List<string> volumes = new List<string>();
            List<string> woofs = new List<string>();
            /*
            IDictionary<int,string> volumesDict = new Dictionary<int,string>();
            volumesDict.Add(0, "silent");
            volumesDict.Add(1, "quiet");
            volumesDict.Add(2, "loud");
            volumesDict.Add(3, "veryloud");
            */
            volumes.Add("silent");
            volumes.Add("quiet");
            volumes.Add("loud");
            volumes.Add("veryloud");

            woofs.Add("...");
            woofs.Add("woof");
            woofs.Add("Woof!");
            woofs.Add("WOOF");

            Person owner0 = new Person();
            Dog ginger = new Dog("Ginger", owner0, 15, 30);
            

            for (int i = 0; i < 4; i++)
            {
                // action
                ginger.bark(i);
                // assert
                testOutput(woofs[i], ginger); 
            }
        }

        [TestMethod()]
        public void testOutput(string bark00, Dog dog)
        {
            string currentConsoleOut = Console.Out.ToString();
            using (var consoleOutput = new ConsoleOutput())
            {
                Assert.AreEqual(bark00, consoleOutput.GetOuput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

    }
}
    