using System;


namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instruction below.");

            Console.WriteLine("What is the package weight?");

            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50.00)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("what is the package width?");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is the package height?");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is the package length?");
            double length = Convert.ToDouble(Console.ReadLine());

            double dimen = (width * height * length) * weight / 100.00;

            if (width > 50.00 || length > 50.00 || height > 50.00)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: {0:c}", dimen);
                Console.WriteLine("Thank you!");
                Console.ReadLine();

            }




            //int currenTemp = 70;
            //int roomTemp = 70;
            //if(currenTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly  room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is  not exactly  room temperature");
            //}
            //Console.ReadLine();



            //if (currenTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly  room temperature");
            //}
            //else if (currenTemp  > roomTemp)
            //{
            //    Console.WriteLine("It is warmer  room temperature");
            //}
            //else if (roomTemp > currenTemp)
            //{
            //    Console.WriteLine("room temp is warmer  current  temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is  not exactly  room temperature");
            //}


            //int currenTemp = 78;
            //int roomTemp = 70;
            //string comparisonResult = currenTemp == roomTemp ?
            //    "It is room temp" : "it is not room temp";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();


            //int roomTemp = 70;
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("hi, " + name + ", what is the temp where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());
            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exaclty room temp");
            //}
            //else  if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("uhhhh. some thing went wrong");
            //}
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "you have an awesome number" : "you do not have an awersome number";
            //Console.WriteLine(result);
            //Console.ReadLine();








        }
    }
}
