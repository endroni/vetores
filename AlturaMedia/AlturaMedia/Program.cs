using System;
using System.Globalization;

namespace AlturaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // sintaxe
            // tipo[] nomeDoVetor = new tipo[tamanho];
            double[] altura = new double[n];

            // sintaxe do for 
            // for (inicio; condicional; incremento)

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += altura[i];
            }

            double media = soma / 3;
            Console.WriteLine("A média das alturas é = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
