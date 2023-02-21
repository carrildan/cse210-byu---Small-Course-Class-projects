using System;

class Reference
{
    //stores a book
    private string _book;
    //stores a chapter
    private string _chapter;
    //stores the first verse
    private string _firtVerse;
    //stores the rest of the verses 
    private string _lastVerse;


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


