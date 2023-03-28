using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //store the total points of the user to save in the file in menu 3 (UNDER DEVELOPMENT)
        int totalPoints = 0;

        //represents the number of each goal in the List option
        int numOfGoal = 1;

        /*will get the user prompt for a file name to load. 
        Its global because it needs to be used in option 2 as well*/
        var loadFile ="";

        //instatiate a simple goal to be used when user chooses to create a new goal
        List<Goal> goals = new List<Goal>();


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
                    var newSimpleGoal = new SimpleGoal("unknown","unknown","0", 0);                
                    newSimpleGoal.CreateGoal();
                    newSimpleGoal.GetGoal();
                    //sets user´s totalpoints as local variable to be saved in the file
                    //totalPoints += newSimpleGoal.GetTotalPoints();
                    goals.Add(newSimpleGoal);
                } 

                //if user chooses to create an eternal goal
                else if (submenuChoice == "2")
                {
                    var newEternalGoal = new EternalGoal("unknown1","unknown1","0", 0);
                    newEternalGoal.CreateGoal();
                    newEternalGoal.GetGoal();
                    //sets user´s totalpoints as local variable to be saved in the file
                    //totalPoints += newEternalGoal.GetTotalPoints();
                    goals.Add(newEternalGoal);
                }  

                else
                {
                    var newCheckListGoal = new CheckListGoal("unknown2","unknown2","3", 0);
                    newCheckListGoal.CreateGoal();
                    newCheckListGoal.GetGoal();
                    //sets user´s totalpoints as local variable to be saved in the file
                    //totalPoints += newCheckListGoal.GetTotalPoints();
                    goals.Add(newCheckListGoal);
                }
            }

            //if user chooses to list the goals, inside or outside a file
            else if (menuChoice == "2")
            {        
                numOfGoal = 1;
                foreach(Goal goal in goals)
                {
                    Console.Write($"{numOfGoal}. ");
                    goal.DisplayGoal();
                    numOfGoal += 1;
                } 
                Console.WriteLine($"\nYou have {totalPoints} points.\n");          
            }
            
            
            //if user chooses to save as file
            else if (menuChoice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputfile = new StreamWriter(fileName))
                {
                    //get total points from user and save in the file
                    outputfile.WriteLine(totalPoints);
                    foreach(Goal goal in goals)
                    {
                        outputfile.WriteLine(goal.Save());
                    }
                }
            }

            //if user chooses to load a file
            else if (menuChoice == "4")
            {                
                Console.Write("what is the name of your file? ");
                loadFile = Console.ReadLine();
                
                var loading = Goal.Load(loadFile);
                foreach(Goal goal in loading)
                {
                    goals.Add(goal);
                    totalPoints = goal.GetTotalPoints();
                }
            }
            

            //if user chooses to record an event
            else if (menuChoice == "5")
            {
                //restart the goal counting
                numOfGoal = 1;

                foreach(Goal goal in goals)
                {
                    Console.Write($"{numOfGoal}. ");
                    goal.GetGoalName();
                    numOfGoal += 1;
                }

                Console.Write("Which goal did you acomplish? ");
                string user = Console.ReadLine();
                int userInt = int.Parse(user);       

                //this is used because the userInt index is one digit ahead(dont know why) and subtracting by 1 is working.
                userInt -= 1;

                //totalPoints -= goals[userInt].GetTotalPoints();
                goals[userInt].RecordEvent();
                totalPoints += goals[userInt].GetTotalPoints();

                //displays the total points
                Console.WriteLine($"You now have {totalPoints} points");
            }
        }
    }
}