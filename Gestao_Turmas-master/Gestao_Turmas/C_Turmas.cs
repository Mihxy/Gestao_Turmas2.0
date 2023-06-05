using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Turmas
{
    public class C_Turmas
    {
        public string? NomeTurma { get; set; }
        public int AnoEscolar { get; set; }
        public List<Alunos>? Alunos { get; set; }
        public List<Disciplinas>? Disciplinas { get; set; }

    }
}
