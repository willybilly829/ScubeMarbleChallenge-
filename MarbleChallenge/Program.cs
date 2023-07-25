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
        Console.WriteLine("Original List");
        foreach (Marble marble in marbleList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();

        List<Marble> filteredList = new List<Marble>();
        foreach (Marble marble in marbleList)
        {

          
            String cleanString = marble.Name.ToLower();
            char[] testArray = cleanString.ToCharArray();
            StringBuilder builder = new StringBuilder();

            foreach (char testChar in testArray)
            {
                if (char.IsLetterOrDigit(testChar))
                {
                    builder.Append(testChar);
                }
            }
            cleanString = builder.ToString();

            testArray = cleanString.ToCharArray();
            Array.Reverse(testArray);
            String reverseString = new String(testArray);

            bool isPalindrome = false;
            if (cleanString == reverseString)
            {
                isPalindrome = true;
            }

            if (marble.Weight >= 0.5 && isPalindrome == true)
            {
                filteredList.Add(marble);
            }
        }
        Console.WriteLine("filtered List");
        foreach (Marble marble in filteredList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();
    }
    else if (command == "testsort")
    {
        List<Marble> marbleList = new List<Marble>()
        {
           
            new Marble() {Id = 1, Color = "blue", Weight = 0.5, Name = "bob"},
            new Marble() {Id = 2, Color = "red", Weight = 0.4, Name = "greg"},
            new Marble() {Id = 3, Color = "violet", Weight = 0.6, Name = "Bob o'Bob"},
            new Marble() {Id = 4, Color = "indigo", Weight = 0.7, Name = "tim"},
            new Marble() {Id = 5, Color = "Orange", Weight = 0.5, Name = "patty"},
            new Marble() {Id = 6, Color = "yellow", Weight = 0.6, Name = "racecar"},
            new Marble() {Id = 7, Color = "green", Weight = 0.2, Name = "liv"},
        };

        Console.WriteLine("Original List");
        foreach (Marble marble in marbleList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();

        Dictionary<String, int> colorlookup= new Dictionary<string, int>()
        {
            {"red",1},
            {"orange",2},
            {"yellow",3},
            {"green",4},
            {"blue",5},
            {"indigo",6},
            {"violet",7}
        };

        List<Marble> sortedMarbles = marbleList.OrderBy(m => colorlookup[m.Color]).ToList();

        Console.WriteLine("Sorted List");
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




