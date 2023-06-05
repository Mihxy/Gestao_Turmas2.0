namespace Gestao_Turmas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_alunos_Click(object sender, EventArgs e)
        {
            Alunos proximo = new Alunos();
            proximo.Show();
            Hide();
        }

        private void bt_disciplinas_Click(object sender, EventArgs e)
        {
            Disciplinas proximo = new Disciplinas();
            proximo.Show();
            Hide();
        }

        private void bt_turmas_Click(object sender, EventArgs e)
        {
            Turmas proximo = new Turmas();
            proximo.Show();
            Hide();
        }

        private void bt_professores_Click(object sender, EventArgs e)
        {
            Professores proximo = new Professores();
            proximo.Show();
            Hide();
        }

        private void bt_notas_Click(object sender, EventArgs e)
        {
            Notas proximo = new Notas();
            proximo.Show();
            Hide();
        }
    }
}