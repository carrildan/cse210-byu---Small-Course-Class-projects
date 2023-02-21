using System;
using System.Collections.Generic;

class Scripture
{
   //attribute that stores a scripture
   string _scripture;
   //attribute that stores and tracks the words of the scripture
   string[] _words;




   //constructor for a single verse scripture
   public Scripture(string scripture)
   {
        _scripture = scripture;
   }


    //constructor for multiple verses scripture
   public Scripture(string verse, string multipleVerses )
   {
    _scripture = verse + multipleVerses;
   }


   public string getScripture()
   {
     return _scripture;
   }


   public void SplitWords()
   {
          //split the letters into words
          _words = _scripture.Split(" "); 
   }

     //method to hide the word
     public List<string> HideWords()
     {

          Random rnd = new Random();
          int wordIndex = rnd.Next(0,_words.Length); 
          string rndWord = _words[wordIndex];
               
          //hides the targeted word 
          for(int i=0;i<_words.ToList().Count;i++)
          {
               if(_words[i].Contains(rndWord) && _words[i] != "---")
               {
                    _words[i] = "---";    
                    _words.ToList().RemoveAt(wordIndex);  
               }  
          } 
          return _words.ToList(); 
     }  
}
