using System;
using System.Collections.Generic;

namespace SuperMercado
{
    public class Pedido
    {
        public int id { get; set; }
        public DateTime DataEmissao { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Itens { get; set; }
    }
}