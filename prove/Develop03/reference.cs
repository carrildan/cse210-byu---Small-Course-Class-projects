using System;

class Reference
{
    //stores a book
    string _book;
    //stores a chapter
    string _chapter;
    //stores the first verse
    string _firtVerse;
    //stores the rest of the verses 
    string _lastVerse;


    public Reference()
    {
        _book = "unknown";
        _chapter = "unknown";
        _firtVerse = "unknown";
        _lastVerse = "unknown";
    }

    public void SetReference(string book, string chapter, string firstVerse, string lastVerses)
    {
        _book = book;
        _chapter = chapter;
        _firtVerse = firstVerse;
        _lastVerse = lastVerses;
    }

    
    public string GetReference()
    {
        return $"{_book} {_chapter}: {_firtVerse} - {_lastVerse}";
    }


}


