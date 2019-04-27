using LojaLEgal1.Dao;
using LojaLEgal1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLEgal1.Servico
{
    public class VendaServico
    {
        private IVendaDao vendaDao;

        public VendaServico(IVendaDao vendaDao)
        {
            this.vendaDao = vendaDao;
        }
        public decimal TotalDeTotasAsVendas()
        {
            decimal total = 0;
            foreach (Venda v in vendaDao.BuscarTodos())
            {
                total += v.Total;
            }
            return total;
        }
    }
}
