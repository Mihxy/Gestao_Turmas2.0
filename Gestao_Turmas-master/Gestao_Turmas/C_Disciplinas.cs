using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Turmas
{
    public class C_Disciplinas
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int CargaHoraria { get; set; }
        public List<Professores>? Professores { get; set; }
        public List<double>? Notas { get; set; }
        public List<Turmas>? Turmas { get; set; }

    }
}
