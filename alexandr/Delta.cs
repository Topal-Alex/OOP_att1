using System;

namespace att1
{
    public class Delta
    {
        public Delta(Alpha alpha)
        {
            Console.WriteLine("Я метод класса Дельта, который зависим от класса Альфа");
            int data = (int)alpha.data();
        }
    }
}