using System;

class Program
{
    static void Main(string[] args)
    {
        //creates a new lecture event
        Lectures lecture = new Lectures("AI and the world.","How AI will impact our lives and how to prepare for it.","Lectures","Daniel Carril",200);
        lecture.SetAddresses("daniel street","New York","NY","Manhatan");
        lecture.SetEventDateAndTime(new System.DateTime(2023, 4, 1), new System.TimeOnly(1,30));
        lecture.StandardDetailsMessage();
        lecture.ShortDescriptionMessage();
        lecture.FullDetailsMessage();


        //creates a new reception event
        Receptions reception = new Receptions("The president's birthday party.","Celebration of the 45th aniversary of the president of the country","Reception","rsvp@gmail.com");
        reception.SetAddresses("daniel street","New York","NY","Manhatan");
        reception.SetEventDateAndTime(new System.DateTime(2023, 4, 1), new System.TimeOnly(1,30));
        reception.StandardDetailsMessage();
        reception.ShortDescriptionMessage();
        reception.FullDetailsMessage();


        //creates a new outdoor event
        OutdoorGatherings outdoor = new OutdoorGatherings("The president's birthday party.","Celebration of the 45th aniversary of the president of the country.","Outdoor Gathering","Sunny");
        outdoor.SetAddresses("daniel street","New York","NY","Manhatan");
        outdoor.SetEventDateAndTime(new System.DateTime(2023, 4, 1), new System.TimeOnly(1,30));
        outdoor.StandardDetailsMessage();
        outdoor.ShortDescriptionMessage();
        outdoor.FullDetailsMessage();
    }
}