using System;

public class Video
{
    //stores the title of a video
    public string _title;

    //stores the name of the author of a video
    public string _author;

    //stores the time length of the video
    public DateTime _length;

    //holds a list of comments of a video
    public List<Comment> _listOfComments = new List<Comment>();



    public int ReturnNumberOfComments()
    {
        int numberOfComments = 0;
        foreach(Comment comment in _listOfComments)
        {
            numberOfComments += 1;
        }
        return numberOfComments;
    }

}