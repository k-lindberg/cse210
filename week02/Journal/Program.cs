//Exceeding Requirements:
//I added a mood indicator as part of the journal entry. The user can write their mood, it saves to the file and will display when the user selects Display.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        string input;

        do
        {
            Console.Write("Welcome to the Journal Program! \nPlease select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do?  ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Entry newEntry = new Entry();
                journal.AddEntry(newEntry);
            }

            else if (input == "2")
            {
                journal.DisplayAll();
            }

            else if (input == "3")
            {
                journal.LoadFromFile("");
            }
            
            else if (input == "4")
            {
                journal.SaveToFile("");
            }

        } while (input != "5");
    }
}