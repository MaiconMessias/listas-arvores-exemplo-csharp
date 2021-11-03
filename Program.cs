using System;
using listas_arvores_exemplo_csharp.Exemplos;

namespace listas_arvores_exemplo_csharp
{
    class Program
    {
        static void Main(string[] args) {
            var l = new Filas();
            // Adicionando itens na fila
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.Add(6);
            l.Add(7);
            // Exibe cada valor do atributo item na posicao indicada na lista
            Console.WriteLine("Item da lista na posição 4: " + l.GetFila(4).item);
            Console.WriteLine("Item da lista na posição 1: " + l.GetFila(1).item);
            Console.WriteLine("Item da lista na posição 5: " + l.GetFila(5).item);
            Console.WriteLine("Item da lista na posição 3: " + l.GetFila(3).item);
            Console.WriteLine("Item da lista na posição 0: " + l.GetFila(0).item);
            Arvores a = new Arvores();
            a.Add("arvoreIt1");
            a.Add("arvoreIt2");
            a.Add("arvoreIt3");
            a.Add("arvoreIt4");
            a.Add("arvoreIt5");
            a.Add("arvoreIt6");
            a.Add("arvoreIt7");
            a.Add("arvoreIt8");
            Console.WriteLine("Item do primeiro nó na posição 0: " + a.GetItemPrimeiraArvore(0).item);
            Console.WriteLine("Item do primeiro nó na posição 3: " + a.GetItemPrimeiraArvore(3).item);
            Console.WriteLine("Item do primeiro nó na posição 2: " + a.GetItemPrimeiraArvore(2).item);
            Console.WriteLine("Item do primeiro nó na posição 1: " + a.GetItemPrimeiraArvore(1).item);
        }

    }
}
