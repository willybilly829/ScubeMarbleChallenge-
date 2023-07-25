using MarbleChallenge;
using System.ComponentModel.Design;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

String command = "";

while (command != "exit")
{
    Console.WriteLine("Enter Command");
    command = Console.ReadLine().ToLower();
    Console.WriteLine("you entered" + command);

    if (command == "test")
    {

    }
    else if (command == "testmarble")
    {
        Marble marble = new Marble();
        marble.Id = 1;
        marble.Name = "Bob";
        marble.Color = "Blue";
        marble.Weight = 0.5;

        Console.WriteLine(marble);


    }
    else if (command == "testclean")
    {
        String testString = "Bob o'Bob";
        String cleanString = StringHelper.CleanString(testString);
        Console.WriteLine("Input: " + testString + ", Output: " + cleanString);
    }
    else if (command == "testreverse")
    {
        String testString = "test123";
        String reverseString = StringHelper.ReverseString(testString);
        Console.WriteLine("Input: " + testString + ", Output: " + reverseString);
    }
    else if (command == "testpal")
    {
        String testString = "bob";
       

        bool isPalindrome = StringHelper.IsPalindrome(testString);
        Console.WriteLine("Input: " + testString + ", Palindrome: + " + isPalindrome);
    }





   
    
    else if (command == "testsortandfilter")
    {

        //filter


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
        Console.WriteLine("Original List");
        foreach (Marble marble in marbleList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();







        List<Marble> sortedMarbles = MarbleChallenge.MarbleChallenge.SortAndFilter(marbleList);

        Console.WriteLine("Sorted and Filteted List");
        foreach (Marble marble in sortedMarbles)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();



    }






    else if (command != "exit")
    {
        Console.WriteLine("Unknown command, please try again");


    }

}
