using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGit
{
    class Moto : Veiculo
    {
        public string Marca { get; set; }

        public Moto(string marca): base(2, 0, "Azul")
        {
            Marca = marca;
        }

        override public void ExibirInfo()
        {
            Console.WriteLine("Moto:");
            Console.WriteLine("Quantidade de rodas da Moto = {0}", Rodas);
            Console.WriteLine("Qunatidade de portas da Moto = {0}", Portas);
            Console.WriteLine("Cor da Moto = {0}", Cor);
            Console.WriteLine("Marca da Moto = {0}", Marca);
        }
    }
}
