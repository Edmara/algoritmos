using System;
using System.Collections.Generic;

namespace PesquisaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int?>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var numero = PesquisaBinaria(numbers, 6);

        }

        static int? PesquisaBinaria(List<int?> lista, int numero)
        {
            var baixo = 0;
            var alto = lista.Count - 1;

            while (baixo <= alto)
            {
                var meio = (baixo + alto) / 2;
                var chute = lista[meio];

                if (chute == numero)
                    return meio;
                if (chute > numero)
                    alto = meio - 1;
                else
                    baixo = meio + 1;
            }
            return null;
        }
    }
}
