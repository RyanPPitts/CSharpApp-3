using System;

namespace CSharpApp_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            do
            {
                Console.Write("Enter a Number between 1 & 10 : ");
                numberGuessed = Convert.ToInt32
                    (Console.ReadLine());
            } while (secretNumber != numberGuessed);

            //   (part2)While loop
            //     int i = 1;
            //     while(i <= 10)
            //{
            //    if(i % 2 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    if (i == 9) break;
            //    Console.WriteLine(i);
            //    i++;
            //}
            //    (part1)int age = 17;
            //    bool canDrive = age > 16 ? true : false;
            //    switch(age)
            //        //conditional statements
            //    {
            //        case 1:
            //        case 2:
            //            Console.WriteLine("Go to Day Care");
            //            break;
            //        case 3:
            //        case 4:
            //            Console.WriteLine("Go To Preschool");
            //            break;
            //        case 5:
            //            Console.WriteLine("Go to kindergarden");
            //            break;
            //        default:
            //            Console.WriteLine("Go to another school");
            //            goto OtherSchool;
            //    }
            //      OtherSchool:
            //    Console.WriteLine("Elementary, Middle, High School");
            //    string name = "Derek";
            //    string name2 = "Derek";
            //    if(name.Equals(name2, StringComparison.Ordinal))
            //    {
            //        Console.WriteLine("Names are equal");
            //    }
            //    if ((age >= 5) && (age <= 7))
            //    {
            //        Console.Write("Go To Elementary School");
            //    }
            //    else if ((age > 7) && (age < 13))
            //    {
            //        Console.Write("Go to Middle School");
            //    }
            //    else if ((age > 13) && (age < 19)) ;
            //    {
            //        Console.Write("Go to college");
            //    }
            //    if ((age < 14) || (age < 19))
            //    {
            //        Console.Write("You shouldn't work");
            //    }
            //    (/part1) Console.WriteLine("! true = " + (!true));

            Console.ReadLine();
        }
    }
}
