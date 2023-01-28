using System.IO;
using System.Collections.Generic;

public class File
{   //FEEDBACK - USING PARAMETERS 
    //public Journal _journalFile = new Journal();
    //public List<Journal> _file = new List<Journal>();
    public string _fileName;
    public List<string> _newFile = new List<string>();



    //method to save a new Journal entry
    //method that saves the user´s entries as a file prompting for the name of the file. It is called by option: Save in the menu//
    //Save() parameter receives the attributes from Program class in option 4
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
            _newFile.Add(line);
        }
        

    }

    //method that displays the content in the file
    public void Display()
    {
        foreach(string line in _newFile)
        {
            Console.WriteLine(line);
        }
    }
}
