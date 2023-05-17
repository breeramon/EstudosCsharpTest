using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de rodas do veiculo: ");
            int Rodas = int.Parse(Console.ReadLine());

            Console.Write("Número de portas: ");
            int Portas = int.Parse(Console.ReadLine());

            Console.Write("Cor do veiculo: ");
            string Cor = Console.ReadLine();

            Console.WriteLine("");

            Veiculo veiculo1 = new Veiculo(Rodas, Portas, Cor);
            veiculo1.ExibirInfo();

            Console.WriteLine("");

            Carro carro1 = new Carro("Ford");
            carro1.ExibirInfo();

            Console.ReadKey();
        }
    }
}
