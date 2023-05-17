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

        public void ExibirInfo()
        {
            Console.WriteLine("Rodas = {0}", Rodas);
            Console.WriteLine("Portas = {0}", Portas);
            Console.WriteLine("Cor = {0}", Cor);
            Console.WriteLine("Marca = {0}", Marca);
        }
    }
}
