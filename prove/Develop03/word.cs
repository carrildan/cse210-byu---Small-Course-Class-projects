using System;
using System.Collections.Generic;

//this class is responsible for hidden words and display the scripture
class Word
{ 
    //receives a word from Scripture
    private List<string> _word = new List<string>();
    //stores and tracks the words that are hidden.
    private string _hiddenWords = " ";


    //sets the attributes 
    public Word(List<string> words)
    {
        //receives the hidden words from Scripture class
        foreach(string item in words)
        {
            _word.Add(item);
            _word.ToString();            
        }
    }


    //generates random words and return it
     public string RandomWord()
     {
          //generates random words in the scripture
          Random rnd = new Random();
          int wordIndex = rnd.Next(0,_word.Count); 
          string rndWord = _word[wordIndex];
          

          while(rndWord == _hiddenWords || rndWord == "---")
          {
            wordIndex = rnd.Next(0,_word.Count);
            rndWord = _word[wordIndex];
          }
          return rndWord;
     }  


    //hides the words received from RandomWord()
    public void HideWords()
    {
        string randomWord = RandomWord();
        for(int i=0;i<_word.ToList().Count;i++)
        {
            if (_word[i] == randomWord && _word[i] != "---")
            {
                _word[i] = "---";
            }
        }
    }

    
    public void Display()
    {
        foreach(string word in _word)
        {
            Console.Write($"{word} ");
        }        
    }    


    public bool EndGame()
    {
        bool statment = _word.All(val => val == "---");
        if(statment == true)
            return true;
        return false;
    }    
}