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
            EquusAsinus Maury = new EquusAsinus("Georgio");
            Console.WriteLine(Maury.Welcome("Maury"));
            Console.WriteLine(Maury.Name.ToUpper());
           
            Console.ReadLine(); //makes console wait for you to type another line, so it doesn't close.

            LoxodontaAfricana elephant = new LoxodontaAfricana("Jimbo");
            elephant.Name = "Jimbo";
            Console.WriteLine("What is the height of Jimbo?");
            string response3 = Console.ReadLine();


            Otariinae seaLion = new Otariinae("Suzy");
            seaLion.Name = "Suzy";
            Console.WriteLine("What is Suzy's weight?");
            string response2 = Console.ReadLine();
            //question why can't I do int response2?

            Console.WriteLine("Suzy weighs  "  + response2 + " pounds.");
            Console.WriteLine("Jimbo is " +  response3  +  " inches tall.");
    
            

            

 

        }
    }
}
