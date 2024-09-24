using System.ComponentModel.Design;

namespace topic_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weight;
            Console.WriteLine("please enter your weight");
            weight = Convert.ToInt32(Console.ReadLine());
            string UserAnswer;
            Console.WriteLine("Figure out how much you weight on other planets! choose between Venus, Mars, Jupiter, Saturn, Uranus, and Neptune,");
            UserAnswer = Console.ReadLine();
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










        }
    }
}