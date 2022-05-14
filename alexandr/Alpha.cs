using System;

namespace att1
{
    public class Alpha
    {
        private string model = "Data";
        private Charlie _charlie;

        public Alpha(Charlie someCharlie)
        {
            this._charlie= new Charlie(360);
            Console.WriteLine("Я конструктор класса Альфа, который имеет отношение КОМПОЗИЦИЯ с классом Чарли");
        }

        public object data()
        {
            Console.WriteLine("Я метод класса Альфа, который вызван из-за зависимости");
            Random random = new Random();
            return random.Next(1, 222);
        }
    }
}