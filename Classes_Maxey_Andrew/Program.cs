using System;

namespace Classes_Maxey_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Greetings greetings = new Greetings(); //
            //
            greetings.Welcome();

            //
            Console.WriteLine("What is your name traveler?");
            string userName = Console.ReadLine();

            //
            greetings.Hello(char.ToUpper(userName[0]) + userName.Substring(1));

            Console.WriteLine($"+1 Copper Sword added to {char.ToUpper(userName[0]) + userName.Substring(1)}'s inventory");



        }
    }
}
