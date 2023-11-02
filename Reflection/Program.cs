using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user = new User(1, "Fuad");
            Console.WriteLine("First Information");
            user.UserInfo();

            var ageField = typeof(User).GetField("Age", BindingFlags.NonPublic | BindingFlags.Static);
            
                ageField.SetValue(user, 20);
            

            Console.WriteLine("Changed Info");
            user.UserInfo();
        }
    }
}