using System;
using System.Globalization;

namespace VetorProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // sintaxe do vetor, lembra?
            // tipo[] nomeVetor = new tipo[tamanho]
            Produto[] prod = new Produto[n]; 

            for ( int i = 0; i < n; i++ )
            {   
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                prod[i] = new Produto(nome, preco);
            }

            double soma = 0.0;

            for ( int i = 0; i < n; i++ )
            {
                soma += prod[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine("A média dos preços é R$ " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
