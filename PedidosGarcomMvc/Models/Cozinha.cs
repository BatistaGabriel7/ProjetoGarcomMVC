using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosGarcomMvc.Models
{
    public class Cozinha
    {
        public int Id { get; set; }
        public int Mesa { get; set; }
        public string Prato { get; set; }
        public int Quantidade { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public Cozinha()
        {
        }

        public Cozinha(int id, int mesa, string prato, int quantidade)
        {
            Id = id;
            Mesa = mesa;
            Prato = prato;
            Quantidade = quantidade;
        }

        public void AddPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
    }
}
