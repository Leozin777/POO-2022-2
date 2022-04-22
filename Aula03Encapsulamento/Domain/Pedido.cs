using System;
using System.Collections.Generic;

namespace Aula03Encapsulamento.Domain
{
    public class Pedido
    {
       
        public Pedido(int id, DateTime dataPedido, int status,
            PedidoItem item)
        {
            Id = id;
            DataPedido = dataPedido;
            Status = status;
            PedidosItens.Add(item);
        }

        public int Id { get; set; } 
        public DateTime DataPedido { get; set; }    
        public int Status { get; set; }
        public List<PedidoItem> PedidosItens { get; set; }

        public void AddITem(PedidoItem item)
        {
            PedidosItens.Add(item);
        }

        
    }
}