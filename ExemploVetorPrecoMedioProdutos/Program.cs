using System;
using System.Globalization;

namespace ExemploVetorPrecoMedioProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            //Declaração da variável do tipo vetor
            //Quando instancia somente o valor, ele vem com as posições nulas
            Produto[] vet = new Produto[n];
            
            for(int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //instanciação da classe produto passando os atributos
                //pode-se usar os construtores
                vet[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for(int i = 0; i < n; i++)
            {
                soma = soma + vet[i].Preco;
            }

            double avg = soma / n;
            Console.WriteLine("AVARAGE PRICE = " +avg.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
