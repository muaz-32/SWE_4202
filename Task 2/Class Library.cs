using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Class_Library
    {
    }
    internal class Staff
    {
        public int code { get; set; }
        public string name { get; set; }
        public void whoAmI()
        {
            Console.WriteLine("I am a Staff");
        }

    }
    internal class Typist : Staff
    {
        public int speed { get; set; }
        public void whoAmI()
        {
            Console.WriteLine("I am a Typist - Staff");
        }
    }
    internal class Officer : Staff
    {
        public int grade { get; set; }
        public void whoAmI()
        {
            Console.WriteLine("I am a Officer - Staff");
        }
    }
    internal class Teacher : Staff
    {
        public string subject { get; set; }
        public string publication { get; set; }
        public void whoAmI()
        {
            Console.WriteLine("I am a Teacher - Staff");
        }
    }
    internal class Regular : Typist
    {
        public void whoAmI()
        {
            Console.WriteLine("I am a Regular - Typist - Staff");
        }
    }
    internal class Casual : Typist
    {
        public int dailyWages { get; set; }
        public void whoAmI()
        {
            Console.WriteLine("I am a Casual - Typist - Staff");
        }
    }

}
