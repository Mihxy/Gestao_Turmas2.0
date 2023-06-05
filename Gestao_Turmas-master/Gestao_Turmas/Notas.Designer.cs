namespace Gestao_Turmas
{
    partial class Notas
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
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lst_alunos = new ListBox();
            lst_disc = new ListBox();
            lst_data = new ListBox();
            lst_valor = new ListBox();
            txt_aluno = new TextBox();
            txt_disc = new TextBox();
            txt_valor = new TextBox();
            l_genero = new Label();
            l_contacto = new Label();
            l_email = new Label();
            l_nome = new Label();
            l_inicial = new Label();
            dt_notas = new DateTimePicker();
            SuspendLayout();
            // 
            // bt_remover
            // 
            bt_remover.BackColor = SystemColors.ControlLightLight;
            bt_remover.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_remover.Location = new Point(1215, 896);
            bt_remover.Name = "bt_remover";
            bt_remover.Size = new Size(236, 65);
            bt_remover.TabIndex = 78;
            bt_remover.Text = "REMOVER";
            bt_remover.UseVisualStyleBackColor = false;
            // 
            // bt_adicionar
            // 
            bt_adicionar.BackColor = SystemColors.ControlLightLight;
            bt_adicionar.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_adicionar.Location = new Point(891, 896);
            bt_adicionar.Name = "bt_adicionar";
            bt_adicionar.Size = new Size(236, 65);
            bt_adicionar.TabIndex = 77;
            bt_adicionar.Text = "ADICIONAR";
            bt_adicionar.UseVisualStyleBackColor = false;
            // 
            // bt_alterar
            // 
            bt_alterar.BackColor = SystemColors.ControlLightLight;
            bt_alterar.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_alterar.Location = new Point(1537, 896);
            bt_alterar.Name = "bt_alterar";
            bt_alterar.Size = new Size(236, 65);
            bt_alterar.TabIndex = 76;
            bt_alterar.Text = "ALTERAR";
            bt_alterar.UseVisualStyleBackColor = false;
            // 
            // bt_menu
            // 
            bt_menu.BackColor = SystemColors.ActiveCaptionText;
            bt_menu.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_menu.ForeColor = Color.White;
            bt_menu.Location = new Point(130, 83);
            bt_menu.Name = "bt_menu";
            bt_menu.Size = new Size(236, 65);
            bt_menu.TabIndex = 75;
            bt_menu.Text = "MENU";
            bt_menu.UseVisualStyleBackColor = false;
            bt_menu.Click += bt_menu_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1486, 539);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 74;
            label5.Text = "Alunos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1134, 539);
            label4.Name = "label4";
            label4.Size = new Size(134, 30);
            label4.TabIndex = 73;
            label4.Text = "Disciplinas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1496, 237);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 72;
            label2.Text = "Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nexa Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1158, 237);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 71;
            label1.Text = "Valor";
            // 
            // lst_alunos
            // 
            lst_alunos.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_alunos.FormattingEnabled = true;
            lst_alunos.ItemHeight = 25;
            lst_alunos.Location = new Point(1413, 581);
            lst_alunos.Name = "lst_alunos";
            lst_alunos.Size = new Size(249, 229);
            lst_alunos.TabIndex = 70;
            // 
            // lst_disc
            // 
            lst_disc.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_disc.FormattingEnabled = true;
            lst_disc.ItemHeight = 25;
            lst_disc.Location = new Point(1075, 581);
            lst_disc.Name = "lst_disc";
            lst_disc.Size = new Size(249, 229);
            lst_disc.TabIndex = 69;
            // 
            // lst_data
            // 
            lst_data.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_data.FormattingEnabled = true;
            lst_data.ItemHeight = 25;
            lst_data.Location = new Point(1413, 279);
            lst_data.Name = "lst_data";
            lst_data.Size = new Size(249, 229);
            lst_data.TabIndex = 68;
            // 
            // lst_valor
            // 
            lst_valor.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lst_valor.FormattingEnabled = true;
            lst_valor.ItemHeight = 25;
            lst_valor.Location = new Point(1075, 279);
            lst_valor.Name = "lst_valor";
            lst_valor.Size = new Size(249, 229);
            lst_valor.TabIndex = 67;
            // 
            // txt_aluno
            // 
            txt_aluno.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_aluno.Location = new Point(333, 628);
            txt_aluno.Name = "txt_aluno";
            txt_aluno.Size = new Size(381, 34);
            txt_aluno.TabIndex = 66;
            txt_aluno.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_disc
            // 
            txt_disc.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_disc.Location = new Point(333, 758);
            txt_disc.Name = "txt_disc";
            txt_disc.Size = new Size(381, 34);
            txt_disc.TabIndex = 65;
            txt_disc.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_valor
            // 
            txt_valor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_valor.Location = new Point(333, 340);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(381, 34);
            txt_valor.TabIndex = 63;
            txt_valor.TextAlign = HorizontalAlignment.Center;
            // 
            // l_genero
            // 
            l_genero.AutoSize = true;
            l_genero.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_genero.Location = new Point(333, 562);
            l_genero.Name = "l_genero";
            l_genero.Size = new Size(147, 44);
            l_genero.TabIndex = 62;
            l_genero.Text = "ALUNO";
            // 
            // l_contacto
            // 
            l_contacto.AutoSize = true;
            l_contacto.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_contacto.Location = new Point(333, 693);
            l_contacto.Name = "l_contacto";
            l_contacto.Size = new Size(222, 44);
            l_contacto.TabIndex = 61;
            l_contacto.Text = "DISCIPLINA";
            // 
            // l_email
            // 
            l_email.AutoSize = true;
            l_email.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_email.Location = new Point(333, 422);
            l_email.Name = "l_email";
            l_email.Size = new Size(115, 44);
            l_email.TabIndex = 60;
            l_email.Text = "DATA";
            // 
            // l_nome
            // 
            l_nome.AutoSize = true;
            l_nome.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_nome.Location = new Point(333, 279);
            l_nome.Name = "l_nome";
            l_nome.Size = new Size(142, 44);
            l_nome.TabIndex = 59;
            l_nome.Text = "VALOR";
            // 
            // l_inicial
            // 
            l_inicial.AutoSize = true;
            l_inicial.Font = new Font("LEMON MILK Medium", 48F, FontStyle.Bold, GraphicsUnit.Point);
            l_inicial.Location = new Point(828, 72);
            l_inicial.Name = "l_inicial";
            l_inicial.Size = new Size(331, 114);
            l_inicial.TabIndex = 58;
            l_inicial.Text = "Notas";
            l_inicial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dt_notas
            // 
            dt_notas.CalendarFont = new Font("LEMON MILK", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dt_notas.CustomFormat = "";
            dt_notas.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dt_notas.Format = DateTimePickerFormat.Custom;
            dt_notas.Location = new Point(347, 487);
            dt_notas.MaxDate = new DateTime(2023, 3, 25, 0, 0, 0, 0);
            dt_notas.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dt_notas.Name = "dt_notas";
            dt_notas.RightToLeft = RightToLeft.No;
            dt_notas.RightToLeftLayout = true;
            dt_notas.Size = new Size(367, 30);
            dt_notas.TabIndex = 101;
            dt_notas.Value = new DateTime(2023, 3, 25, 0, 0, 0, 0);
            // 
            // Notas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dt_notas);
            Controls.Add(bt_remover);
            Controls.Add(bt_adicionar);
            Controls.Add(bt_alterar);
            Controls.Add(bt_menu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lst_alunos);
            Controls.Add(lst_disc);
            Controls.Add(lst_data);
            Controls.Add(lst_valor);
            Controls.Add(txt_aluno);
            Controls.Add(txt_disc);
            Controls.Add(txt_valor);
            Controls.Add(l_genero);
            Controls.Add(l_contacto);
            Controls.Add(l_email);
            Controls.Add(l_nome);
            Controls.Add(l_inicial);
            Name = "Notas";
            Text = "Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_remover;
        private Button bt_adicionar;
        private Button bt_alterar;
        private Button bt_menu;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ListBox lst_alunos;
        private ListBox lst_disc;
        private ListBox lst_data;
        private ListBox lst_valor;
        private TextBox txt_aluno;
        private TextBox txt_disc;
        private TextBox txt_valor;
        private Label l_genero;
        private Label l_contacto;
        private Label l_email;
        private Label l_nome;
        private Label l_inicial;
        private DateTimePicker dt_notas;
    }
}