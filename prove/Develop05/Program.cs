using System;

class Program
{
    static void Main(string[] args)
    {
        //displays main menu
        Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
        Console.Write("Select a choice from the menu: ");
        string menuChoice = Console.ReadLine();

        //if user chooses to create a new goal
        if (menuChoice == "1")
        {
            //submenu for 3 different types of goals
            Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
            
            Console.Write("Which type of goal would you like to create? ");
            string submenuChoice = Console.ReadLine();


            if (submenuChoice == "1")
            {
                //
            }
        }

    }
}