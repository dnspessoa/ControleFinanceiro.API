using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.BLL.Models
{
    public class Despesa
    {
        public int DespesaId { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public int Dia { get; set; }

        public int Ano { get; set; }

        //Despesa tem Cartao
        public int CartaoId { get; set; }

        public Cartao Cartao { get; set; }

        //Despesa tem Categoria
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        //Despesa tem Mes
        public int MesId { get; set; }

        public Mes Mes { get; set; }

        //Despesa tem Usuario
        public string UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
