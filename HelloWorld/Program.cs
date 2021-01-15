using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //The words that will be tested for syllable count
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            //------------------------------------------------------------

            //Question User/Random Animal
            //------------------------------------------------------------

            string username;
            string color;

            

            Console.WriteLine("Please enter a username you would like to use: ");
            username = Console.ReadLine();

            Console.WriteLine($"\nHello {username} glad to have you on board!\n");
            Console.WriteLine($"Ok so {username} I am going to need you to enter you favorite color please:");
            color = Console.ReadLine();

            Random rand = new Random();
            int index = rand.Next(animals.Length);

            Console.WriteLine($"\nWould you like to have a {color.ToLower()} {animals[index].ToLower()}?\n\n");

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            //------------------------------------------------------------

            //The Syllable Counter
            //--------------------------------------------


            //The vowels that the words are going to be compared against
            var vowels = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'y', 'Y' };
  
            //Holds the previous character value sort of
            bool previousCharacterIsVowel = false;
           
            //Going to hold the total current number of syllables
            int syllableTotalCount = 0;

            //Loop that is going to loop over the array of animal words
            foreach (string animal in animals)
            {
                //Consoles out the animals name in the first loop
                Console.WriteLine(animal);

                //Looping over the animal name
                for (int counter = 0; counter <= animal.Length - 1; counter++)
                {
                    // This takes in the array of vowels and the characters from the animal/(word)string. If a letter matches the index of any of the vowels it return that index number.
                    // If it doesn't match any of the index's it returns a -1 which means false (basically any index number = true, -1 = false)
                    if (Array.IndexOf(vowels, animal[counter]) != -1)
                    {
                        //If the previous character boolean is false add one to the variable count and turn the previous character boolean to true
                        if (!previousCharacterIsVowel)
                        {
                            syllableTotalCount++;
                            previousCharacterIsVowel = true;
                        }
                    }
                    //If the index comes back as -1 the previous character boolean is set to false
                    else
                    {
                        previousCharacterIsVowel = false;
                    }
                }
                //Console out the syllable results and return syllable count to zero
                Console.WriteLine($"Has a total of {syllableTotalCount} syllables\n");
                syllableTotalCount = 0;
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            //------------------------------------------------------------

            //Three different greetings
            //------------------------------------------------------------

            Console.WriteLine("Hello this is Assistant Greetings Automation where we assist you with all your greeting needs!\n");

            Console.WriteLine("Which Greeting would you like to select today?");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Option 1: Magic Man");
            Console.WriteLine("Option 2: Finn");
            Console.WriteLine("Option 3: Jake");
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine("Type in your answer and press Enter");

            var usersAnswer = Console.ReadLine();

            switch (usersAnswer.ToLower())
            {
                case "magic man":
                    Console.WriteLine("Maaaaaaaaaaagggiiiiiiic Maaaaaaaannnn! Dream on honey you can't catch this!");
                    break;
                case "finn":
                    Console.WriteLine("Oh hey! What's up bp.");
                    break;
                case "jake":
                    Console.WriteLine("Hi, you want to go make a sandwhich or something?");
                    break;
                default:
                    Console.WriteLine("You didn't pick one? Well that is too bad because now the Ice King is going to come still your princess.");
                    break;
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            
        }
    }
}

