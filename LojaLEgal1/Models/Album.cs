using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLEgal1.Models
{
    public class Album : IProduto
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public int QtdMsc { get; set; }

        public decimal Valor {get; set;}
        public string Nome
        {
            get
            {
                return Tipo + " " + Artista;
            }
        }


        public Tipo Tipo { get; set; }
    }
}
