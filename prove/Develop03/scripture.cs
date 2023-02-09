using System;

class Scriptures
{
    private string _scripture;
    private string _multiScripture;
    private string _reference;
    private string _multipleReference;


    //constructor for single verse scripture
    public Scriptures()
    {
        _scripture = "7. And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        _multiScripture = "";

        _reference = "1 Nephy 3:7";

        _multipleReference = "";
    }


    //constructor for multiple reference
    public Scriptures(string multiReference)
    {
         _scripture = "7. And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        _multiScripture = "8 And it came to pass that when my father had heard these words he was exceedingly glad, for he knew that I had been blessed of the Lord.";

        _reference = "1 Nephy 3:7";

        _multipleReference = "1 Nephy 3:7-8";
    }


    //getter and setter for single reference
    public string GetScriptures()
    {
        return _scripture;
    }


    public void SetScriptures()
    {
        //Word word = new Word();

        //unused
    }


    //getter and setter for multiple verse scripture
    public string GetMultipleVerses()
    {
        return $"{_multipleReference} - {_scripture} {_multiScripture}";
    }


    public void SetMultipleVerses()
    {
        //unused
    }
    



}