using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Turmas
{
    public class C_Professores
    {
        public string? Nome { get; set; }
        public string? Genero { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public List<Disciplinas>? Disciplinas { get; set; }
        public List<Turmas>? Turmas { get; set; }


    }
}
