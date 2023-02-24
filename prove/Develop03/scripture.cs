using System;
using System.Collections.Generic;

class Scripture
{
   //attribute that stores a scripture
   private string _scripture;
   //attribute that stores and tracks the words of the scripture
   private List<string> _words = new List<string>();


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


   //responsible to split the words of the scripture
   public List<string> SplitWords()
   {
          foreach(var item in _scripture.Split())
          {
               _words.Add(item.ToString());    
          }
          return _words;
   }     
}
