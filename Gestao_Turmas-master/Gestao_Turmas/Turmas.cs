using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Turmas
{
    public partial class Turmas : Form
    {
        string caminho = @"c:\C\Cprojetos\Gestao_Turmas\turmas.txt";
        C_Turmas auxnovo = new C_Turmas();
        List<C_Turmas> list = new List<C_Turmas>();
        public Turmas()
        {
            InitializeComponent();
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            Menu anterior = new Menu();
            anterior.Show();
            Hide();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            auxnovo.NomeTurma = txt_nome_turma.Text;
            string ano_escolar = txt_ano_escolar.Text;
            var numerico = int.TryParse(ano_escolar, out _);
            if (numerico)
            {
                auxnovo.AnoEscolar = Convert.ToInt32(ano_escolar);
            }
            else
            {
                MessageBox.Show("Introduza apenas números");
                return;
            }

            list.Add(auxnovo);

            string auxlista = JsonSerializer.Serialize(list);
            File.WriteAllText(caminho, auxlista);

        }

        private void Turmas_Load(object sender, EventArgs e)
        {
            try
            {
                string auxtxt = File.ReadAllText(caminho);
                list = JsonSerializer.Deserialize<List<C_Turmas>>(auxtxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ainda não existem dados", "Aviso!");
            }

            dgv_turmas.DataSource = list;
        }

    }
}
