using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string name;
        


        public Player()
        {
           
            
        }

        public static string ChooseGesture
        {
            get
            {
                string playerChoosenGesture = Console.ReadLine();

                if (playerChoosenGesture == "Rock")
                {
                    Console.WriteLine("Rock");
                    return playerChoosenGesture;
                }
                else if (playerChoosenGesture == "Paper")
                {
                    Console.WriteLine("Paper");
                    return playerChoosenGesture;
                }
                else if (playerChoosenGesture == "Scissors")
                {
                    Console.WriteLine("Scissors");
                    return playerChoosenGesture;
                }
                else if (playerChoosenGesture == "Lizard")
                {
                    Console.WriteLine("Lizard");
                    return playerChoosenGesture;
                }
                else if (playerChoosenGesture == "Spock")
                {
                    Console.WriteLine("Spock");
                    return playerChoosenGesture;
                }
                else
                {
                    Console.WriteLine("Not valid Gesture");
                }


            }
        }
    }
}
