using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //render a welcome message and prompts for user´s name
        Console.WriteLine("Welcome to the Journal Program!");
        Console.Write("Please, inform your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Please select one of the following choices:");
      

        //creates a new journal and file(because if creates inside a conditional block I won´t have access in another block of the conditional)
        Journal journal1 = new Journal();
        File file1 = new File();


        //mantain prompting user for a option until chooses to exit
        int userInt = -1;
        while (userInt != 5)
        {
            //menu options
            string menu = ("1. Write \n2. Display \n3. Load \n4. Save\n5. Quit");
            Console.WriteLine(menu);

            //user entry the option
            Console.Write($"What would you like to do {userName}? ");
            string user = Console.ReadLine();
            userInt = int.Parse(user);


            /* ---------------  menu conditional ----------------- */

            //check true or false to know what wil be displayed in option 2
            bool displayCheck = file1._newFile.Any();
            
            //Option 1 - Write a new journal
            if (userInt == 1)
            {
                journal1.Prompt();
                journal1.Entries();
            }


            //Option 2 - Display the current journal or display from a file
            else if (userInt == 2)
            {
                if (displayCheck == false)
                {
                    journal1.Display();
                }
                else
                {
                    //displays the file entries
                    file1.Display();
                }
            }


            //Option 4 - Saves to a txt file
            else if (userInt == 4)
            {
                file1.Save(journal1._entry);
            }


            //Option 3 - Load a file
            else if (userInt == 3)
            {
                file1.Load();
            }
            
        }   
        Console.Write($"See you tomorrow, {userName}");
    }
}