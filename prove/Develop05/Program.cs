using System;

class Program
{
    static void Main(string[] args)
    { 
        //instatiate a simple goal for when user chooses to create or list goals
        List<Goal> goals = new List<Goal>();
        goals.Add(new SimpleGoal("unknown","unknown","0"));

        //displays menu as long the user does not quit the program
        string menuChoice = "";
        while (menuChoice != "6")
        {
            //displays main menu
            Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();
        

            //if user chooses to create a new goal
            if (menuChoice == "1")
            {
                //submenu for 3 different types of goals
                Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
                
                Console.Write("Which type of goal would you like to create? ");
                string submenuChoice = Console.ReadLine();

                //if user chooses to create a new simple goal
                if (submenuChoice == "1")
                {
                    foreach(Goal goal in goals)
                    {
                        goal.CreateGoal();
                        goal.SetListOfGoal();
                    }
                } 

            } else if (menuChoice == "2")
            {
                foreach(Goal goal in goals)
                    goal.DisplayListOfGoal();
            }
        }

    }
}