using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLEgal1.Models
{
    public class Livro : IProduto
    {
        public string Titulo {get;set;}
        public string Autor {get;set;}
        public int QuantidadePaginas { get; set; }

        public string Nome
        {
            get
            {
                return Titulo;
            }
        }

        public decimal Valor{get;set;}
    }
}
