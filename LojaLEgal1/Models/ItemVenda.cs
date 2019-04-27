using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLEgal1.Models
{
    public class ItemVenda
    {
        public IProduto Produto { get; set; }
        public int Quantidade { get; set; }

        public decimal ValorTotalItem
        {
            get
            {
                return Produto.Valor * Quantidade;
            }
        }
    }
}
