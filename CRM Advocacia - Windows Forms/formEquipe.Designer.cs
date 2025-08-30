namespace CRM_Advocacia___Windows_Forms
{
    partial class formEquipe
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
            panel1 = new Panel();
            btnCriar = new Button();
            btnPesquisar = new Button();
            cbxAtividade = new ComboBox();
            label4 = new Label();
            cbxFiltro = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            tbxPesquisa = new TextBox();
            pnlEquipe = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(btnCriar);
            panel1.Controls.Add(cbxAtividade);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxPesquisa);
            panel1.Controls.Add(cbxFiltro);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 85);
            panel1.TabIndex = 0;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkGreen;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.Control;
            btnCriar.Location = new Point(982, 0);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(100, 33);
            btnCriar.TabIndex = 2;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DeepSkyBlue;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = SystemColors.Control;
            btnPesquisar.Location = new Point(593, 48);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 31);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "🔍︎";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // cbxAtividade
            // 
            cbxAtividade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAtividade.FormattingEnabled = true;
            cbxAtividade.Items.AddRange(new object[] { "Todos", "Ativo ", "Inativo" });
            cbxAtividade.Location = new Point(395, 53);
            cbxAtividade.Name = "cbxAtividade";
            cbxAtividade.Size = new Size(192, 23);
            cbxAtividade.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(395, 31);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 17;
            label4.Text = "Atividade do Funcionário";
            // 
            // cbxFiltro
            // 
            cbxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Todos", "Advogado", "Equipe" });
            cbxFiltro.Location = new Point(198, 51);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(192, 23);
            cbxFiltro.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(198, 31);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 15;
            label3.Text = "Tipo de Funcionário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 14;
            label1.Text = "Nome";
            // 
            // tbxPesquisa
            // 
            tbxPesquisa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPesquisa.Location = new Point(3, 53);
            tbxPesquisa.Name = "tbxPesquisa";
            tbxPesquisa.PlaceholderText = "Digite aqui";
            tbxPesquisa.Size = new Size(192, 21);
            tbxPesquisa.TabIndex = 13;
            tbxPesquisa.Tag = "";
            // 
            // pnlEquipe
            // 
            pnlEquipe.Dock = DockStyle.Fill;
            pnlEquipe.Location = new Point(0, 85);
            pnlEquipe.Name = "pnlEquipe";
            pnlEquipe.Size = new Size(1082, 477);
            pnlEquipe.TabIndex = 1;
            // 
            // formEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 562);
            Controls.Add(pnlEquipe);
            Controls.Add(panel1);
            Name = "formEquipe";
            Text = "formEquipe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCriar;
        private Button btnPesquisar;
        private ComboBox cbxAtividade;
        private Label label1;
        private Label label4;
        private TextBox tbxPesquisa;
        private ComboBox cbxFiltro;
        private Label label3;
        private Panel pnlEquipe;
    }
}