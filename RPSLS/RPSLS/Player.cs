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
        public string gesture;


        public Player()
        {
           
            
        }        

        public void ChooseGesture()
        {
            string playerChoosenGesture = System.Console.ReadLine();

            switch (playerChoosenGesture)
            {
                case ("Rock"):
                    System.Console.WriteLine("Rock");
                    this.gesture = "Rock";
                    break;
                case ("Paper"):
                    System.Console.WriteLine("Paper");
                    this.gesture = "Paper";
                    break;
                case ("Scissors"):
                    System.Console.WriteLine("Scissors");
                    this.gesture = "Scissors";
                    break;
                case ("Lizard"):
                    System.Console.WriteLine("Lizard");
                    this.gesture = "Lizard";
                    break;
                case ("Spock"):
                    System.Console.WriteLine("Spock");
                    this.gesture = "Spock";
                    break;
                default:
                    System.Console.WriteLine("Not valid Gesture");
                    break;
                
            }
        }
    }
}
