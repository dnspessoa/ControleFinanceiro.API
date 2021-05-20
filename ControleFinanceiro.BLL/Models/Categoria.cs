using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.BLL.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string Nome { get; set; }

        public string Icone { get; set; }

        //Categoria tem Tipo
        public int TipoId { get; set; }

        public Tipo Tipo { get; set; }

        //Categoria tem Despesas
        public virtual ICollection<Despesa> Despesas { get; set; }

        //Categoria tem Ganhos
        public virtual ICollection<Ganho> Ganhos { get; set; }
    }
}
