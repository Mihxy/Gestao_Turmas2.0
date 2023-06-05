namespace Gestao_Turmas
{
    partial class Alunos
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
            l_inicial = new Label();
            l_nome = new Label();
            l_num_aluno = new Label();
            l_email = new Label();
            l_contacto = new Label();
            l_genero = new Label();
            dt_nasc = new DateTimePicker();
            l_data_nasc = new Label();
            txt_nome_alunos = new TextBox();
            txt_email_alunos = new TextBox();
            txt_contacto_alunos = new TextBox();
            txt_num_aluno = new TextBox();
            bt_menu = new Button();
            bt_alterar = new Button();
            bt_adicionar = new Button();
            bt_remover = new Button();
            dgv_alunos = new DataGridView();
            l_turmas = new Label();
            cb_turmas = new ComboBox();
            check_genero = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgv_alunos).BeginInit();
            SuspendLayout();
            // 
            // l_inicial
            // 
            l_inicial.AutoSize = true;
            l_inicial.Font = new Font("LEMON MILK Medium", 48F, FontStyle.Bold, GraphicsUnit.Point);
            l_inicial.Location = new Point(668, 31);
            l_inicial.Name = "l_inicial";
            l_inicial.Size = new Size(323, 91);
            l_inicial.TabIndex = 0;
            l_inicial.Text = "Alunos";
            l_inicial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_nome
            // 
            l_nome.AutoSize = true;
            l_nome.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_nome.Location = new Point(115, 171);
            l_nome.Name = "l_nome";
            l_nome.Size = new Size(264, 35);
            l_nome.TabIndex = 1;
            l_nome.Text = "NOME COMPLETO";
            // 
            // l_num_aluno
            // 
            l_num_aluno.AutoSize = true;
            l_num_aluno.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_num_aluno.Location = new Point(115, 512);
            l_num_aluno.Name = "l_num_aluno";
            l_num_aluno.Size = new Size(293, 35);
            l_num_aluno.TabIndex = 2;
            l_num_aluno.Text = "NÚMERO DE ALUNO";
            // 
            // l_email
            // 
            l_email.AutoSize = true;
            l_email.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_email.Location = new Point(115, 393);
            l_email.Name = "l_email";
            l_email.Size = new Size(104, 35);
            l_email.TabIndex = 3;
            l_email.Text = "EMAIL";
            // 
            // l_contacto
            // 
            l_contacto.AutoSize = true;
            l_contacto.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_contacto.Location = new Point(532, 171);
            l_contacto.Name = "l_contacto";
            l_contacto.Size = new Size(169, 35);
            l_contacto.TabIndex = 4;
            l_contacto.Text = "CONTACTO";
            // 
            // l_genero
            // 
            l_genero.AutoSize = true;
            l_genero.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_genero.Location = new Point(532, 284);
            l_genero.Name = "l_genero";
            l_genero.Size = new Size(134, 35);
            l_genero.TabIndex = 5;
            l_genero.Text = "GÉNERO";
            // 
            // dt_nasc
            // 
            dt_nasc.CalendarFont = new Font("LEMON MILK", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dt_nasc.Checked = false;
            dt_nasc.CustomFormat = "";
            dt_nasc.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dt_nasc.Format = DateTimePickerFormat.Custom;
            dt_nasc.Location = new Point(214, 332);
            dt_nasc.Margin = new Padding(3, 2, 3, 2);
            dt_nasc.MaxDate = new DateTime(2025, 5, 3, 0, 0, 0, 0);
            dt_nasc.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dt_nasc.Name = "dt_nasc";
            dt_nasc.RightToLeftLayout = true;
            dt_nasc.Size = new Size(153, 26);
            dt_nasc.TabIndex = 6;
            dt_nasc.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // l_data_nasc
            // 
            l_data_nasc.AutoSize = true;
            l_data_nasc.Font = new Font("Nexa Heavy", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            l_data_nasc.Location = new Point(115, 284);
            l_data_nasc.Name = "l_data_nasc";
            l_data_nasc.Size = new Size(337, 35);
            l_data_nasc.TabIndex = 7;
            l_data_nasc.Text = "DATA  DE NASCIMENTO";
            // 
            // txt_nome_alunos
            // 
            txt_nome_alunos.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nome_alunos.Location = new Point(115, 218);
            txt_nome_alunos.Margin = new Padding(3, 2, 3, 2);
            txt_nome_alunos.Name = "txt_nome_alunos";
            txt_nome_alunos.Size = new Size(334, 29);
            txt_nome_alunos.TabIndex = 8;
            txt_nome_alunos.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_email_alunos
            // 
            txt_email_alunos.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_email_alunos.Location = new Point(115, 439);
            txt_email_alunos.Margin = new Padding(3, 2, 3, 2);
            txt_email_alunos.Name = "txt_email_alunos";
            txt_email_alunos.Size = new Size(334, 29);
            txt_email_alunos.TabIndex = 9;
            txt_email_alunos.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_contacto_alunos
            // 
            txt_contacto_alunos.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_contacto_alunos.Location = new Point(532, 218);
            txt_contacto_alunos.Margin = new Padding(3, 2, 3, 2);
            txt_contacto_alunos.Name = "txt_contacto_alunos";
            txt_contacto_alunos.Size = new Size(235, 29);
            txt_contacto_alunos.TabIndex = 10;
            txt_contacto_alunos.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_num_aluno
            // 
            txt_num_aluno.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_num_aluno.Location = new Point(115, 566);
            txt_num_aluno.Margin = new Padding(3, 2, 3, 2);
            txt_num_aluno.Name = "txt_num_aluno";
            txt_num_aluno.Size = new Size(138, 29);
            txt_num_aluno.TabIndex = 12;
            txt_num_aluno.TextAlign = HorizontalAlignment.Center;
            // 
            // bt_menu
            // 
            bt_menu.BackColor = SystemColors.ActiveCaptionText;
            bt_menu.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_menu.ForeColor = Color.White;
            bt_menu.Location = new Point(59, 38);
            bt_menu.Margin = new Padding(3, 2, 3, 2);
            bt_menu.Name = "bt_menu";
            bt_menu.Size = new Size(206, 49);
            bt_menu.TabIndex = 25;
            bt_menu.Text = "MENU";
            bt_menu.UseVisualStyleBackColor = false;
            bt_menu.Click += bt_menu_Click;
            // 
            // bt_alterar
            // 
            bt_alterar.BackColor = SystemColors.ControlLightLight;
            bt_alterar.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_alterar.Location = new Point(1339, 650);
            bt_alterar.Margin = new Padding(3, 2, 3, 2);
            bt_alterar.Name = "bt_alterar";
            bt_alterar.Size = new Size(206, 49);
            bt_alterar.TabIndex = 26;
            bt_alterar.Text = "ALTERAR";
            bt_alterar.UseVisualStyleBackColor = false;
            // 
            // bt_adicionar
            // 
            bt_adicionar.BackColor = SystemColors.ControlLightLight;
            bt_adicionar.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_adicionar.Location = new Point(876, 650);
            bt_adicionar.Margin = new Padding(3, 2, 3, 2);
            bt_adicionar.Name = "bt_adicionar";
            bt_adicionar.Size = new Size(206, 49);
            bt_adicionar.TabIndex = 27;
            bt_adicionar.Text = "ADICIONAR";
            bt_adicionar.UseVisualStyleBackColor = false;
            bt_adicionar.Click += bt_adicionar_Click;
            // 
            // bt_remover
            // 
            bt_remover.BackColor = SystemColors.ControlLightLight;
            bt_remover.Font = new Font("MADE TOMMY", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bt_remover.Location = new Point(1107, 650);
            bt_remover.Margin = new Padding(3, 2, 3, 2);
            bt_remover.Name = "bt_remover";
            bt_remover.Size = new Size(206, 49);
            bt_remover.TabIndex = 28;
            bt_remover.Text = "REMOVER";
            bt_remover.UseVisualStyleBackColor = false;
            // 
            // dgv_alunos
            // 
            dgv_alunos.AllowUserToAddRows = false;
            dgv_alunos.AllowUserToDeleteRows = false;
            dgv_alunos.AllowUserToResizeRows = false;
            dgv_alunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_alunos.BackgroundColor = SystemColors.Control;
            dgv_alunos.BorderStyle = BorderStyle.Fixed3D;
            dgv_alunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_alunos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_alunos.GridColor = SystemColors.MenuText;
            dgv_alunos.Location = new Point(876, 184);
            dgv_alunos.Margin = new Padding(3, 2, 3, 2);
            dgv_alunos.Name = "dgv_alunos";
            dgv_alunos.RowTemplate.Height = 29;
            dgv_alunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_alunos.Size = new Size(669, 420);
            dgv_alunos.TabIndex = 30;
            dgv_alunos.CellContentClick += dgv_alunos_CellContentClick;
            // 
            // l_turmas
            // 
            l_turmas.AutoSize = true;
            l_turmas.Font = new Font("MADE TOMMY", 24F, FontStyle.Bold, GraphicsUnit.Point);
            l_turmas.Location = new Point(583, 452);
            l_turmas.Name = "l_turmas";
            l_turmas.Size = new Size(150, 39);
            l_turmas.TabIndex = 32;
            l_turmas.Text = "TURMAS";
            // 
            // cb_turmas
            // 
            cb_turmas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_turmas.FormattingEnabled = true;
            cb_turmas.Location = new Point(571, 500);
            cb_turmas.Margin = new Padding(3, 2, 3, 2);
            cb_turmas.Name = "cb_turmas";
            cb_turmas.Size = new Size(186, 29);
            cb_turmas.TabIndex = 34;
            cb_turmas.SelectedIndexChanged += cb_turmas_SelectedIndexChanged;
            // 
            // check_genero
            // 
            check_genero.CheckOnClick = true;
            check_genero.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            check_genero.FormattingEnabled = true;
            check_genero.Location = new Point(540, 332);
            check_genero.Margin = new Padding(3, 2, 3, 2);
            check_genero.Name = "check_genero";
            check_genero.Size = new Size(227, 76);
            check_genero.TabIndex = 35;
            check_genero.SelectedIndexChanged += check_genero_SelectedIndexChanged;
            // 
            // Alunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1664, 775);
            Controls.Add(check_genero);
            Controls.Add(cb_turmas);
            Controls.Add(l_turmas);
            Controls.Add(dgv_alunos);
            Controls.Add(bt_remover);
            Controls.Add(bt_adicionar);
            Controls.Add(bt_alterar);
            Controls.Add(bt_menu);
            Controls.Add(txt_num_aluno);
            Controls.Add(txt_contacto_alunos);
            Controls.Add(txt_email_alunos);
            Controls.Add(txt_nome_alunos);
            Controls.Add(l_data_nasc);
            Controls.Add(dt_nasc);
            Controls.Add(l_genero);
            Controls.Add(l_contacto);
            Controls.Add(l_email);
            Controls.Add(l_num_aluno);
            Controls.Add(l_nome);
            Controls.Add(l_inicial);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Alunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alunos";
            WindowState = FormWindowState.Maximized;
            Load += Alunos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_alunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_inicial;
        private Label l_nome;
        private Label l_num_aluno;
        private Label l_email;
        private Label l_contacto;
        private Label l_genero;
        private DateTimePicker dt_nasc;
        private Label l_data_nasc;
        private TextBox txt_nome_alunos;
        private TextBox txt_email_alunos;
        private TextBox txt_contacto_alunos;
        private TextBox txt_num_aluno;
        private Button bt_menu;
        private Button bt_alterar;
        private Button bt_adicionar;
        private Button bt_remover;
        private TextBox txt_genero;
        private DataGridView dgv_alunos;
        private Label l_turmas;
        private ComboBox cb_turmas;
        private CheckedListBox check_genero;
    }
}