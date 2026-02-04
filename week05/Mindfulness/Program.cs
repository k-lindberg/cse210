//Exceeding Requirements;
//I added a total duration counter, it will add up all seconds completed from multiple activities and show you the total after you quit.

using System;

class Program
{
    static void Main(string[] args)
    {
        string input;

        do
        {
            Console.Clear();
            Console.Write("Menu Options: \n   1. Start Breathing Activity \n   2. Start Reflecting Activity \n   3. Start Listing Activity \n   4. Quit\nSelect a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity activity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);

                activity.Run();
            }

            else if (input == "2")
            {
                ReflectingActivity activity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);

                activity.Run();
            }

            else if (input == "3")
            {
                ListingActivity activity = new ListingActivity("Listing", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, 0);

                activity.Run();
            }

        } while (input != "4");

        Console.WriteLine($"Total time spent: {Activity._totalDuration} seconds.");
    }
}
