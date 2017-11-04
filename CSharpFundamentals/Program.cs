using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Khanh";
            var lastName = "Nguyen";
            var fullName = firstName + "" + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Eli", "Howard", "Matt" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var text = "Hi Khanh\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            var text2 = @"Hi Khanh
Look into the following paths
d:\folder1\folder2
d:\folder3\folder4";
            Console.WriteLine(text2);
            //verbatim string! uses @ sign
        }
    }
}
