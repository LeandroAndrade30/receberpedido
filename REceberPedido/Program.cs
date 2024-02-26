using System;

namespace ReceberPedido
{
    class Program
    {
        static void Main(string[] args)
        {

            Pedido Pedido = new Pedido();

            Console.WriteLine("\nInforme os dados do seu Pedido:");
            Console.WriteLine("\nInforme  o nome do Prduto:");
            Pedido.Nome = Console.ReadLine();
            Console.WriteLine("\nInforme  a quantidade do Prduto:");
            Pedido.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme  o preço do Prduto:");
            Pedido.Preco = double.Parse(Console.ReadLine());
            double ValorTotal = Pedido.CalcularValorTotal();
            Console.WriteLine($"\n O none do produto é: {Pedido.Nome} e o Valor total dp seu pedido é R$ : {ValorTotal.ToString("F2")}");






        }


    }
}

