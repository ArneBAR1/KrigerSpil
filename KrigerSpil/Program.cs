using System;
using KrigerSpil.Class;

namespace KrigerSpil
{
    class Program
    {
        //Byg en personklasse, som kan tage skade og dø
        //Byg en Krigerklasse Som kan give skade, og som nedarver fra personklassen.
        //Byg en Wizardklasse som kan kaste spells og som nedarver fra personklassen.
        //Byg en item klasse der kan equip og unequip. De skal have en generic action
        //Byg en sværd klasse der nedarver fra Itemklassen og overrider actionen med en skade funktion
        //Byg en Wizard staff klasse der nedarver fra itemklassen og som nedarver fra Itemklassen og som overrider actionen med en teleport funktion
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Welcome to the warrior game!");
            Console.WriteLine("What will you spawn as?");
            Console.WriteLine("A warrior maybe? Or a wizard?");
            Console.WriteLine("Roll the dice to know yourself!");
            Console.ReadLine();
            int chance = rnd.Next(1, 3);
            Person person = new Person();
            Kriger kriger = new Kriger();
            Wizard wizard = new Wizard();
            Item item = new Item();
            switch (chance)
            {
                case 1:
                    Console.WriteLine("You spawn as a warrior! Now kill the human!");
                    Console.WriteLine("The humans Health: " + kriger.health);
                    Console.ReadLine();
                    Console.WriteLine("Warrior hits the human!");
                    person.health -= kriger.DamageDealt;
                    Console.WriteLine("Do you want to use this grand sword!? \n1: Yes \n2: No");
                    int Weapon1 = int.Parse(Console.ReadLine());
                    switch (Weapon1)
                    {
                        case 1:
                            Console.WriteLine("You got a sword");
                            item.Equip(kriger);
                            item.Action();
                            person.health -= 40;
                            item.Unequip(kriger);
                            Console.WriteLine("The sword is so powerful it yeets itself into space!");
                            Console.WriteLine("Continue!");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("You got nothing! Continue fighting!");
                            break;
                    }
                    while (person.health > 0)
                    {
                        Console.WriteLine("The human is still alive! Hit again!!");
                        Console.WriteLine("Warrior hits the human!");
                        person.health -= kriger.DamageDealt;
                        Console.ReadLine();
                    }
                    Console.WriteLine("The human is now dead! Congrats, you've won!");
                    break;
                case 2:
                    Console.WriteLine("You spawn as a Wizard! Now kill the human!");
                    Console.WriteLine("Your Health: " + wizard.health);
                    Console.ReadLine();
                    Console.WriteLine("Wizard hits the human!");
                    person.health -= wizard.DamageDealt;
                    Console.WriteLine("Do you want to use this awesome staff!? \n1: Yes \n2: No");
                    int Weapon2 = int.Parse(Console.ReadLine());
                    switch (Weapon2)
                    {
                        case 1:
                            Console.WriteLine("You've got a staff");
                            item.Equip(wizard);
                            item.Action();
                            Console.WriteLine("You've teleported yourself into the desert");
                            Console.WriteLine("You managed to teleport back! Continue the fight!");
                            item.Unequip(wizard);
                            break;
                        case 2:
                            Console.WriteLine("You got nothing! Continue fighting!");
                            break;
                    }
                    while (person.health > 0)
                    {
                        Console.WriteLine("The human is still alive! Hit again!!");
                        Console.WriteLine("Wizard hits the human!");
                        person.health -= wizard.DamageDealt;
                        Console.ReadLine();
                    }
                    Console.WriteLine("The human is now dead! Congrats, you've won!");
                    break;
            }
        }
    }
}
