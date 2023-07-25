using System.Security.Cryptography.X509Certificates;

namespace Marble_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMarble()
        {
            Marble marble = new Marble();
            marble.Id = 1;
            marble.Name = "Bob";
            marble.Color = "Blue";
            marble.Weight = 0.5;

            Assert.AreEqual(1, marble.Id);
            Assert.AreEqual(0.5, marble.Weight);
            Assert.AreEqual("Bob", marble.Name);
            Assert.AreEqual("Blue", marble.Color);
        }
            [TestMethod]
            public void TestClean()
            {
                String testString = "Bob o'Bob";
                String cleanString = StringHelper.CleanString(testString);
                Assert.AreEqual("bobobob", cleanString);

            }

        [TestMethod]
        public void TestReverse()
        {
            String testString = "test123";
            String reverseString = StringHelper.ReverseString(testString);
            Assert.AreEqual("321tset", reverseString);
        }
            [TestMethod]
            public void TestPal()
            {
                String trueString = "Bob O'Bob";
                String falseString = "Bob O'Bobb";
                bool isPalindrome = StringHelper.IsPalindrome(trueString);
                bool notPalindrome = StringHelper.IsPalindrome(falseString);

            Assert.IsTrue(isPalindrome);
            Assert.IsFalse(notPalindrome);



            }

        [TestMethod]
        public void TestSortAndFilter()
        {
            List<Marble> marbleList = new List<Marble>()
        {
           new Marble(){Id= 1, Color= "blue", Name= "Bob", Weight= 0.5},
           new Marble(){Id= 2, Color= "red", Name= "John Smith", Weight= 0.25},
           new Marble(){Id= 3, Color= "violet", Name= "Bob O'Bob", Weight= 0.5},
           new Marble(){Id= 4, Color= "indigo", Name= "Bob Dad-Bob", Weight= 0.75},
           new Marble(){Id= 5, Color= "yellow", Name= "John", Weight= 0.5},
           new Marble(){Id= 6, Color= "orange", Name= "Bob", Weight= 0.25},
           new Marble(){Id= 7, Color= "blue", Name= "Smith", Weight= 0.5},
           new Marble(){Id= 8, Color= "blue", Name= "Bob", Weight= 0.25},
           new Marble(){Id= 9, Color= "green", Name= "Bobb Ob", Weight= 0.75},
           new Marble(){Id= 10, Color= "blue", Name= "Bob", Weight= 0.5}
        };
     
            List<Marble> sortedMarbles = MarbleChallenge.MarbleChallenge.SortAndFilter(marbleList);

            //9 1 10 4 3 

            Assert.AreEqual(5, marbleList.Count);
            Assert.AreEqual(9, marbleList[0].Id);
            Assert.AreEqual(1, marbleList[1].Id);
            Assert.AreEqual(10, marbleList[2].Id);
            Assert.AreEqual(4, marbleList[3].Id);
            Assert.AreEqual(3, marbleList[4].Id);
        }



        }

        }

    
