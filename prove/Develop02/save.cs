using System.Collections.Generic;

public class Save
{
    public Journal _journalFile = new Journal();


    //method to save a new Journal entry
    public List<string> saveFile()
    {
        List<string> file = _journalFile._entry;
        return file;
    }


    //method to hold the file
    public void file()
    {
        List<string> file1 = saveFile();
    }
}


