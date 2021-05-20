using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.BLL.Models
{
    public class Usuario : IdentityRole<string>
    {
        public string CPF { get; set; }

        public string Profissao { get; set; }

        public byte[] Foto { get; set; }


        //Usuario tem Cartao
        public virtual ICollection<Cartao> Cartoes { get; set; }

        //Usuari tem Ganho
        public virtual ICollection<Ganho> Ganhos { get; set; }

        //Usuario tem Despesa
        public virtual ICollection<Despesa> Despesas { get; set; }
    }
}
