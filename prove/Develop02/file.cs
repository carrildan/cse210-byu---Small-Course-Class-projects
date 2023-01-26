using System.IO;
using System.Collections.Generic;

public class File
{
    public Journal _journalFile = new Journal();
    public List<string> _file = new List<string>();


    //method to save a new Journal entry
    /*method that saves the user´s entries as a file
    prompting for the name of the file
    It is called by option: Save in the menu*/
    public void Save()
    {
        
        //var stringList = String.Join(",", Display().ToArray());
        //Console.Write(stringList);
        Console.Write("Give a name to your file: ");
        string fileName = Console.ReadLine();

        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //convert the list into string
            //I found this approach in YouTube
            var stringList = String.Join("\n", _entry.ToArray());//I NEED TO GET ACCESS TO THE _entry variable in Journal
            outputFile.WriteLine( stringList);
        }
    }


    //method that loads and reads a file
    //it´s called by option: Load in the menu
    public void Load()
    {
        string fName = "teste.txt";//I HAVE TO CHANGE TO THE FILE THE USER ENTRY
        string[] lines = System.IO.File.ReadAllLines(fName);


        foreach(string line in lines)
        {
            Console.WriteLine(line);//I HAVE TO CHANGE SO IT DOES NOT PRINT ON CONSOLE. SHOULD ONLY OPEN A FILE
        }
    }
}
