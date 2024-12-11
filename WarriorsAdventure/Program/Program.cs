using System.Windows;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        bool game = true; 

        if(game == true)
        {
            Console.WriteLine("Hello you have entered into a cave.\nWhat is your name stuooipid\n");//welcomes player

            var playerName = Console.ReadLine();

            Console.WriteLine("Wow, {0} what a horrible name.", playerName);
                Console.WriteLine("blayne is a plane thats lame that talked to dane and then the bane went in thomas train and then ate blayne and then he went up in flames while playing a game.");

            Console.Write("Enter the cave?");

            var enter =  Console.ReadLine();

            //if they enter or not
            if (enter != null)
            {
                if(enter.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You've sumbled into the dark cave. \nYou f0und a sword");
                    
                }
            }



            if (game == false)
            {
                Quit.Application();
            }
        }

        else
        {
            game = false;
        }

    }

}