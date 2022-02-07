using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTasks_topolja
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ticket = "täispilet";
            //double price = 10;
            //Console.WriteLine("Name");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Your Name {name}");
            //if (name.ToLower() == "juku")
            //{
            //    Console.WriteLine("Hello! Go to park for money?");
            //    string answer = Console.ReadLine();
            //    if (answer.ToUpper() == "YES" || answer.ToUpper() == "MAYBE")
            //    {
            //        Console.WriteLine("How old are you?");
            //        int old = int.Parse(Console.ReadLine());
            //        if (old < 6 || old >= 65 && old <= 108)
            //        {
            //            price -= price * 1;
            //            ticket = "tasuta";
            //        }
            //        else if (old >= 6 && old < 12)
            //        {
            //            price -= price * 0.3;
            //            ticket = "lastepilet";
            //        }
            //        else if (old >= 12 && old <= 18)
            //        {
            //            price -= price * 0.1;
            //            ticket = "täispilet";
            //        }
            //        else if (old < 0 || old > 108)
            //        {
            //            Console.WriteLine("Not real!");
            //            price += price * 99;
            //        }
            //        char[] characters = name.ToCharArray();
            //        int i = 0;
            //        name = "";
            //        foreach (var t in characters)
            //        {
            //            if (i == 0)
            //            {
            //                name += t.ToString().ToUpper();
            //            }
            //            else
            //            {
            //                name += t.ToString().ToLower();
            //            }
            //            i += 1;
            //        }
            //        Console.WriteLine($"Mr. {name} please give me {price} bucks! for {ticket}", name, price, Console.Title);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("I dont know you!");
            //}

            //Console.WriteLine("First person name?");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("Second person name?");
            //string name2 = Console.ReadLine();
            //if (name1=="Artjom" && name2=="Timofei" || name1 == "Artjom" && name2 == "Timofei")
            //{
            //    Console.WriteLine("They sit together");
            //}
            //else if (name1 == "Angelina" && name2 == "Ilja" || name1 == "Angelina" && name2 == "Ilja")
            //{
            //    Console.WriteLine("They sit together");
            //}
            //else if (name1 == "Ilja" && name2 == "Anton" || name1 == "Ilja" && name2 == "Anton")
            //{
            //    Console.WriteLine("They sit together");
            //}
            //else if (name1 == "Artjom" && name2 == "Denis" || name1 == "Artjom" && name2 == "Denis")
            //{
            //    Console.WriteLine("They sit together");
            //}
            //else 
            //{
            //    Console.WriteLine("Don't sit together");
            //}

            //Console.WriteLine("Do you want euro remont?");
            //string answer = Console.ReadLine();
            //if (answer.ToLower() == "yes")
            //{
            //    Console.WriteLine("Length of first wall in meters?");
            //    double Firstwall = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Length of second wall in meters?");
            //    double Secondwall = double.Parse(Console.ReadLine());
            //    double S = Firstwall * Secondwall;
            //    Console.WriteLine("How much money for 1 m2?");
            //    double m2price = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"Floor price is {S * m2price}£");
            //}
            //else
            //{
            //    Console.WriteLine("Bye Bye!");
            //}

            //Console.WriteLine("Which price with 30% sale?");
            //double salePrice = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Price without 30% sale is {salePrice*1.3}$");

            //Console.WriteLine("Temperature?");
            //double temperature = double.Parse(Console.ReadLine());
            //if (temperature>18)
            //{
            //    Console.WriteLine("More than 18C");
            //}
            //else if(temperature==18)
            //{
            //    Console.WriteLine("is 18C");
            //}
            //else
            //{
            //    Console.WriteLine("Less than 18C");
            //}

            //Console.WriteLine("Your height? (in cm)");
            //double height = double.Parse(Console.ReadLine());
            //if (height<170&&height>0)
            //{
            //    Console.WriteLine("Small");
            //}
            //else if (height>185&&height<300)
            //{
            //    Console.WriteLine("High");
            //}
            //else if(height>=170&&height<=185)
            //{
            //    Console.WriteLine("Medium");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong height");
            //}

            double priceMilk = 1.2;
            double priceBread = 0.8;
            double priceBun = 0.45;
            double price = 0;
            while (true)
            {
                Console.WriteLine("Do you want to buy some milk or bread or bun?");
                string product = Console.ReadLine();
                if (product.ToLower()=="milk")
                {
                    price = +priceMilk;
                }
                else if (product.ToLower() == "bread")
                {
                    price = +priceBread;
                }
                else if (product.ToLower() == "bun")
                {
                    price = +priceBun;
                }
                Console.WriteLine("Anything else? (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower()=="n")
                {
                    break;
                }
            }
            Console.WriteLine($"You have to pay: {price}$");

            Console.ReadLine();
        }
    }
}
