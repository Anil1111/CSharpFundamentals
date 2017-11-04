using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public enum ShippingMethod
        {
        RegulerAirMail = 1,
        RegisterAirMail = 2,
        Express = 3
        }

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

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            //or we can cast the enum to shipping method instead of an integer
            Console.WriteLine((ShippingMethod)methodId);
            // console.writeline converts all values into ToString by default
            Console.WriteLine(method.ToString());
            //so the ToString above is not necessary for console.writeline

            var methodName = "Express";
            //parsing means to take the string and change it to a different type
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            //enum is a class in system namespace with method parse. parse takes in two arguments
            //first argument is the type. typeof method is a method in system namespace
            //we cast ShippingMethod and then assign it to a variable

            //below is a demonstration on value types and reference types
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0}, b: {1}", a, b));
            //0 and 1 are placeholders. when we assign b, it assigns the value at a 
            //separate location in the stack and so they are completely independent
            // now lets see reference types

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            //array1 points to the object in the heap. when we copy it,
            //array2 also points to the same object. so any changes affect both
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
       




        }
    }
}
