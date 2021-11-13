using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaHashi
{
    class produto
    {
        public int numero;
        public string descricao;

        public void mostra()
        {
            Console.WriteLine("{0} - {1}", this.numero,this.descricao);
        }

        public void le()
        {
            Console.Write("\nNúmero do produto:");
            this.numero = int.Parse(Console.ReadLine());

            Console.Write("Descrição..........:");
            this.descricao = Console.ReadLine();
        }
    }

    


}
