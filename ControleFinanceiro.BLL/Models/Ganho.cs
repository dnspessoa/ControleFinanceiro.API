using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.BLL.Models
{
    public class Ganho
    {
        public int GanhoId { get; set; }

        public string Descricao { get; set; }

        public double valor { get; set; }

        public int Dia { get; set; }

        public int Ano { get; set; }

        //Ganho tem Categoria
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        //Ganho tem Mes
        public int MesId { get; set; }

        public Mes Mes { get; set; }

        //Ganho tem Usuario
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
