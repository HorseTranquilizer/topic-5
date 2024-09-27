using System.ComponentModel.Design;

namespace topic_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weight;
            string UserAnswer;
            int numberguess;
            string userguess;
            string ans1;
            int score;
            int ans2;
            string ans3;
            int ans4;
            Console.WriteLine("please enter your weight");
            weight = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Figure out how much you weight on other planets! choose between Venus, Mars, Jupiter, Saturn, Uranus, and Neptune,");
            UserAnswer = Console.ReadLine().ToLower();
            if (UserAnswer == "venus") 
            {
                Console.WriteLine(weight * 0.79);
            }
            if (UserAnswer == "mars")
            {
                Console.WriteLine(weight * 0.39);

            }
            if (UserAnswer == "juipter")
            {
                Console.WriteLine(weight * 2.65);
            }
            if (UserAnswer == "saturn")
            {
                Console.WriteLine(weight * 1.17);
            }
            if (UserAnswer == "uranus")
            {
                Console.WriteLine(weight * 1.05);
            }
            if (UserAnswer == "neptune")
            {
                Console.WriteLine(weight * 1.23);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("worst guessing game ever");            
            numberguess = 5;          
            Console.WriteLine("pick a random out of 10 and try and guess the one I picked");
            userguess = Console.ReadLine();
            if (userguess == "5")
            {
                Console.WriteLine("wow you guessed it right!");
            }
            else Console.WriteLine("Wrong answer! try again");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();           
            Console.WriteLine("Mini quiz!");
            Console.WriteLine("answer these questions correctly to gain a point, answering wrong will lose a point");         
            score = 0;
            Console.WriteLine("Who blew up Krillin on namek?");
            ans1 = Console.ReadLine().ToLower();
            if (ans1 == "frieza")
            {
                Console.WriteLine("Correct!!!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine("Nope you lose a point");
               
            }
            Console.WriteLine("how many pure saiyans are alive today?");
            ans2 = Convert.ToInt32(Console.ReadLine());
            if (ans2 == 3)
            {
                Console.WriteLine("Correct! Goku, Vegeta, And Broly are the only pure saiyans left"); score = score + 1;
            }
            else
            {
                Console.WriteLine("Incorrect lose 1 point"); 
            }
           
            Console.WriteLine("Who is frieza's brohter?");
            ans3 = Console.ReadLine().ToLower();
            if (ans3 == "cooler")
            {
                Console.WriteLine("Correct! part of the cold clan family"); score = score + 1;
            }
            else
            {
                Console.WriteLine("WRONG make sure you REMEMBER next time"); 
            }
            
            Console.WriteLine("How many dragon balls are there?");
            ans4 = Convert.ToInt32(Console.ReadLine());
            if (ans4 == 7)
            {
                Console.WriteLine("Correct! 7 dragon balls and you may summon the eternal dragon!"); score = score + 1;
            }
            else
            {
                Console.WriteLine("Wow that was an easy one how did you mess that up?");
            }
            Console.WriteLine("YOUR FINAL SCORE IS: " + score);
