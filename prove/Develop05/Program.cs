using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //its benn called here to be used to load a file in menu 4
        var newSimpleGoal = new SimpleGoal("unknown","unknown","0", 100);                

        //instatiate a simple goal to be used when user chooses to create a new goal
        List<Goal> goals = new List<Goal>();


        //store the total points of the user to save in the file in menu 3
        int totalPoints = 1;
        
        
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
                    //var newSimpleGoal = new SimpleGoal("unknown","unknown","0", 100);                
                    newSimpleGoal.CreateGoal();
                    newSimpleGoal.SetListOfGoal();
                    //sets user´s totalpoints as local variable to be saved in the file
                    totalPoints += newSimpleGoal.GetTotalPoints();
                    goals.Add(newSimpleGoal);
                } 

                //if user chooses to create an eternal goal
                else if (submenuChoice == "2")
                {
                    var newEternalGoal = new EternalGoal("unknown1","unknown1","1", 0);
                    newEternalGoal.CreateGoal();
                    newEternalGoal.SetListOfGoal();
                    //sets user´s totalpoints as local variable to be saved in the file
                    totalPoints += newEternalGoal.GetTotalPoints();
                    goals.Add(newEternalGoal);
                }  

                else
                {
                    var newCheckListGoal = new CheckListGoal("unknown2","unknown2","3", 0);
                    newCheckListGoal.CreateGoal();
                    newCheckListGoal.SetListOfGoal();
                    //sets user´s totalpoints as local variable to be saved in the file
                    totalPoints += newCheckListGoal.GetTotalPoints();
                    goals.Add(newCheckListGoal);
                }
            }

            //if user chooses to list the goals
            else if (menuChoice == "2")
            {
                
                /*if(goals == null)
                {
                    Console.Write(newSimpleGoal.GoalFromFile());
                }*/

                foreach(Goal goal in goals)
                {
                    goal.DisplayListOfGoal();
                }       
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
                var loadFile = Console.ReadLine();
                
                newSimpleGoal.Load(loadFile);
            }
        }
    }
}