using System;

namespace REceberPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInforme os dados do seu Pedido:");
            Console.WriteLine("\nInforme  o nome do Prduto:");
            string Nome = Console.ReadLine();
            Console.WriteLine("\nInforme  a quantidade do Prduto:");
            int Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme  o preço do Prduto:");
            double Preco = double.Parse(Console.ReadLine());
            double ValorTotal = 0;

            if (Quantidade <= 10)
            {
                ValorTotal = (Preco * Quantidade);
            }
            else if (Quantidade > 10 && Quantidade <= 20) 
            {
                ValorTotal = Quantidade * Preco - (Quantidade * Preco * 0.1 );
            }
            else if(Quantidade >20 && Quantidade <=50)
            {
                ValorTotal = Quantidade * Preco - (Quantidade * Preco * 0.20);
            }
            else
            {
                ValorTotal = Quantidade * Preco - (Quantidade * Preco * 0.25);


            }
            Console.WriteLine($"\n O none do produto é: {Nome} e o Valor total dp seu pedido é R$ : {ValorTotal.ToString("F2")}");


        }
    }
}
