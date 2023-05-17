using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGit
{
    class Carro : Veiculo
    {
        public string Marca { get; set; }

        public Carro(string marca) : base(4, 2, "Branco")
        {
            Marca = marca;
        }

        override public void ExibirInfo()
        {
            Console.WriteLine("Carro:");
            Console.WriteLine("Quantidade de rodas do Carro = {0}", Rodas);
            Console.WriteLine("Qunatidade de portas do Carro = {0}", Portas);
            Console.WriteLine("Cor do Carro = {0}", Cor);
            Console.WriteLine("Marca do Carro = {0}", Marca);
        }
    }
}
