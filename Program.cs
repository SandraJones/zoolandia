using System;
using zoolandia.Species;

namespace zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AilurusFulgens redPanda = new AilurusFulgens("Steve"); //use class type ANimal instead of a var so you see what class is easily
            redPanda.Name = "Steve";
            string response = redPanda.Eat(5);

            Console.WriteLine(redPanda.Name + " says " + response);

            AilurusFulgens Joe = new AilurusFulgens("Steve");
            Console.WriteLine(Joe.Welcome("Joe"));
            Console.WriteLine(Joe.Name.ToLower());
            Console.ReadLine(); //makes console wait for you to type another line, so it doesn't close.

        }
    }
}
