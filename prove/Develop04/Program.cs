using System;

class Program
{
    static void Main(string[] args)
    {
        //creats Breathing Activity
        /*BreathingActivity breathingActivity = new BreathingActivity("Breath in...", "Now breath out...", "Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 5);
        breathingActivity.DisplayStartMessage();
        breathingActivity.RunBreathingActivity();
        breathingActivity.DisplayEndMessage();*/


        //creates Reflecting Activity
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 5);
        reflectingActivity.DisplayStartMessage();
        reflectingActivity.RunReflectingActivity();
        reflectingActivity.DisplayEndMessage();


        /*ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 5);
        listingActivity.DisplayStartMessage();
        listingActivity.RunListingActivity();
        listingActivity.DisplayEndMessage();*/
    }
}