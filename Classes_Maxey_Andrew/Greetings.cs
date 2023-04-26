using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Maxey_Andrew
{
    class Greetings
    {/// <summary>
    /// 
    /// </summary>
        // Public Void (Name) = Method
        public void Welcome()
        {
            Console.WriteLine("Hello Traveler, Welcome");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us today! Take this sword its dangerous to go alone.");
        }

    }
}
