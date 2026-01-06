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

        Gender Gender;
        Hair Hair;
        DateTime BirthDay;
        Color EyeColor;

        // Konstruktor för att skapa en person
        public Person(Gender gender, Hair hair, DateTime birthDay, Color eyeColor)
        {
            Gender = gender;
            Hair = hair;
            BirthDay = birthDay;
            EyeColor = eyeColor;
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
                "\nGender: " + Gender.ToString() +
                "\nHair length: " + Hair.HairLength.ToString() + "cm " +
                "\nHair color : " + Hair.HairColor.Name.ToLower() +
                "\nBirth date: " + BirthDay.ToString("yyyy-MM-dd") +
                "\nEye color: " + EyeColor.Name.ToLower();  // Hämtar ögonfärgens namn för snyggare utskrift: "red" istället för "Color [Red]".
        }
    }

    // Struct som beskriver hår
    struct Hair
    {
        public float HairLength;
        public Color HairColor;

        // Konstruktor för hår
        public Hair(float hairLength, Color hairColor)
        {
            HairLength = hairLength;
            HairColor = hairColor;
        }
    }
}
