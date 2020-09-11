using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_5
{
    class Number
    {
        private int Num;
        public Number(int number)
        {
            Num = number;
        }
        public int findGolomb(int n)
        {

            // base (condição)
            if (n == 1)
                return 1;

            /* formula 
            * 1° = n-1
            * 2 vai chamar um loop até alcancar o numero 1;
            * 3 para fechar o loop a condição precisa ser ingual a ==1
            */
            return 1 + findGolomb(n - findGolomb(findGolomb(n - 1)));
        }

        public void printGolomb()
        {
            for (int i = 1; i <= Num; i++)
                Console.Write(findGolomb(i) + " ");
        }
    }
}
