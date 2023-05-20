using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_to_the_City
{
    public class Kata
    {
        public static string SayHello(string[] name, string city, string state)
        {
            string namesList = "";

            for (int i = 0; i < name.Length - 1; i++)
            {
                namesList += name[i];
                namesList += " ";
            }
            namesList += name[name.Length - 1];

            return $"Hello, {namesList}! Welcome to {city}, {state}!";
        }
    }
}
