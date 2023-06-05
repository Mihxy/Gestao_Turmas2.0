namespace Gestao_Turmas
{
    partial class Professores
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
            lst_disc = new ListBox();
            lst_turmas = new ListBox();
            lst_genero_prof = new ListBox();
            lst_contacto_prof = new ListBox();
            lst_email_prof = new ListBox();
            lst_nome_prof = new ListBox();
            txt_turma = new TextBox();
            txt_genero_prof = new TextBox();
            txt_contacto_prof = new TextBox();
            txt_email_prof = new TextBox();
            txt_nome_prof = new TextBox();
            l_genero = new Label();
            l_contacto = new Label();
            l_email = new Label();
            l_num_aluno = new Label();
            l_nome = new Label();
            l_inicial = new Label();
            label7 = new Label();
            txt_disc = new TextBox();
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
            label6.Location = new Point(1638, 533);
            label6.Name = "label6";
            label6.Size = new Size(134, 30);
            label6.TabIndex = 53;
            label6.Text = "Disciplinas";
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
            label4.Location = new Point(1043, 533);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 51;
            label4.Text = "Género";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1638, 231);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 50;
            label3.Text = "Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1351, 231);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 49;
            label2.Text = "Email";
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
            // lst_disc
            // 
            lst_disc.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_disc.FormattingEnabled = true;
            lst_disc.ItemHeight = 25;
            lst_disc.Location = new Point(1576, 575);
            lst_disc.Name = "lst_disc";
            lst_disc.Size = new Size(249, 229);
            lst_disc.TabIndex = 47;
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
            // lst_genero_prof
            // 
            lst_genero_prof.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_genero_prof.FormattingEnabled = true;
            lst_genero_prof.ItemHeight = 25;
            lst_genero_prof.Location = new Point(965, 575);
            lst_genero_prof.Name = "lst_genero_prof";
            lst_genero_prof.Size = new Size(249, 229);
            lst_genero_prof.TabIndex = 45;
            // 
            // lst_contacto_prof
            // 
            lst_contacto_prof.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_contacto_prof.FormattingEnabled = true;
            lst_contacto_prof.ItemHeight = 25;
            lst_contacto_prof.Location = new Point(1576, 273);
            lst_contacto_prof.Name = "lst_contacto_prof";
            lst_contacto_prof.Size = new Size(249, 229);
            lst_contacto_prof.TabIndex = 44;
            // 
            // lst_email_prof
            // 
            lst_email_prof.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_email_prof.FormattingEnabled = true;
            lst_email_prof.ItemHeight = 25;
            lst_email_prof.Location = new Point(1273, 273);
            lst_email_prof.Name = "lst_email_prof";
            lst_email_prof.Size = new Size(249, 229);
            lst_email_prof.TabIndex = 43;
            // 
            // lst_nome_prof
            // 
            lst_nome_prof.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_nome_prof.FormattingEnabled = true;
            lst_nome_prof.ItemHeight = 25;
            lst_nome_prof.Location = new Point(965, 273);
            lst_nome_prof.Name = "lst_nome_prof";
            lst_nome_prof.Size = new Size(249, 229);
            lst_nome_prof.TabIndex = 42;
            // 
            // txt_turma
            // 
            txt_turma.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_turma.Location = new Point(142, 631);
            txt_turma.Name = "txt_turma";
            txt_turma.Size = new Size(381, 34);
            txt_turma.TabIndex = 41;
            txt_turma.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_genero_prof
            // 
            txt_genero_prof.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_genero_prof.Location = new Point(619, 470);
            txt_genero_prof.Name = "txt_genero_prof";
            txt_genero_prof.Size = new Size(193, 34);
            txt_genero_prof.TabIndex = 40;
            txt_genero_prof.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_contacto_prof
            // 
            txt_contacto_prof.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_contacto_prof.Location = new Point(619, 317);
            txt_contacto_prof.Name = "txt_contacto_prof";
            txt_contacto_prof.Size = new Size(268, 34);
            txt_contacto_prof.TabIndex = 39;
            txt_contacto_prof.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_email_prof
            // 
            txt_email_prof.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_email_prof.Location = new Point(142, 470);
            txt_email_prof.Name = "txt_email_prof";
            txt_email_prof.Size = new Size(381, 34);
            txt_email_prof.TabIndex = 38;
            txt_email_prof.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_nome_prof
            // 
            txt_nome_prof.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nome_prof.Location = new Point(142, 317);
            txt_nome_prof.Name = "txt_nome_prof";
            txt_nome_prof.Size = new Size(381, 34);
            txt_nome_prof.TabIndex = 37;
            txt_nome_prof.TextAlign = HorizontalAlignment.Center;
            // 
            // l_genero
            // 
            l_genero.AutoSize = true;
            l_genero.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_genero.Location = new Point(619, 406);
            l_genero.Name = "l_genero";
            l_genero.Size = new Size(170, 44);
            l_genero.TabIndex = 34;
            l_genero.Text = "GÉNERO";
            // 
            // l_contacto
            // 
            l_contacto.AutoSize = true;
            l_contacto.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_contacto.Location = new Point(619, 255);
            l_contacto.Name = "l_contacto";
            l_contacto.Size = new Size(214, 44);
            l_contacto.TabIndex = 33;
            l_contacto.Text = "CONTACTO";
            // 
            // l_email
            // 
            l_email.AutoSize = true;
            l_email.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_email.Location = new Point(142, 406);
            l_email.Name = "l_email";
            l_email.Size = new Size(132, 44);
            l_email.TabIndex = 32;
            l_email.Text = "EMAIL";
            // 
            // l_num_aluno
            // 
            l_num_aluno.AutoSize = true;
            l_num_aluno.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_num_aluno.Location = new Point(142, 564);
            l_num_aluno.Name = "l_num_aluno";
            l_num_aluno.Size = new Size(149, 44);
            l_num_aluno.TabIndex = 31;
            l_num_aluno.Text = "TURMA";
            // 
            // l_nome
            // 
            l_nome.AutoSize = true;
            l_nome.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_nome.Location = new Point(142, 255);
            l_nome.Name = "l_nome";
            l_nome.Size = new Size(334, 44);
            l_nome.TabIndex = 30;
            l_nome.Text = "NOME COMPLETO";
            // 
            // l_inicial
            // 
            l_inicial.AutoSize = true;
            l_inicial.Font = new Font("LEMON MILK Medium", 48F, FontStyle.Bold, GraphicsUnit.Point);
            l_inicial.Location = new Point(663, 57);
            l_inicial.Name = "l_inicial";
            l_inicial.Size = new Size(646, 114);
            l_inicial.TabIndex = 29;
            l_inicial.Text = "Professores";
            l_inicial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(142, 709);
            label7.Name = "label7";
            label7.Size = new Size(222, 44);
            label7.TabIndex = 58;
            label7.Text = "DISCIPLINA";
            // 
            // txt_disc
            // 
            txt_disc.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_disc.Location = new Point(142, 770);
            txt_disc.Name = "txt_disc";
            txt_disc.Size = new Size(381, 34);
            txt_disc.TabIndex = 59;
            txt_disc.TextAlign = HorizontalAlignment.Center;
            // 
            // Professores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txt_disc);
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
            Controls.Add(lst_disc);
            Controls.Add(lst_turmas);
            Controls.Add(lst_genero_prof);
            Controls.Add(lst_contacto_prof);
            Controls.Add(lst_email_prof);
            Controls.Add(lst_nome_prof);
            Controls.Add(txt_turma);
            Controls.Add(txt_genero_prof);
            Controls.Add(txt_contacto_prof);
            Controls.Add(txt_email_prof);
            Controls.Add(txt_nome_prof);
            Controls.Add(l_genero);
            Controls.Add(l_contacto);
            Controls.Add(l_email);
            Controls.Add(l_num_aluno);
            Controls.Add(l_nome);
            Controls.Add(l_inicial);
            Name = "Professores";
            Text = "Professores";
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
        private ListBox lst_disc;
        private ListBox lst_turmas;
        private ListBox lst_genero_prof;
        private ListBox lst_contacto_prof;
        private ListBox lst_email_prof;
        private ListBox lst_nome_prof;
        private TextBox txt_turma;
        private TextBox txt_genero_prof;
        private TextBox txt_contacto_prof;
        private TextBox txt_email_prof;
        private TextBox txt_nome_prof;
        private Label l_genero;
        private Label l_contacto;
        private Label l_email;
        private Label l_num_aluno;
        private Label l_nome;
        private Label l_inicial;
        private Label label7;
        private TextBox txt_disc;
    }
}