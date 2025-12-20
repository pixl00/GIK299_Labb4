using System.Drawing;

namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person( Gender.man, new Hair( 10f, Color.Brown ), new DateTime(2003, 10, 27), Color.Blue );
            Console.WriteLine(person.GetData());
        }
    }
}
