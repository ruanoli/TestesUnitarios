using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2) => num1 + num2;

        public int Subtrair(int num1, int num2) => num1 - num2;

        public bool EhPar(int num) => num % 2 == 0;

    }

}