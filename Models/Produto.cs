using System.ComponentModel.DataAnnotations;
using System;

namespace PetShopApp.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public string QuantidadeEstoque {get; set;}
        public string PrecoCompra {get; set;}
        public string PrecoVenda {get; set;}
    }
}