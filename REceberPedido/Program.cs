using System;

namespace ReceberPedido
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("\nInforme os dados do seu Pedido:");
            Console.WriteLine("\nInforme  o nome do Prduto:");
             string nome = Console.ReadLine();
            Console.WriteLine("\nInforme  a quantidade do Prduto:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme  o preço do Prduto:");
            double preco = double.Parse(Console.ReadLine());
            Pedido Pedido = new Pedido(nome,quantidade,preco);
            Console.WriteLine(Pedido);






        }


    }
}

