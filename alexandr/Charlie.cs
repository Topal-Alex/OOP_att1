using System;

namespace att1
{
    public class Charlie : IBravo
    {
        public int power;
        public Charlie (int p)
        {
            power = p;
        }
        
        public void HelloWorld()
        {
            Console.WriteLine("Я метод класса Чарли, который наследуется от интерфейса Браво");
        }
    }
}