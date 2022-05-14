using System;

namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {
            Charlie charlie = new Charlie(12);
            charlie.HelloWorld();

            Alpha alpha = new Alpha(charlie);
            alpha.data();

            Delta delta = new Delta(alpha);

            Echo echo = new Echo();
            echo.HelloWorld();
        }
    }
}
