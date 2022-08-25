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
        //Omdefinér jeres Items til at bruge interfaces
        //En Item skal kunne have interfae der kan kaste formularer, gøre skade, heale, lave en form for utility
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
            Sword sword = new Sword();
            Staff staff = new Staff();
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
                            sword.Equip(kriger);
                            int bigChance = rnd.Next(1,  3);
                            switch (bigChance)
                            {   
                                case 1:
                                    Console.WriteLine("You and the sword connects which realeses the opportunity to do a oneshot!");
                                    sword.OneShot();
                                    person.health = 0;
                                    break;
                                case 2:
                                    Console.WriteLine("Aw, no oneshot for you!");
                                    break;
                            }
                            sword.Action();
                            person.health -= 40;
                            sword.Unequip(kriger);
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
                            staff.Equip(wizard);
                            int bigChance = rnd.Next(1, 3);
                            switch (bigChance)
                            {
                                case 1:
                                    Console.WriteLine("The staff unleases itself and sends out a powerful spell which hits the human in the face!");
                                    staff.CastSpell();
                                    person.health = 10;
                                    break;
                                case 2:
                                    Console.WriteLine("Aw, no powerful spell for you!");
                                    break;
                            }
                            staff.Action();
                            Console.WriteLine("You've teleported yourself into the desert");
                            Console.WriteLine("You managed to teleport back! Continue the fight!");
                            staff.Unequip(wizard);
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
