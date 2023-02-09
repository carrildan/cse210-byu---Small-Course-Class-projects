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

        //get the scripture
        string words = _scripture.GetScriptures();
        string splitWords = string.Join(" ",words);

        foreach (var item in words)
        {
            _hiddenWords.Add(item.ToString());
            
        }
        foreach(string item in _hiddenWords)
        {
            Console.Write(item);
        };
        //split it into words then separete with space
        
        //Console.Write(words.GetType());
        //string unsplitWords = string.Join("--",words);
        //Console.Write(unsplitWords);

        //string listWords = unsplitWords;
        //Console.Write(listWords.GetType());

    /*
        for( i in listWords){
            _hiddenWords.Add(i);
            Console.Write(i);
        }



        for(int i=0;i<_hiddenWords.Count;i++)
        {
            if(_hiddenWords[i].Contains("Nephi"))
                _hiddenWords[i] = "Daniel";
                Console.Write(_hiddenWords[i]);
        }   

        foreach(string item in _hiddenWords)
        {
            Console.WriteLine(item);
        }  

    */


        //string[] splitWords = words.Split(" ");
        

        //int index = rnd.Next(splitWords.Length);
        //string getWords  = splitWords[index].Replace("the", "---");
       

        //int index = rnd.Next(splitWords.Length);
        //string getWords  = splitWords[index];
        //Console.WriteLine(splitWords);
        //string replacer = splitWords[index].Replace(getWords,"---");
        //_hiddenWords = replacer;

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