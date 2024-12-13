using System.Windows;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        bool game = true; 
        bool bow = false;
        int arrows = 6;

        if(game == true)
        {
            Console.WriteLine("It a pleasure to meet you, once every 500 years this cave has amazing weapons treasures and dangers.\nWhat is your name?\n");//welcomes player

            var playerName = Console.ReadLine();

            Console.WriteLine("Wow, {0} what a horrible name.\n", playerName);

            Console.Write("Do you want to enter the cave?\n");

            var enter =  Console.ReadLine();

            //if they enter or not
            if (enter != null)
            {
                if(enter.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You've stumbled into the dark cave. \nYou found a bow and {0} arrows\nDo you pick the bow up or leave it?\n(PickUp) or (Leave it)\n", arrows);

                    var haveBow = Console.ReadLine();

                    if (haveBow != null)
                    {
                    
                        
                        if(haveBow.Equals("pickup", StringComparison.OrdinalIgnoreCase))
                        {
                            bow = true;
                            //Console.Write("Has bow");
                        }
                        else
                        {
                            bow = false;
                        }

                        Console.Write("You walk foward into the cave and you come to a opening your eyes adjust\nYou find a zipo lighter on the ground, do you use it or pocket it\n(use it) or (pocket it)\n");
                        var zipo = Console.ReadLine();
                        if(zipo != null)
                        {
                            if(zipo.Equals("use it", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Write("You light the zipo, spider scurry from all around you and you see writings on the wall\nIt is a graphic with a person with a bow and a wyvern burning earth\nDo you wan't to leave the cave or go further?\n");
                                var furtherOne = Console.ReadLine();
                                if(furtherOne != null)
                                {
                                    if(furtherOne.Equals("Go furter", StringComparison.OrdinalIgnoreCase))
                                    {
                                        Console.Write("explored more");
                                    }
                                    else
                                    {
                                        game = false;
                                    }

                                }
                            }
                            else
                            {
                                Console.Write("You trip, and you land on a snake. The snake bites you");
                                game = false;
                            }
                        }



                    } 
                }
                else
                {
                    game = false;
                }
            }



            if (game == false)
            {
                Console.Write("You left the cave in a hurry.");
                //Quit.Application();
            }
        }

        else
        {
            game = false;
        }

    }

}