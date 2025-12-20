using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    enum Gender
    {
        woman,
        man,
        non_binary,
        other
    }

    internal class Person
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
}
