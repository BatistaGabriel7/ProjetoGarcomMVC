using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosGarcomMvc.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Mesa { get; set; }
        public string Solicitante { get; set; }
        public string Prato { get; set; }
        public int Quantidade_Prato { get; set; }
        public string Bebida { get; set; }
        public int Quantidade_Bebida { get; set; }
        public Copa Copa { get; set; }
        public Cozinha Cozinha { get; set; }



        public Pedido()
        {
        }

        public Pedido(int id, int mesa, string solicitante, string prato, int quantidade_Prato, string bebida, int quantidade_Bebida, Copa copa, Cozinha cozinha)
        {
            Id = id;
            Mesa = mesa;
            Solicitante = solicitante;
            Prato = prato;
            Quantidade_Prato = quantidade_Prato;
            Bebida = bebida;
            Quantidade_Bebida = quantidade_Bebida;
            Copa = copa;
            Cozinha = cozinha;
        }
    }
}
