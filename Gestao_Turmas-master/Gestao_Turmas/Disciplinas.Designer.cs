namespace Gestao_Turmas
{
    partial class Disciplinas
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lst_notas = new ListBox();
            lst_turmas = new ListBox();
            lst_prof = new ListBox();
            lst_carga_horas = new ListBox();
            lst_desc = new ListBox();
            lst_nome_disc = new ListBox();
            txt_carga_horas = new TextBox();
            txt_turma = new TextBox();
            txt_prof = new TextBox();
            txt_desc = new TextBox();
            txt_nome_disc = new TextBox();
            l_genero = new Label();
            l_contacto = new Label();
            l_email = new Label();
            l_num_aluno = new Label();
            l_nome = new Label();
            l_inicial = new Label();
            label7 = new Label();
            txt_nota = new TextBox();
            SuspendLayout();
            // 
            // bt_remover
            // 
            bt_remover.BackColor = SystemColors.ControlLightLight;
            bt_remover.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_remover.Location = new Point(1128, 890);
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
            bt_adicionar.Location = new Point(810, 890);
            bt_adicionar.Name = "bt_adicionar";
            bt_adicionar.Size = new Size(236, 65);
            bt_adicionar.TabIndex = 56;
            bt_adicionar.Text = "ADICIONAR";
            bt_adicionar.UseVisualStyleBackColor = false;
            // 
            // bt_alterar
            // 
            bt_alterar.BackColor = SystemColors.ControlLightLight;
            bt_alterar.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_alterar.Location = new Point(1434, 890);
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
            bt_menu.Location = new Point(78, 77);
            bt_menu.Name = "bt_menu";
            bt_menu.Size = new Size(236, 65);
            bt_menu.TabIndex = 54;
            bt_menu.Text = "MENU";
            bt_menu.UseVisualStyleBackColor = false;
            bt_menu.Click += bt_menu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1663, 533);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 53;
            label6.Text = "Notas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1351, 533);
            label5.Name = "label5";
            label5.Size = new Size(98, 30);
            label5.TabIndex = 52;
            label5.Text = "Turmas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1018, 533);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 51;
            label4.Text = "Professores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1616, 231);
            label3.Name = "label3";
            label3.Size = new Size(179, 30);
            label3.TabIndex = 50;
            label3.Text = "Carga Horária";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1332, 240);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 49;
            label2.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1039, 231);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 48;
            label1.Text = "Nome";
            // 
            // lst_notas
            // 
            lst_notas.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_notas.FormattingEnabled = true;
            lst_notas.ItemHeight = 25;
            lst_notas.Location = new Point(1576, 575);
            lst_notas.Name = "lst_notas";
            lst_notas.Size = new Size(249, 229);
            lst_notas.TabIndex = 47;
            // 
            // lst_turmas
            // 
            lst_turmas.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_turmas.FormattingEnabled = true;
            lst_turmas.ItemHeight = 25;
            lst_turmas.Location = new Point(1273, 575);
            lst_turmas.Name = "lst_turmas";
            lst_turmas.Size = new Size(249, 229);
            lst_turmas.TabIndex = 46;
            // 
            // lst_prof
            // 
            lst_prof.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_prof.FormattingEnabled = true;
            lst_prof.ItemHeight = 25;
            lst_prof.Location = new Point(965, 575);
            lst_prof.Name = "lst_prof";
            lst_prof.Size = new Size(249, 229);
            lst_prof.TabIndex = 45;
            // 
            // lst_carga_horas
            // 
            lst_carga_horas.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_carga_horas.FormattingEnabled = true;
            lst_carga_horas.ItemHeight = 25;
            lst_carga_horas.Location = new Point(1576, 273);
            lst_carga_horas.Name = "lst_carga_horas";
            lst_carga_horas.Size = new Size(249, 229);
            lst_carga_horas.TabIndex = 44;
            // 
            // lst_desc
            // 
            lst_desc.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_desc.FormattingEnabled = true;
            lst_desc.ItemHeight = 25;
            lst_desc.Location = new Point(1273, 273);
            lst_desc.Name = "lst_desc";
            lst_desc.Size = new Size(249, 229);
            lst_desc.TabIndex = 43;
            // 
            // lst_nome_disc
            // 
            lst_nome_disc.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_nome_disc.FormattingEnabled = true;
            lst_nome_disc.ItemHeight = 25;
            lst_nome_disc.Location = new Point(965, 273);
            lst_nome_disc.Name = "lst_nome_disc";
            lst_nome_disc.Size = new Size(249, 229);
            lst_nome_disc.TabIndex = 42;
            // 
            // txt_carga_horas
            // 
            txt_carga_horas.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_carga_horas.Location = new Point(142, 641);
            txt_carga_horas.Name = "txt_carga_horas";
            txt_carga_horas.Size = new Size(381, 34);
            txt_carga_horas.TabIndex = 41;
            txt_carga_horas.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_turma
            // 
            txt_turma.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_turma.Location = new Point(619, 470);
            txt_turma.Name = "txt_turma";
            txt_turma.Size = new Size(193, 34);
            txt_turma.TabIndex = 40;
            txt_turma.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_prof
            // 
            txt_prof.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_prof.Location = new Point(619, 317);
            txt_prof.Name = "txt_prof";
            txt_prof.Size = new Size(268, 34);
            txt_prof.TabIndex = 39;
            txt_prof.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_desc
            // 
            txt_desc.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_desc.Location = new Point(142, 470);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(381, 34);
            txt_desc.TabIndex = 38;
            txt_desc.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_nome_disc
            // 
            txt_nome_disc.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nome_disc.Location = new Point(142, 317);
            txt_nome_disc.Name = "txt_nome_disc";
            txt_nome_disc.Size = new Size(381, 34);
            txt_nome_disc.TabIndex = 37;
            txt_nome_disc.TextAlign = HorizontalAlignment.Center;
            // 
            // l_genero
            // 
            l_genero.AutoSize = true;
            l_genero.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_genero.Location = new Point(619, 406);
            l_genero.Name = "l_genero";
            l_genero.Size = new Size(149, 44);
            l_genero.TabIndex = 34;
            l_genero.Text = "TURMA";
            // 
            // l_contacto
            // 
            l_contacto.AutoSize = true;
            l_contacto.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_contacto.Location = new Point(619, 255);
            l_contacto.Name = "l_contacto";
            l_contacto.Size = new Size(238, 44);
            l_contacto.TabIndex = 33;
            l_contacto.Text = "PROFESSOR";
            // 
            // l_email
            // 
            l_email.AutoSize = true;
            l_email.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_email.Location = new Point(142, 406);
            l_email.Name = "l_email";
            l_email.Size = new Size(228, 44);
            l_email.TabIndex = 32;
            l_email.Text = "DESCRIÇÃO";
            // 
            // l_num_aluno
            // 
            l_num_aluno.AutoSize = true;
            l_num_aluno.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_num_aluno.Location = new Point(142, 560);
            l_num_aluno.Name = "l_num_aluno";
            l_num_aluno.Size = new Size(324, 44);
            l_num_aluno.TabIndex = 31;
            l_num_aluno.Text = "CARGA HORÁRIA";
            // 
            // l_nome
            // 
            l_nome.AutoSize = true;
            l_nome.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_nome.Location = new Point(142, 255);
            l_nome.Name = "l_nome";
            l_nome.Size = new Size(127, 44);
            l_nome.TabIndex = 30;
            l_nome.Text = "NOME";
            // 
            // l_inicial
            // 
            l_inicial.AutoSize = true;
            l_inicial.Font = new Font("LEMON MILK Medium", 48F, FontStyle.Bold, GraphicsUnit.Point);
            l_inicial.Location = new Point(712, 65);
            l_inicial.Name = "l_inicial";
            l_inicial.Size = new Size(565, 114);
            l_inicial.TabIndex = 29;
            l_inicial.Text = "DISCIPLINAS";
            l_inicial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(619, 560);
            label7.Name = "label7";
            label7.Size = new Size(141, 44);
            label7.TabIndex = 58;
            label7.Text = "NOTAS";
            // 
            // txt_nota
            // 
            txt_nota.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nota.Location = new Point(619, 641);
            txt_nota.Name = "txt_nota";
            txt_nota.Size = new Size(268, 34);
            txt_nota.TabIndex = 59;
            txt_nota.TextAlign = HorizontalAlignment.Center;
            // 
            // Disciplinas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txt_nota);
            Controls.Add(label7);
            Controls.Add(bt_remover);
            Controls.Add(bt_adicionar);
            Controls.Add(bt_alterar);
            Controls.Add(bt_menu);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lst_notas);
            Controls.Add(lst_turmas);
            Controls.Add(lst_prof);
            Controls.Add(lst_carga_horas);
            Controls.Add(lst_desc);
            Controls.Add(lst_nome_disc);
            Controls.Add(txt_carga_horas);
            Controls.Add(txt_turma);
            Controls.Add(txt_prof);
            Controls.Add(txt_desc);
            Controls.Add(txt_nome_disc);
            Controls.Add(l_genero);
            Controls.Add(l_contacto);
            Controls.Add(l_email);
            Controls.Add(l_num_aluno);
            Controls.Add(l_nome);
            Controls.Add(l_inicial);
            Name = "Disciplinas";
            Text = "Disciplinas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_remover;
        private Button bt_adicionar;
        private Button bt_alterar;
        private Button bt_menu;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lst_notas;
        private ListBox lst_turmas;
        private ListBox lst_prof;
        private ListBox lst_carga_horas;
        private ListBox lst_desc;
        private ListBox lst_nome_disc;
        private TextBox txt_carga_horas;
        private TextBox txt_turma;
        private TextBox txt_prof;
        private TextBox txt_desc;
        private TextBox txt_nome_disc;
        private Label l_genero;
        private Label l_contacto;
        private Label l_email;
        private Label l_num_aluno;
        private Label l_nome;
        private Label l_inicial;
        private Label label7;
        private TextBox txt_nota;
    }
}