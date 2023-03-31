using System;

class Program
{
    static void Main(string[] args)
    {
        //video1
        Video video = new Video();
        video._title = "My first video";
        video._author = "Daniel";
        video._length =  new System.DateTime(2023, 3, 30, 0, 0, 10);  

        //creating new comments for video1
        Comment comment = new Comment();
        comment._nameOfPerson = "Carlos";
        comment._commentText = "I love this video";

        Comment comment2 = new Comment();
        comment2._nameOfPerson = "Edith";
        comment2._commentText = "What a great video";    

        Comment comment3 = new Comment();
        comment3._nameOfPerson = "Denise";
        comment3._commentText = "This video is awsome";

        //add comments to video
        video._listOfComments.Add(comment);
        video._listOfComments.Add(comment2);
        video._listOfComments.Add(comment3);



        //video2
        Video video2 = new Video();
        video2._title = "My second video";
        video2._author = "Elisangela";
        video2._length = new System.DateTime(2023, 3, 30, 0, 0, 5); 

        //creating new comments for video2
        Comment comment4 = new Comment();
        comment4._nameOfPerson = "Marcelo";
        comment4._commentText = "Nice video";

        Comment comment5 = new Comment();
        comment5._nameOfPerson = "Sid";
        comment5._commentText = "I enjoy it";    

        Comment comment6 = new Comment();
        comment6._nameOfPerson = "Larissa";
        comment6._commentText = "This is an interesting video";

        //adding comments to video 2
        video2._listOfComments.Add(comment4);
        video2._listOfComments.Add(comment5);
        video2._listOfComments.Add(comment6);


        //video3
        Video video3 = new Video();
        video3._title = "My third video";
        video3._author = "Sophia";
        video3._length = new System.DateTime(2023, 3, 30, 0, 0, 50);

        //creating new comments for video2
        Comment comment7 = new Comment();
        comment7._nameOfPerson = "Diego";
        comment7._commentText = "Crazy video";

        Comment comment8 = new Comment();
        comment8._nameOfPerson = "Ismael";
        comment8._commentText = "I need more videos like this";    

        Comment comment9 = new Comment();
        comment9._nameOfPerson = "Junior";
        comment9._commentText = "I dont like this video";

        //adding comments to video 3
        video3._listOfComments.Add(comment7);
        video3._listOfComments.Add(comment8);
        video3._listOfComments.Add(comment9);
        

        //adding the videos in a list
        List<Video> listOfVideos = new List<Video>();
        listOfVideos.Add(video);
        listOfVideos.Add(video2);
        listOfVideos.Add(video3);


        //displays the data in the video along with comment
        foreach(Video item in listOfVideos)
        {
            Console.WriteLine($"Title: {item._title}\nAuthor: {item._author}\nLength: {item._length.ToLongTimeString()}\nNumber of comments: {item.ReturnNumberOfComments()}\n");

            Console.WriteLine("Comments:");

            foreach(Comment commenting in item._listOfComments)
            {
                commenting.DisplayComment();
                Console.WriteLine("");
            }
        }
        

    }
}