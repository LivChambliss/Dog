using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Dog
    {
        public enum Gender
        {
            Male, Female
        };

        public string Name;
        public string Owner;
        public int Age;
        public Gender gender;

        public static string getGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "His";
            }
            return "Her";
        }

        public Dog(string name1, string owner1, int age1, Gender gender1)
        {
            Name = name1;
            Owner = owner1;
            Age = age1;
            gender = gender1;
        }

        public void bark(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("Woof!");
            }

            Console.WriteLine();
        }

        public string getTag()
        {
            string hisOrher = getGender(gender).ToString();
            string heOrShe;

            if (hisOrher == "His")
            {
                heOrShe = "he";

            }
            else
            {
                heOrShe = "she";
            }
        return "If lost, call " + Owner + ". " + hisOrher + " name is " + Name + " and " + heOrShe + " is " + Age + " old. ";



        }
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Louie", "Liv", 1, Gender.Male);
            puppy.bark(3);
            Console.WriteLine(puppy.getTag());

            Dog myDog = new Dog("Roxie", "Liv", 4, Gender.Female);
            myDog.bark(1);
            Console.WriteLine(myDog.getTag());

            Console.ReadKey();
        }
    }





