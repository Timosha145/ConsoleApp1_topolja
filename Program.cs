using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_topolja
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket="täispilet";
            double price = 10;
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine($"Your Name {name}");
            if (name.ToLower()=="juku")
            {
                Console.WriteLine("Hello! Go to park for money?");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "YES" || answer.ToUpper()=="MAYBE")
                {
                    Console.WriteLine("How old are you?");
                    int old = int.Parse(Console.ReadLine());
                    if (old<6 || old>=65 && old<=108)
                    {
                        price -= price * 1;
                        ticket = "tasuta";
                    }
                    else if (old>=6 && old<12)
                    {
                        price -= price * 0.3;
                        ticket = "lastepilet";
                    }
                    else if (old>=12 && old<=18)
                    {
                        price -= price * 0.1;
                        ticket = "täispilet";
                    }
                    else if (old<0||old>108)
                    {
                        Console.WriteLine("Not real!");
                        price += price * 99;
                    }
                    char[] characters = name.ToCharArray();
                    int i = 0;
                    name = "";
                    foreach (var t in characters)
                    {
                        if (i==0)
                        {
                            name += t.ToString().ToUpper();
                        }
                        else
                        {
                            name += t.ToString().ToLower();
                        }
                        i += 1;
                    }
                    Console.WriteLine($"Mr. {name} please give me {price} bucks! for {ticket}",name,price,Console.Title);
                }
            }
            else
            {
                Console.WriteLine("I dont know you!");    
            }
            Console.ReadLine();
        }
    }
}
