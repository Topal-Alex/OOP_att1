using System;

namespace att1
{
    public class Echo : IBravo
    {
        public void HelloWorld()
        {
            Console.WriteLine("Я метод, который принадлежит классу Эхо, который наследуется от интерфейса Браво");
        }
    }
}