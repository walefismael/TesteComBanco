using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLEgal1.Models
{
    public class Venda
    {
        public List<ItemVenda> Itens { get; private set; }

        public Venda()
        {
            Itens = new List<ItemVenda>();
        }
        public decimal Total { get {
            decimal total = 0;
            foreach (ItemVenda i in Itens)
            {
                total += i.Produto.Valor * i.Quantidade;
            }
            return total;
        } }
        public void AdicionarProduto(IProduto produto, int quantidade)
        {
            Itens.Add(new ItemVenda()
            {
                Produto = produto,
                Quantidade = quantidade
            });
        }
    }
}
