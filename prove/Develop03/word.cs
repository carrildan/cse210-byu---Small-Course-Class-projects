using System;
using System.Collections.Generic;

//this class is responsible for hidden words and display the scripture
class Word
{ //TO DO: CHANGING THE _SCRITPURE ATTRIBUTE TO RECEIVE A STRING, THEN CREATE A NEW LIST TO STORE THE WORDS.
    private string _scripture;
    //private string _hiddenWords;
    private List<string> _hiddenWords;


    //constructor
    public Word()
    {
        List<string> _scripture = new List<string>();
        _hiddenWords = new List<string>();
        
    }


    //method to hidden the words 
    public void ToHidden()
    {
        //call random method
        Random rnd = new Random();

        //get scripture and split into words
        string scripture = _scripture.GetScriptures();
        string[] splitWords = scripture.Split("");

        //add each word to the list
        foreach(var item in splitWords)
        {
            _hiddenWords.Add(item);
        }

        
        foreach(string item in _hiddenWords)
        {
            Console.Write(item);
        }

    }





    //method to display a single verse scripture
    public void Display()
    {
        
        //Console.Write(_hiddenWords);
    }


    //method to display a multiple verse scripture
    public void DisplayMultipleVerse()
    {
        
    }





}