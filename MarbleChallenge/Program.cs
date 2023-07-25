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
        String cleanString = testString.ToLower();
        char[] testArray = testString.ToCharArray();
        StringBuilder builder = new StringBuilder();

        foreach (char testChar in testArray)
        {
            if (char.IsLetterOrDigit(testChar))
            {
                builder.Append(testChar);
            }
        }
        cleanString = builder.ToString();

        Console.WriteLine("Input: " + testString + ", Output: " + cleanString);
    }
    else if (command == "testpal")
    {
        String testString = "bob";
        char[] testArray = testString.ToCharArray();
        Array.Reverse(testArray);
        String reverseString = new String(testArray);

        bool isPalindrome = false;
        if (testString == reverseString)
        {
            isPalindrome = true;
        }


        Console.WriteLine("Input: " + testString + ", Output: " + reverseString + ", Palindrome: " + isPalindrome);
    }





    else if (command == "testfilter")
    {
        List<Marble>  marbleList = new List<Marble>()
        {
            new Marble() {Id = 1, Color = "blue", Weight = 0.5, Name = "bob"},
            new Marble() {Id = 2, Color = "red", Weight = 0.4, Name = "greg"},
            new Marble() {Id = 3, Color = "violet", Weight = 0.6, Name = "sam"},
        };

        foreach (Marble marble in marbleList)
        {
            Console.WriteLine(marble);
        }
    }
    else if (command != "exit")
    {
        Console.WriteLine("Unknown command, please try again");


    }

}




