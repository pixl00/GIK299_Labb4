using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    // Enum för att representera kön
    enum Gender
    {
        woman,
        man,
        non_binary,
        other
    }

    // Klass som beskriver en person
    internal class Person
    {

        Gender gender;
        Hair hair;
        DateTime birthDay;
        Color eyeColor;

        // Konstruktor för att skapa en person
        public Person(Gender gender, Hair hair, DateTime birthDay, Color eyeColor)
        {
            this.gender = gender;
            this.hair = hair;
            this.birthDay = birthDay;
            this.eyeColor = eyeColor;
        }

        // Returnerar en strängrepresentation av personen
        public override string ToString()
        {
            return GetData();
        }

        // Returnerar personens data som en kommaseparerad sträng
        public string GetData()
        {

            return
                "\nGender: " + gender.ToString() +
                "\nHair length: " + hair.hairLength.ToString() + "cm " +
                "\nHair color : " + hair.hairColor.Name.ToLower() +
                "\nBirth date: " + birthDay.ToString("yyyy-MM-dd") +
                "\nEye color: " + eyeColor.Name.ToLower();  // Hämtar ögonfärgens namn för snyggare utskrift: "red" istället för "Color [Red]".
        }
    }

    // Struct som beskriver hår
    struct Hair
    {
        public float hairLength;
        public Color hairColor;

        // Konstruktor för hår
        public Hair(float hairLength, Color hairColor)
        {
            this.hairLength = hairLength;
            this.hairColor = hairColor;
        }
    }
}
