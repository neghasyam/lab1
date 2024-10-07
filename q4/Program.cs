using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //Console.WriteLine("enter username");
            //string username = Console.ReadLine();
            //Console.WriteLine("Hello " +username);

            //Console.ReadLine();


            //Console.Write("Enter your fullname");
            //string fullname = Console.ReadLine();

            //Console.Write("Enter your age");
            //string age = Console.ReadLine();

            //Console.Write("Enter your favcolor");
            //string favcolor = Console.ReadLine();

            //Console.WriteLine("Hello " + fullname);
            //Console.WriteLine("You are " + age);
            //Console.WriteLine("Your favcolor is " + favcolor);

            //Console.ReadLine();


            ////Console.WriteLine("Enter the temp in cels");
            //double temp;
            //temp= double.Parse(Console.ReadLine());

            //double fahren;
            //fahren= (temp * 9 / 5) + 32;

            //Console.WriteLine($"fahren is {fahren}");
            //Console.ReadLine();



            //5th To calculate P,R,T



            //Console.Write("Enter the prinAmount:");
            //double P;
            //P = double.Parse(Console.ReadLine());

            //Console.Write("Enter the rateofInterest: ");
            //double R;
            //R = double.Parse(Console.ReadLine());

            //Console.Write("Enter the timeinYears): ");
            //double T;
            //T = double.Parse(Console.ReadLine());


            //double simpleInterest;
            //simpleInterest = P * R * T / 100;


            //Console.WriteLine($"The simpleInterest is: {simpleInterest}");
            //Console.ReadLine();



            //6th


            //Console.Write("Enter the radius");

            //double radius= double.Parse(Console.ReadLine());


            //const double PI = 3.14;

            //double area = PI*radius*radius;
            //Console.WriteLine($"The area of circle is: {area}");
            //Console.ReadLine();


            //9th



            //Console.Write("Enter your weight in kilograms:");
            //double weight = double.Parse(Console.ReadLine());


            //Console.Write("Enter your height in meters: ");
            //double height = double.Parse(Console.ReadLine());

            //double bmi = weight / (height * height);


            //Console.WriteLine($"Your bmi is: {bmi}");
            //Console.ReadLine();



            //11



            //Console.Write("Enter radius of the circle: ");
            //double radius = double.Parse(Console.ReadLine());
            //const double PI = 3.14;
            //double cArea = PI * radius * radius;
            //Console.WriteLine($"The area of the circle is: {cArea}");


            //Console.Write("Enter the length of the rectangle: ");
            //double length = double.Parse(Console.ReadLine());

            //Console.Write("Enter the width of the rectangle: ");
            //double width = double.Parse(Console.ReadLine());

            //double rArea = length * width;
            //Console.WriteLine($"The area of the rectangle is: {rArea}");

            //Console.ReadLine();



            //13



            //Console.Write("Enter the width of the rectangle in inches: ");
            //double width = double.Parse(Console.ReadLine());


            //Console.Write("Enter the height of the rectangle in inches: ");
            //double height = double.Parse(Console.ReadLine());
            //double inch_to_cm;


            //double areaInches = width * height;


            //double areaCentimeters = areaInches * (inch_to_cm * inch_to_cm);


            //Console.WriteLine($"The area of the rectangle is: {areaInches} square inches");
            //Console.WriteLine($"The area of the rectangle is: {areaCentimeters} square centimeters");

            //Console.ReadLine();


            //14


            //Console.WriteLine("Enter the first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the third number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //if (num1 >= num2 && num1 >= num3)
            //{
            //    Console.WriteLine("The largest number is: " + num1);
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    Console.WriteLine("The largest number is: " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("The largest number is: " + num3);
            //    Console.ReadLine();
            //}



            ////2nd print using fo rloop 1,3,5 till 11




            //for (int i = 1; i <= 11; i += 2)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();





            //print *




            //Console.WriteLine("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.WriteLine("*");
            //    }

            //    Console.WriteLine("*");
            //}
            //Console.ReadLine();




            ////sum of 1st natural numbers




            //int sum = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    sum = sum + i;


            //}
            //Console.WriteLine("The sum of 5 natural numbers is" + sum);
            //Console.ReadLine();




            //print the pattern

            //Console.WriteLine("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.WriteLine("*");
            //    }

            //    Console.WriteLine("*");
            //}
            //Console.ReadLine();


            // print 10 20 ....190 continue

            //for (int i = 10; i <= 190; i += 20)
            //{
            //    if (i == 100)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}
            //    Console.ReadLine();



            // print 10 20 ....190 break



            //for (int i = 10; i <= 190; i += 20)
            //{
            //    if (i == 100)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();



            // print odd or even using switch


            //Console.WriteLine("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //switch (n % 2)
            //{
            //    case 0: 
            //        Console.WriteLine($"{n} is even.");
            //        break;
            //    case 1: 
            //        Console.WriteLine($"{n} is odd.");
            //        break;
            //    default: 
            //        Console.WriteLine("Unexpected value.");
            //        break;
            //}


            //Console.ReadLine();


            // find error

            int[] n = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < n.Length; i++) 
            {
                Console.WriteLine(n[i]);
            }
            Console.ReadLine();



            // Lab 14



            //string name;
            //int age;
            //decimal salary;

            
            //Console.Write("Enter employee's name: ");
            //Name = Console.ReadLine();

            
            //Console.Write("Enter employee's age: ");
            //Age = Convert.ToInt32(Console.ReadLine());

            
            //Console.Write("Enter employee's monthly salary: ");
            //employeeSalary = Convert.ToDecimal(Console.ReadLine());

            
            //Console.WriteLine("\nEmployee Details:");
            //Console.WriteLine($"Name: {employeeName}");
            //Console.WriteLine($"Age: {employeeAge}");
            //Console.WriteLine($"Monthly Salary: {employeeSalary:C}");

            
            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey();






        }
    }
}















