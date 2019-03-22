using System;
enum Gender
{
    Male,
    Female
}

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.
    
            /*
            Console.WriteLine(“If lost, call {0}. {1} name is {2} and {3} is {4}{5} old.”, owner, gender, name, genderof, age, years);
        

            Dog myDog = Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.Bark(1); // output: Woof!
            Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
            */           
        }
    }
    public class Dog
    {
        Dog(string name, string owner, int age, string.gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;

            string gettag()
            {
                if (gender = male)
                {
                    string genderof = his;
                }

                else
                {
                    string genderof = her;
                }

                if (year = 1)
                {
                    Console.WriteLine("year");
                }

                else
                {
                    Console.WriteLine("years");
                }
            }
        }
    }
}
