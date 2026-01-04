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
        Gender gender;
        Hair hair;
        DateTime birthDay;
        Color eyeColor;

        public Person( Gender gender, Hair hair, DateTime birthDay, Color eyeColor )
        {
            this.gender = gender;
            this.hair = hair;
            this.birthDay = birthDay;
            this.eyeColor = eyeColor;
        }

        public string GetData()
        {
            return
                gender.ToString() + "," +
                hair.hairLength.ToString() + "," +
                hair.hairColor.ToString() + "," +
                birthDay.ToString() + "," +
                eyeColor.ToString();
        }
    }

    struct Hair
    {
        public float hairLength;
        public Color hairColor;

        public Hair( float hairLength, Color hairColor )
        {
            this.hairLength = hairLength;
            this.hairColor = hairColor;
        }
    }
}
