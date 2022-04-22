namespace Aula03Encapsulamento.Domain
{
    public class PedidoItem
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }   
        public decimal Quantidade { get; set; } 

    }
}