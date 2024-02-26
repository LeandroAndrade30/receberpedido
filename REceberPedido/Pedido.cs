using System;
using System.Collections.Generic;
using System.Text;

namespace ReceberPedido
{
    class Pedido
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public  double CalcularValorTotal()
        {
            double ValorTotal = 0;


            if (Quantidade <= 10)
            {
                ValorTotal = (Preco * Quantidade);
            }
            else if (Quantidade > 10 && Quantidade <= 20)
            {
                ValorTotal = Quantidade * Preco - (Quantidade * Preco * 0.1);
            }
            else if (Quantidade > 20 && Quantidade <= 50)
            {
                ValorTotal = Quantidade * Preco - (Quantidade * Preco * 0.20);
            }
            else
            {
                ValorTotal = Quantidade * Preco - (Quantidade * Preco * 0.25);


            }
            return ValorTotal;
        }

    }
}
