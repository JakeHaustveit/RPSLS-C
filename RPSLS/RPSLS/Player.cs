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
        public string gestures;


        public Player(string name)
        {
            this.name= name;
            
        }        

        public void ChooseGesture()
        {
            string playerChoosenGesture = Console.ReadLine();

            switch (playerChoosenGesture)
            {
                case ("Rock"):
                    Console.WriteLine("Rock");
                    this.gestures = "Rock";
                    break;
                case ("Paper"):
                    Console.WriteLine("Paper");
                    this.gestures = "Paper";
                    break;
                case ("Scissors"):
                    Console.WriteLine("Scissors");
                    this.gestures = "Scissors";
                    break;
                case ("Lizard"):
                    Console.WriteLine("Lizard");
                    this.gestures = "Lizard";
                    break;
                case ("Spock"):
                    Console.WriteLine("Spock");
                    this.gestures = "Spock";
                    break;
                default:
                    Console.WriteLine("Not valid Gesture");
                    break;
                
            }
        }
    }
}
