using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosGarcomMvc.Models
{
    public class Copa 
    {
        public int Id { get; set; }
        public int Mesa { get; set; }
        public string Bebida { get; set; }
        public int Quantidade { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public Copa()
        {
        }

        public Copa(int id, int mesa, string bebida, int quantidade)
        {
            Id = id;
            Mesa = mesa;
            Bebida = bebida;
            Quantidade = quantidade;
        }

        public void AddPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
    }
}
