using System.IO;
using System.Collections.Generic;

public class File
{   //FEEDBACK - USING PARAMETERS 
    //public Journal _journalFile = new Journal();
    //public List<Journal> _file = new List<Journal>();
    public string _fileName;


    //method to save a new Journal entry
    /*method that saves the user´s entries as a file
    prompting for the name of the file
    It is called by option: Save in the menu*/
    public void Save(List<string>entries)
    {
        
        //Console.Write(stringList);
        Console.Write("Give a name to your file: ");
        _fileName = Console.ReadLine();

        
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            
            //convert the list into string
            //I found this approach in YouTube
            //var stringList = String.Join("\n", _file.ToArray());
            //var stringList = _file;
            foreach (var item in entries)
                outputFile.WriteLine(item);
        }
    }


    //method that loads and reads a file
    //it´s called by option: Load in the menu
    public void Load()
    {
        Console.Write("Open a file: ");
        _fileName = Console.ReadLine();
        string fName = _fileName;//I HAVE TO CHANGE TO THE FILE THE USER ENTRY
        string[] lines = System.IO.File.ReadAllLines(fName);


        foreach(string line in lines)
        {
            Console.WriteLine(line);//I HAVE TO CHANGE SO IT DOES NOT PRINT ON CONSOLE. SHOULD ONLY OPEN A FILE
        }
    }
}
