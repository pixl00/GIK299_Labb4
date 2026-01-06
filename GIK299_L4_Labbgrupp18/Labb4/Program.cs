using System;
using System.Collections.Generic;
using System.Drawing;

namespace Labb4
{
    internal class Program
    {
        // Lista för att lagra personer
        static List<Person> persons = new List<Person>();

        static void Main(string[] args)
        {
            // Huvudloop för programmet
            bool running = true;
            Person person = new Person(Gender.man, new Hair(10f, Color.Brown), new DateTime(2003, 10, 27), Color.Blue);
            Console.WriteLine(person.GetData());
            Console.WriteLine();
            while (running)
            {
                // Skriver ut menyn
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add person");
                Console.WriteLine("2. List persons");
                Console.WriteLine("3. Exit\n");
                Console.Write("Choose an option: ");
                string input = Console.ReadLine() ?? "";
                switch (input)
                {
                    case "1":
                        AddPerson(); // Lägg till en person
                        break;
                    case "2":
                        ListPersons(); // Lista alla personer
                        break;
                    case "3":
                        running = false; // Avsluta programmet, ändra bool villkoret för att bryta loopen
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n"); // Hantera ogiltigt val 
                        break;
                }
            }
        }

        // Metod för att lägga till en person med validering
        // Null-inmatning hanteras med null-coalescing operator (?? "") vid varje Console.ReadLine så att tom sträng används om användaren bara trycker Enter
        static void AddPerson()
        {
            Gender gender;
            // Fråga efter kön och validera inmatningen
            while (true)
            {
                Console.WriteLine("Select gender (woman, man, non_binary, other): ");
                string genderInput = Console.ReadLine() ?? "";
                if (Enum.TryParse(genderInput, true, out gender))
                    break;
                Console.WriteLine("Invalid gender. Please try again.\n");
            }

            float hairLength;
            // Fråga efter hårlängd och validera att det är ett tal
            while (true)
            {
                Console.Write("Enter hair length (in cm): ");
                string lengthInput = Console.ReadLine() ?? "";
                if (float.TryParse(lengthInput, out hairLength))
                    break;
                Console.WriteLine("Invalid hair length. Please enter a number.\n");
            }

            Color hairColor;
            // Fråga efter hårfärg och kontrollera att det är en giltig färg
            while (true)
            {
                Console.Write("Enter hair color (e.g. Red, Blue, Brown): ");
                string colorInput = Console.ReadLine() ?? "";
                hairColor = Color.FromName(colorInput);
                if (hairColor.IsKnownColor)
                    break;
                Console.WriteLine("Invalid hair color. Please enter a valid color.\n");
            }

            DateTime birthDay;
            // Fråga efter födelsedag och validera datumformatet
            while (true)
            {
                Console.Write("Enter birthday (YYYY-MM-DD): ");
                string dateInput = Console.ReadLine() ?? "";
                if (DateTime.TryParse(dateInput, out birthDay))
                    break;
                Console.WriteLine("Invalid date. Please use the format YYYY-MM-DD.\n ");
            }

            Color eyeColor;
            // Fråga efter ögonfärg och kontrollera att det är en giltig färg
            while (true)
            {
                Console.Write("Enter eye color (e.g. Green, Blue, Brown): ");
                string colorInput = Console.ReadLine() ?? "";
                eyeColor = Color.FromName(colorInput);
                if (eyeColor.IsKnownColor)
                    break;
                Console.WriteLine("Invalid eye color. Please enter a valid color. \n");
            }

            // Skapa och lägg till personen i listan
            persons.Add(new Person(gender, new Hair(hairLength, hairColor), birthDay, eyeColor));
            Console.WriteLine("Person added! \n");
        }

        // Metod för att lista alla personer
        static void ListPersons()
        {
            if (persons.Count == 0)
            {
                Console.WriteLine("No persons added. \n");
                return;
            }
            Console.WriteLine("\nList of persons:");
            foreach (var p in persons)
            {
                // Skriv ut varje persons data som en enkel sträng
                Console.WriteLine(p.ToString());
                Console.WriteLine();
            }
        }
    }
}
