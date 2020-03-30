using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Business
{
    public class PedidoBl
    {
        public string RetornarStatusPedido(StatusPedido status)
        {
            string retorno = string.Empty;
            switch (status)
            {
                case StatusPedido.NoCarrinho:
                    retorno = "EM COMPRA";
                    break;
                case StatusPedido.EmPagamento:
                    retorno = "AGUARDANDO PAGAMENTO";
                    break;
                case StatusPedido.Concluido:
                    retorno = "FINALIZADO";
                    break;
                default:
                    retorno = "NÃO RECONHECIDO";
                    break;


            }
            return retorno;
        }

    }
}
