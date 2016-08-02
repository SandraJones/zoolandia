using System;
using zoolandia.Species;
using System.Collections.Generic;

namespace zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zoolandia!");

            Asinus donkey = new Asinus("Georgio");     //use class type ANimal instead of a var so you see what class is easily
            
            donkey.Name = "Georgio";
            string response = donkey.Eat(4);
            Console.WriteLine(donkey.Name + " says " + response);
            //is this just to rename Georgio or create a new instance of a donkey and name it Maury?
            //classname is the type, variable name, and set it as null with just ; or initialize or instantiate a new animal 
            Asinus Maury = new Asinus("Maury");
            Console.WriteLine(Maury.Welcome("Georgio"));
            Console.WriteLine(Maury.Name.ToUpper());
           
            Console.ReadLine(); //makes console wait for you to type another line, so it doesn't close.

            Africana elephant = new Africana("Jimbo");
            elephant.Name = "Jimbo";
            Console.WriteLine("What is the height of Jimbo?");
            string response3 = Console.ReadLine();
            elephant.Height = int.Parse(response3);
            Console.WriteLine(elephant.Name + "'s height is  " + elephant.Height);

            Otariidae seaLion = new Otariidae("Suzy");
            seaLion.Name = "Suzy";
            Console.WriteLine("What is Suzy's weight?");
            string response2 = Console.ReadLine();
            seaLion.Weight = int.Parse(response2);
            Console.WriteLine("Suzy weighs  "  + response2 + " pounds.");

            Auratus goldfish = new Auratus("Louie");
            goldfish.Name = "Louie";
            Console.WriteLine("This goldfish's name is "+ goldfish.Name);
          
            elephant.Name = "Jimbo";
            Console.WriteLine("The elephant's name is " + elephant.Name + ".");

            seaLion.Name = "Suzy";
            Console.WriteLine("The sea lion's name is  " + seaLion.Name + ".");

            donkey.Name = "Georgio";
            Console.WriteLine("The donkey's name is " + donkey.Name + ".");

            Africana newElephant = new Africana("Zuzu");
            Console.WriteLine(newElephant.Name);

            List<String> inhabitants = new List<String>();
            foreach(var name in inhabitants)
            {
                Console.WriteLine(name);
            };

            Console.ReadKey();
        }
    }
}
