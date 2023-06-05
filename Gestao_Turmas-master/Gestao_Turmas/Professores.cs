using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Turmas
{
    public partial class Professores : Form
    {
        public Professores()
        {
            InitializeComponent();
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            Menu anterior = new Menu();
            anterior.Show();
            Close();
        }
    }
}
