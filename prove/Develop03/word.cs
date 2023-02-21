using System;
using System.Collections.Generic;

//this class is responsible for hidden words and display the scripture
class Word
{ 
    //receives a word from Scripture
    private List<string> _word = new List<string>();
    //stores and tracks the words that are hidden.
    private List<string> _hiddenWords = new List<string>();


    //sets the attributes 
    public Word(List<string> words)
    {
        //receives the hidden words from Scripture class
        _word = words;
    }


    //add the words that came from scripture class and store it to a list
    public void ReceiveWords()
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
            Console.Write(word);
        }        
    }
        
}