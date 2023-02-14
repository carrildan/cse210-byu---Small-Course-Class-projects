using System;
using System.Collections.Generic;

class Scripture
{
   //attribute that stores a scripture
   string _scripture;

   //attribute that stores and tracks the words of the scripture
   List<string> _words = new List<string>();


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
        //split the letters into words
        string[] words = _scripture.Split(" ");

        //adding each word of the scripture into to the list so it can hide it. I WASN´T ABLE TO HANDLE HIDDING PROCESS WITHOUT ADDING IT TO A LIST.
        foreach(string item in words)
        {
         _words.Add(item);
        }


        //generates a random word inside the list so it hides randomly
        Random rnd = new Random();
        string rndWord = _words[rnd.Next(0,_words.Count())];
        Console.Write(rndWord);


        //hides the targeted word 
        for(int i=0;i<_words.Count;i++)
        {
            if(_words[i].Contains("Nephi"))
                _words[i] = "---";
        }  

        

        
   }
}


