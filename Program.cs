using System;
using zoolandia.Species;

namespace zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zoolandia!");

            EquusAsinus donkey = new EquusAsinus("Georgio");     //use class type ANimal instead of a var so you see what class is easily
            
            donkey.Name = "Georgio";
            string response = donkey.Eat(4);
            Console.WriteLine(donkey.Name + " says " + response);
            //is this just to rename Georgio or create a new instance of a donkey and name it Maury?
            //classname is the type, variable name, and set it as null with just ; or initialize or instantiate a new animal 
            EquusAsinus Maury = new EquusAsinus("Maury");
            Console.WriteLine(Maury.Welcome("Georgio"));
            Console.WriteLine(Maury.Name.ToUpper());
           
            Console.ReadLine(); //makes console wait for you to type another line, so it doesn't close.

            LoxodontaAfricana elephant = new LoxodontaAfricana("Jimbo");
            elephant.Name = "Jimbo";
            Console.WriteLine("What is the height of Jimbo?");
            string response3 = Console.ReadLine();
            elephant.Height = int.Parse(response3);
            Console.WriteLine(elephant.Name + "'s height is  " + elephant.Height);

            Otariinae seaLion = new Otariinae("Suzy");
            seaLion.Name = "Suzy";
            Console.WriteLine("What is Suzy's weight?");
            string response2 = Console.ReadLine();
            seaLion.Weight = int.Parse(response2);
            Console.WriteLine("Suzy weighs  "  + response2 + " pounds.");

            CarassiusAuratus goldfish = new CarassiusAuratus("Louie");
            goldfish.Name = "Louie";
            Console.WriteLine("This goldfish's name is "+ goldfish.Name);

            AilurusFulgens redPanda = new AilurusFulgens("Patty");
            redPanda.Name = "Patricia";
            Console.WriteLine("The Red Panda's name is " + redPanda.Name);
           

           Console.ReadKey();

        }
    }
}
