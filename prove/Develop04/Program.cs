using System;

class Program
{
    static void Main(string[] args)
    {
        //creats Breathing Activity
        BreathingActivity breathingActivity = new BreathingActivity("Breath in...", "Now breath out...", "Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 5);
        breathingActivity.DisplayStartMessage();
        breathingActivity.RunBreathingActivity();
        breathingActivity.DisplayEndMessage();
    }
}