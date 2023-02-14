using System;

class Scripture
{
   //attribute that stores a scripture
   string _scripture;

   //attribute that stores and tracks the words of the scripture
   string _words;


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


   //method to hide the word
   public void HideWords()
   {
        
   }
}


