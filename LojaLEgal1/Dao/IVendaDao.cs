using LojaLEgal1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLEgal1.Dao
{
    public interface IVendaDao
    {

        void Salvar(Venda venda);
        void Atualizar (Venda venda);

        
        List<Venda> BuscarTodos();
    }
}
