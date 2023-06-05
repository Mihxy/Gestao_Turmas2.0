namespace Gestao_Turmas
{
    partial class Turmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_remover = new Button();
            bt_adicionar = new Button();
            bt_alterar = new Button();
            bt_menu = new Button();
            txt_disc = new TextBox();
            txt_ano_escolar = new TextBox();
            txt_nome_turma = new TextBox();
            l_genero = new Label();
            l_aluno = new Label();
            l_email = new Label();
            l_nome = new Label();
            l_inicial = new Label();
            dgv_turmas = new DataGridView();
            cb_alunos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).BeginInit();
            SuspendLayout();
            // 
            // bt_remover
            // 
            bt_remover.BackColor = SystemColors.ControlLightLight;
            bt_remover.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_remover.Location = new Point(1218, 890);
            bt_remover.Name = "bt_remover";
            bt_remover.Size = new Size(236, 65);
            bt_remover.TabIndex = 57;
            bt_remover.Text = "REMOVER";
            bt_remover.UseVisualStyleBackColor = false;
            // 
            // bt_adicionar
            // 
            bt_adicionar.BackColor = SystemColors.ControlLightLight;
            bt_adicionar.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_adicionar.Location = new Point(956, 890);
            bt_adicionar.Name = "bt_adicionar";
            bt_adicionar.Size = new Size(236, 65);
            bt_adicionar.TabIndex = 56;
            bt_adicionar.Text = "ADICIONAR";
            bt_adicionar.UseVisualStyleBackColor = false;
            bt_adicionar.Click += bt_adicionar_Click;
            // 
            // bt_alterar
            // 
            bt_alterar.BackColor = SystemColors.ControlLightLight;
            bt_alterar.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_alterar.Location = new Point(1485, 890);
            bt_alterar.Name = "bt_alterar";
            bt_alterar.Size = new Size(236, 65);
            bt_alterar.TabIndex = 55;
            bt_alterar.Text = "ALTERAR";
            bt_alterar.UseVisualStyleBackColor = false;
            // 
            // bt_menu
            // 
            bt_menu.BackColor = SystemColors.ActiveCaptionText;
            bt_menu.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_menu.ForeColor = Color.White;
            bt_menu.Location = new Point(76, 46);
            bt_menu.Name = "bt_menu";
            bt_menu.Size = new Size(236, 65);
            bt_menu.TabIndex = 54;
            bt_menu.Text = "MENU";
            bt_menu.UseVisualStyleBackColor = false;
            bt_menu.Click += bt_menu_Click;
            // 
            // txt_disc
            // 
            txt_disc.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_disc.Location = new Point(281, 598);
            txt_disc.Name = "txt_disc";
            txt_disc.Size = new Size(381, 34);
            txt_disc.TabIndex = 40;
            txt_disc.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ano_escolar
            // 
            txt_ano_escolar.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ano_escolar.Location = new Point(281, 460);
            txt_ano_escolar.Name = "txt_ano_escolar";
            txt_ano_escolar.Size = new Size(381, 34);
            txt_ano_escolar.TabIndex = 38;
            txt_ano_escolar.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_nome_turma
            // 
            txt_nome_turma.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nome_turma.Location = new Point(281, 304);
            txt_nome_turma.Name = "txt_nome_turma";
            txt_nome_turma.Size = new Size(381, 34);
            txt_nome_turma.TabIndex = 37;
            txt_nome_turma.TextAlign = HorizontalAlignment.Center;
            // 
            // l_genero
            // 
            l_genero.AutoSize = true;
            l_genero.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_genero.Location = new Point(281, 539);
            l_genero.Name = "l_genero";
            l_genero.Size = new Size(222, 44);
            l_genero.TabIndex = 34;
            l_genero.Text = "DISCIPLINA";
            // 
            // l_aluno
            // 
            l_aluno.AutoSize = true;
            l_aluno.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_aluno.Location = new Point(392, 700);
            l_aluno.Name = "l_aluno";
            l_aluno.Size = new Size(147, 44);
            l_aluno.TabIndex = 33;
            l_aluno.Text = "ALUNO";
            // 
            // l_email
            // 
            l_email.AutoSize = true;
            l_email.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_email.Location = new Point(281, 388);
            l_email.Name = "l_email";
            l_email.Size = new Size(446, 44);
            l_email.TabIndex = 32;
            l_email.Text = "ANO DE ESCOLARIDADE";
            // 
            // l_nome
            // 
            l_nome.AutoSize = true;
            l_nome.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_nome.Location = new Point(281, 243);
            l_nome.Name = "l_nome";
            l_nome.Size = new Size(323, 44);
            l_nome.TabIndex = 30;
            l_nome.Text = "NOME DA TURMA";
            // 
            // l_inicial
            // 
            l_inicial.AutoSize = true;
            l_inicial.Font = new Font("LEMON MILK Medium", 48F, FontStyle.Bold, GraphicsUnit.Point);
            l_inicial.Location = new Point(773, 46);
            l_inicial.Name = "l_inicial";
            l_inicial.Size = new Size(395, 114);
            l_inicial.TabIndex = 29;
            l_inicial.Text = "Turmas";
            l_inicial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv_turmas
            // 
            dgv_turmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_turmas.Location = new Point(956, 243);
            dgv_turmas.Name = "dgv_turmas";
            dgv_turmas.RowHeadersWidth = 51;
            dgv_turmas.RowTemplate.Height = 29;
            dgv_turmas.Size = new Size(765, 560);
            dgv_turmas.TabIndex = 58;
            // 
            // cb_alunos
            // 
            cb_alunos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_alunos.FormattingEnabled = true;
            cb_alunos.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cb_alunos.Location = new Point(336, 758);
            cb_alunos.Name = "cb_alunos";
            cb_alunos.Size = new Size(268, 36);
            cb_alunos.TabIndex = 59;
            // 
            // Turmas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(cb_alunos);
            Controls.Add(dgv_turmas);
            Controls.Add(bt_remover);
            Controls.Add(bt_adicionar);
            Controls.Add(bt_alterar);
            Controls.Add(bt_menu);
            Controls.Add(txt_disc);
            Controls.Add(txt_ano_escolar);
            Controls.Add(txt_nome_turma);
            Controls.Add(l_genero);
            Controls.Add(l_aluno);
            Controls.Add(l_email);
            Controls.Add(l_nome);
            Controls.Add(l_inicial);
            Name = "Turmas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Turmas";
            WindowState = FormWindowState.Maximized;
            Load += Turmas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_remover;
        private Button bt_adicionar;
        private Button bt_alterar;
        private Button bt_menu;
        private TextBox txt_disc;
        private TextBox txt_ano_escolar;
        private TextBox txt_nome_turma;
        private Label l_genero;
        private Label l_aluno;
        private Label l_email;
        private Label l_nome;
        private Label l_inicial;
        private DataGridView dgv_turmas;
        private ComboBox cb_alunos;
    }
}