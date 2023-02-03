using System;

class Scriptures
{
    string _scripture;
    string _multiScripture;
    string _reference;
    string _multipleReference;


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
    }


    //getter and setter for single reference
    public void GetScriptures()
    {

    }


    public void SetScriptures()
    {

    }


    //getter and setter for multiple verse scripture
    public void GetMultipleVerses()
    {

    }


    public void SetMultipleVerses()
    {
        
    }
    



}