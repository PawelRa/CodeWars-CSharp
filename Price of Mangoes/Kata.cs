using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_of_Mangoes
{
    public class Kata
    {
        public static int Mango(int quantity, int price)
        {
            return (quantity - (quantity / 3)) * price;
        }
    }
}
