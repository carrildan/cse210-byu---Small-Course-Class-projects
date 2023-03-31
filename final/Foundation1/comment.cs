using System;

public class Comment
{
    //stores the name of person who makes a comment
    public string _nameOfPerson;

    //stores the text of the comment
    public string _commentText;


    public void DisplayComment()
    {   
        Console.WriteLine($"Name: {_nameOfPerson}\nComment: {_commentText}");
    }
}