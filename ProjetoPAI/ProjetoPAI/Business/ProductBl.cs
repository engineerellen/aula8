using System;
using Model;

namespace Business
{
 
    public class ProductBl
    {
 
        public double CalcularTotalCompra(double valorTotalProdutos , double discount ,TipoProduto tp, string cupom)
        {
            return valorTotalProdutos + CalcularFrete(tp) - ValidarCupom(cupom);
        }

        private double CalcularFrete(TipoProduto tp)
        {
            switch (tp)
            {
                case TipoProduto.Eletrodomestico:
                    return 20.00;
                case TipoProduto.Casa:
                case TipoProduto.Celulares:
                    return 15.00;
                case TipoProduto.Jardinagem:
                    return 13.00;
                default:
                    return 10.00;
            }
        }

        public double ValidarCupom(string cupom)
        {
            switch (cupom.ToUpper())
            {
                case "10PORCENTO":
                    return 0.1;
                   
                case "20PORDENTO":
                    return 0.2;
                  
                default:
                    return 0;
                    
            }
        }
    }
}
