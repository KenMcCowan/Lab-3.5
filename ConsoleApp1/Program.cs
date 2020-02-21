using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myFirstNumber = 19;

            int mySecondNumber = 244;

            Console.WriteLine(myFirstNumber * mySecondNumber);

            string myText = "Some Text";

            Console.WriteLine(myText + mySecondNumber);

            string moreText = "Goes Here";

            Console.WriteLine(myText + moreText);
            Console.WriteLine(myText + " " + moreText);

            string color1 = "Yellow";
            string color2 = "Green";

            bool isYellow = false;
            bool isGreen = true;

            Console.WriteLine(isYellow + " " + color1);
            Console.WriteLine(isGreen + " " + color2);

            Console.WriteLine(mySecondNumber / myFirstNumber);

            double numbers = 1;

            Console.WriteLine(mySecondNumber / (double)myFirstNumber);

            Console.WriteLine(numbers);

            string textToNumber = "80473";

            int results = 99 * int.Parse(textToNumber);

            DateTime rightNow = DateTime.Now;

            //Console.WriteLine("Hello " + Console.ReadLine());
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello");
            //Console.WriteLine(userName);

            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look younger than " + userAge + "!");






        }
    }
}
