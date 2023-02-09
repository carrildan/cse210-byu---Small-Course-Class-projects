using System;
using System.Collections.Generic;

//this class is responsible for hidden words and display the scripture
class Word
{
    private Scriptures _scripture;
    //private string _hiddenWords;
    private List<string> _hiddenWords;


    //constructor
    public Word()
    {
        _scripture = new Scriptures();
        _hiddenWords = new List<string>();
        
    }


    //method to hidden the words 
    public void ToHidden()
    {
        //call random method
        Random rnd = new Random();

        string scripture = _scripture.GetScriptures();
        string[] splitWords = scripture.Split(" ");
        foreach(var item in string.Join(" ",splitWords))
        {
            _hiddenWords.Add(item.ToString());
            
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