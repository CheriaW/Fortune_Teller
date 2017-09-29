using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user for name
            Console.WriteLine("Hello, soul. What is your name...?");
            Console.ReadLine();
            
            Console.WriteLine("Hmmm... That sounds familiar. What's your last name?");
            Console.ReadLine();

            //asking user for age and telling them their fortune based on answer
            Console.WriteLine("Ah, yes. I've been expecting you. Tell me... How old are you now?");
            Console.ReadLine();

            ////is their age odd or even?
            ////COME BACK TO (look up moduls, dont use case)
            //string userAge = Console.ReadLine();

            ////if userAge = string ();


                Console.WriteLine("Really? I have some interesting news for you then.");

            // finding out the number of user siblings and where users vacation home will be
            Console.WriteLine("How many siblings do you have?");
            int userSib = int.Parse(Console.ReadLine());

            if (userSib <= 0)
            {
                Console.WriteLine("You'll invest in a vacation home in Fiji BUT it gets infested with rats. \n The local teens use it for parties and vandalize every inch of your property. \n Your home smells like poo and eventually gets torn down while you're away \n because the rancid odor takes over the town.\n The townsfolk gather around your burning vacation home and sing campfire songs in celebration.");
            }


            else if (userSib == 1)

            {
                Console.WriteLine("You'll invest in a vacation home in South America BUT before you can enjoy it\n the home gets looted and burned while youre away.");

            }

            else if (userSib == 2)
            {
                Console.WriteLine("You buy a 10,000 sq ft vacation home in Peru and have your own alpaca farm.");
            }

            else if (userSib == 3)

            {
                Console.WriteLine("In ten years you will have a vacation home in Tokyo that you and your significant other \n love with and turn into your permanant home!");
            }

            else 

            {
                Console.WriteLine("Retirement goes extremely well for you and you now own all of Hawaii which you \n use as a vacation home. \n *cough cough* \n selfishly uprooting all natives from their homes and forcing them to leave the island.");
            }

            Console.WriteLine("Hold on.... I'm feeling something....");
            Console.WriteLine("\a");
            Console.WriteLine(". . .");
            Console.WriteLine("\a");
            Console.WriteLine(". . .");
            Console.WriteLine("\a");


            //ROYGBIV fortunes
            Console.WriteLine("Tell me something.... do you know what ROYGBIV is?");
            int roygbiv = int.Parse(Console.ReadLine());

            switch (roygbiv)

            {
                case 0:
                    Console.WriteLine("Excellent! I need to know what your favorite ROYGBIV color is!");
                    break;

                case 1:
                    Console.WriteLine("It's fine, I'll tell you. ROYGBIV is an acrynom that stands for the colors Red, Orange, Yellow, Green, Blue, Indigo, and Violet.");
                    break;
            }

            Console.WriteLine("Did this help? Y/N?");








            }
    }
}
