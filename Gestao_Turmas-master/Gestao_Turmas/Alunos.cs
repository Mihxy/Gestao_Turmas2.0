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
using System.Xml;

namespace Gestao_Turmas
{
    public partial class Alunos : Form
    {
        string caminho = @"c:\C\Cprojetos\Gestao_Turmas-master\alunos.txt";
        List<C_Alunos> info_alunos = new List<C_Alunos>();
        List<C_Turmas> turmas = new List<C_Turmas>();
        public Alunos()
        {
            InitializeComponent();
        }

        public void bt_menu_Click(object sender, EventArgs e)
        {
            Menu anterior = new Menu();
            anterior.Show();
            Hide();
        }

        public void bt_adicionar_Click(object sender, EventArgs e)
        {
            C_Alunos auxnovo = new C_Alunos();

            if (txt_nome_alunos.Text != "" && txt_email_alunos.Text != "" && txt_contacto_alunos.Text != "" && txt_num_aluno.Text != "" && check_genero.CheckedItems.Count != 0)
            {
                var alfa = int.TryParse(txt_nome_alunos.Text, out _);
                if (alfa)
                {
                    MessageBox.Show("Introduza apenas letras!", "Nome Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    auxnovo.Nome = txt_nome_alunos.Text;
                }

                if (txt_email_alunos.Text.Contains('@'))
                {
                    auxnovo.Email = txt_email_alunos.Text;
                }
                else
                {
                    MessageBox.Show("Introduza um formato correto", "Email Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                auxnovo.Contacto = txt_contacto_alunos.Text;
                auxnovo.DtNascimento = dt_nasc.Value;

                var numerico = int.TryParse(txt_num_aluno.Text, out _);
                if (numerico)
                {
                    auxnovo.NumAluno = Convert.ToInt32(txt_num_aluno.Text);
                }
                else
                {
                    MessageBox.Show("Introduza apenas números", "Número de Aluno Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (string item_check in check_genero.CheckedItems)
                {
                    auxnovo.Genero = item_check;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            info_alunos.Add(auxnovo);

            string auxlista = JsonSerializer.Serialize(info_alunos);
            File.WriteAllText(caminho, auxlista);

            dgv_alunos.DataSource = null;
            dgv_alunos.DataSource = info_alunos;
        }

        public void Alunos_Load(object sender, EventArgs e)
        {
            dt_nasc.MaxDate = DateTime.Now.Date.AddDays(-365);
            dt_nasc.Value = dt_nasc.MaxDate;

            check_genero.Items.Add("Masculino");
            check_genero.Items.Add("Feminino");
            check_genero.CheckedItems.Contains("Masculino");
            check_genero.CheckedItems.Contains("Feminino");

            try
            {
                string auxtxt = File.ReadAllText(caminho);
                info_alunos = JsonSerializer.Deserialize<List<C_Alunos>>(auxtxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ainda não existem dados", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgv_alunos.DataSource = info_alunos;
            cb_turmas.DataSource = turmas.Select(x => x.NomeTurma).Distinct().ToList();

        }

        private void cb_turmas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void check_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemx = 0; itemx < check_genero.CheckedItems.Count; itemx++)
            {
                if (itemx != check_genero.SelectedIndex)
                {
                    check_genero.SetItemCheckState(itemx, CheckState.Unchecked);
                }
            }
        }

        private void dgv_alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
