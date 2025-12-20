using System.Drawing;

namespace Labb4
{
    enum Gender
    {
        woman,
        man,
        non_binary,
        other
    }

    struct Hair
    {
        public float HairLength;
        public Color HairColor;

        public Hair( float hairLength, Color hairColor )
        {
            HairLength = hairLength;
            HairColor = hairColor;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person( Gender.man, new Hair( 10f, Color.Brown ), new DateTime(2003, 10, 27), Color.Blue );
            Console.WriteLine(person.GetData());
        }
    }

    class Person
    {
        Gender Gender;
        Hair Hair;
        DateTime BirthDay;
        Color EyeColor;

        public Person( Gender gender, Hair hair, DateTime birthDate, Color eyeColor )
        {
            Gender = gender;
            Hair = hair;
            BirthDay = birthDate;
            EyeColor = eyeColor;
        }

        public string GetData()
        {
            return 
                Gender.ToString() + "," + 
                Hair.HairLength.ToString() + "," +
                Hair.HairColor.ToString() + "," +
                BirthDay.ToString() + "," +
                EyeColor.ToString();
        }
    }
}
