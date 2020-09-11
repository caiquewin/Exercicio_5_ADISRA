using System;

namespace Exercício_5
{

    class program
    {
        public static void Main()
        {
            Console.Write("Entrada: ");
            Number number = new Number(int.Parse(Console.ReadLine()));
            number.printGolomb();
        }
    }



}
