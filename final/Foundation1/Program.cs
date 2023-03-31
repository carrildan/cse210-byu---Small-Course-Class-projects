using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video();
        video._title = "My first video";
        video._author = "Daniel";
        video._length =  new System.DateTime(2023, 3, 30, 0, 0, 10);   
        
        Comment comment = new Comment();
        comment._nameOfPerson = "Carlos";
        comment._commentText = "I love this video";

        video._listOfComments.Add(comment);
        
        Video video2 = new Video();
        video2._title = "My second video";
        video2._author = "Elisangela";
        video2._length = new System.DateTime(2023, 3, 30, 0, 0, 5);

        Comment comment2 = new Comment();
        comment2._nameOfPerson = "Edith";
        comment2._commentText = "This video is awsome";

        video2._listOfComments.Add(comment2);

        Video video3 = new Video();
        video3._title = "My third video";
        video3._author = "Sophia";
        video3._length = new System.DateTime(2023, 3, 30, 0, 0, 50);

        Comment comment3 = new Comment();
        comment3._nameOfPerson = "Denise";
        comment3._commentText = "I don´t like this video";

        video3._listOfComments.Add(comment3);
        

    }
}