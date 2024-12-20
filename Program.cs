using System.Text.RegularExpressions;

namespace tamrin5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*i++ => i = i + 1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * 2);
            }*/


            /*int counter = 0;
            for ( ; ;)
            {
                counter ++;
                Console.WriteLine(counter);
            }*/

            /*int z = 0;
            while (z < 5)
            {
                Console.WriteLine(z * 2);
                z++;
            }*/


            /*int k = 0;
            while (true)
            {
                Console.WriteLine(k);
                k++;
            }*/


            /*for (int B = 0; B < 10; B++)
           {
               if (B == 4)
               {
                   break;
               }
               Console.WriteLine(B);
           }*/


            //for (int c = 0; c < 10; c++)
            //{
            //    if (c == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(c);
            //}


            string phoneNumber;
            bool isValid = false;
            do
            {
                Console.WriteLine("Enter Your PhoneNamber:");
                Console.WriteLine("Start from 0 And Up To 11 Digits");
                phoneNumber = Console.ReadLine();
                //phoneNumber.Trim();
                if (Regex.IsMatch(phoneNumber, @"^0\d{10}$"))
                {
                    isValid = true;
                    Console.WriteLine("True, Welcome...");
                }
                else
                {
                    Console.WriteLine("false, Pleas Try Agine");
                }
            } while (!isValid);



            while (true)
            {
                Console.Write("enter Z/z for exit: ");
                char key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (key == 'Z' || key == 'z')
                    break;
            }
        }
    }
}
