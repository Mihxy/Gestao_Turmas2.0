namespace Gestao_Turmas
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            bt_turmas = new Button();
            bt_professores = new Button();
            bt_disciplinas = new Button();
            bt_notas = new Button();
            bt_alunos = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bt_turmas
            // 
            bt_turmas.Anchor = AnchorStyles.None;
            bt_turmas.BackColor = SystemColors.ControlLightLight;
            bt_turmas.BackgroundImage = Properties.Resources.turmasft;
            bt_turmas.BackgroundImageLayout = ImageLayout.Zoom;
            bt_turmas.Font = new Font("a Black Lives", 24F, FontStyle.Bold, GraphicsUnit.Point);
            bt_turmas.Location = new Point(697, 244);
            bt_turmas.Name = "bt_turmas";
            bt_turmas.Size = new Size(491, 133);
            bt_turmas.TabIndex = 2;
            bt_turmas.UseVisualStyleBackColor = false;
            bt_turmas.Click += bt_turmas_Click;
            // 
            // bt_professores
            // 
            bt_professores.Anchor = AnchorStyles.None;
            bt_professores.BackColor = Color.White;
            bt_professores.BackgroundImage = Properties.Resources.professoresft;
            bt_professores.BackgroundImageLayout = ImageLayout.Zoom;
            bt_professores.Font = new Font("a Black Lives", 24F, FontStyle.Bold, GraphicsUnit.Point);
            bt_professores.Location = new Point(164, 413);
            bt_professores.Name = "bt_professores";
            bt_professores.Size = new Size(491, 135);
            bt_professores.TabIndex = 3;
            bt_professores.UseVisualStyleBackColor = false;
            bt_professores.Click += bt_professores_Click;
            // 
            // bt_disciplinas
            // 
            bt_disciplinas.Anchor = AnchorStyles.None;
            bt_disciplinas.BackColor = Color.White;
            bt_disciplinas.BackgroundImage = Properties.Resources.disciplinas1;
            bt_disciplinas.BackgroundImageLayout = ImageLayout.Zoom;
            bt_disciplinas.Font = new Font("a Black Lives", 24F, FontStyle.Bold, GraphicsUnit.Point);
            bt_disciplinas.Location = new Point(697, 413);
            bt_disciplinas.Name = "bt_disciplinas";
            bt_disciplinas.Size = new Size(491, 135);
            bt_disciplinas.TabIndex = 4;
            bt_disciplinas.UseVisualStyleBackColor = false;
            bt_disciplinas.Click += bt_disciplinas_Click;
            // 
            // bt_notas
            // 
            bt_notas.Anchor = AnchorStyles.None;
            bt_notas.BackColor = Color.White;
            bt_notas.BackgroundImage = Properties.Resources.notas1;
            bt_notas.BackgroundImageLayout = ImageLayout.Zoom;
            bt_notas.Font = new Font("a Black Lives", 24F, FontStyle.Bold, GraphicsUnit.Point);
            bt_notas.Location = new Point(436, 583);
            bt_notas.Name = "bt_notas";
            bt_notas.Size = new Size(491, 135);
            bt_notas.TabIndex = 5;
            bt_notas.UseVisualStyleBackColor = false;
            bt_notas.Click += bt_notas_Click;
            // 
            // bt_alunos
            // 
            bt_alunos.Anchor = AnchorStyles.None;
            bt_alunos.BackColor = SystemColors.ControlLightLight;
            bt_alunos.BackgroundImage = Properties.Resources.alunosft;
            bt_alunos.BackgroundImageLayout = ImageLayout.Zoom;
            bt_alunos.Font = new Font("a Black Lives", 24F, FontStyle.Bold, GraphicsUnit.Point);
            bt_alunos.Location = new Point(164, 244);
            bt_alunos.Name = "bt_alunos";
            bt_alunos.Size = new Size(491, 133);
            bt_alunos.TabIndex = 6;
            bt_alunos.UseVisualStyleBackColor = false;
            bt_alunos.Click += bt_alunos_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(164, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 174);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("LEMON MILK Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(104, 90);
            label2.Name = "label2";
            label2.Size = new Size(820, 66);
            label2.TabIndex = 25;
            label2.Text = "Gestão de Turmas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("LEMON MILK Bold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(104, 10);
            label1.Name = "label1";
            label1.Size = new Size(820, 95);
            label1.TabIndex = 24;
            label1.Text = "Menu Principal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1348, 853);
            Controls.Add(panel1);
            Controls.Add(bt_alunos);
            Controls.Add(bt_notas);
            Controls.Add(bt_disciplinas);
            Controls.Add(bt_professores);
            Controls.Add(bt_turmas);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button bt_turmas;
        private Button bt_professores;
        private Button bt_disciplinas;
        private Button bt_notas;
        private Button bt_alunos;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}