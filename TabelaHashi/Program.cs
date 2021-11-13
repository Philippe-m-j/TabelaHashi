using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TabelaHashi
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicao;

            List<produto>[] Cadastro = new List<produto>[8];

            for(int i = 0; i < 8; i++)
            {
                Cadastro[i] = new List<produto>();
            }

            produto x;

            //Colocar 5 elementos no vetor cadastro

            x = new produto();
            x.le();
            posicao = x.numero % 8;
            Cadastro[posicao].Add(x);

            x = new produto();
            x.le();
            posicao = x.numero % 8;
            Cadastro[posicao].Add(x);

            x = new produto();
            x.le();
            posicao = x.numero % 8;
            Cadastro[posicao].Add(x);

            x = new produto();
            x.le();
            posicao = x.numero % 8;
            Cadastro[posicao].Add(x);

            x = new produto();
            x.le();
            posicao = x.numero % 8;
            Cadastro[posicao].Add(x);

            Console.Clear();

            foreach(List<produto> lista in Cadastro)
            {
                if (lista.Count != 0)
                {
                    Console.WriteLine();

                    foreach(produto P in lista)
                    {
                        P.mostra();
                    }
                }
            }

            Console.ReadKey();

            int chave;

            Console.Write("\n\nRetirar qual chave?");
            chave = int.Parse(Console.ReadLine());

            foreach(List<produto> lista in Cadastro)
            {
                if(lista.Count != 0)
                {
                    foreach(produto P in lista)
                    {
                        if (P.numero == chave)
                        {
                            x = P;
                        }
                    }
                    lista.Remove(x);
                }
            }

            Console.Clear();

            foreach (List<produto> lista in Cadastro)
            {
                if (lista.Count != 0)
                {
                    Console.WriteLine();

                    foreach (produto P in lista)
                    {
                        P.mostra();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
