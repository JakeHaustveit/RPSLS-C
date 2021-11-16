using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        
        public AI()
        {
            this.name = "Robot";
        }

        public void RandomGesture()
        {

            string AIChoosenGesture = "Rock";

            switch (AIChoosenGesture)
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
