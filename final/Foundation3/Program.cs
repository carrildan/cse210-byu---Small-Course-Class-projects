using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("AI and the world.","How AI will impact our lives and how to prepare for it.","Lectures","Daniel Carril",200);
        lecture.SetEventDateAndTime(new System.DateTime(2023, 4, 1), new System.TimeOnly(1,30));
        lecture.StandardDetailsMessage();
        lecture.ShortDescriptionMessage();
    }
}