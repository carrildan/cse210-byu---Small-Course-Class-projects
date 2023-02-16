using System;
using System.Collections.Generic;

//this class is responsible for hidden words and display the scripture
class Word
{ 
    //receives a word from Scripture
    string[] _word;

    //stores and tracks the words that are hidden.
    List<string> _hiddenWords = new List<string>();


    //sets the attributes 
    public Word(string[] words)
    {
        //receives the hidden words from Scripture class
        _word = words;
    }


    //returns true or false for a hidden word
    public void IsHidden()
    {
        //adds the hidden words to the list
        foreach(string item in _word)
        {
            _hiddenWords.Add(item);

        }
    
    }
    public void Display()
    {
        foreach(string word in _hiddenWords)
        {
        Console.Write($"{word}");
        }
    }
        
}