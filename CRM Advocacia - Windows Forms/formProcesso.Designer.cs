namespace CRM_Advocacia___Windows_Forms
{
    partial class formProcesso
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
            cbxStatus = new ComboBox();
            label2 = new Label();
            btnPesquisar = new Button();
            btnCriar = new Button();
            cbxFase = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            tbxPesquisa = new TextBox();
            cbxFiltro = new ComboBox();
            label3 = new Label();
            pnlProcesso = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxStatus);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(btnCriar);
            panel1.Controls.Add(cbxFase);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxPesquisa);
            panel1.Controls.Add(cbxFiltro);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 85);
            panel1.TabIndex = 1;
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Todos", "Ativo ", "Suspenso", "Encerrado" });
            cbxStatus.Location = new Point(590, 53);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(192, 23);
            cbxStatus.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(590, 31);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 20;
            label2.Text = "Status do Processo";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DeepSkyBlue;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = SystemColors.Control;
            btnPesquisar.Location = new Point(788, 47);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 31);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "🔍︎";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkGreen;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.Control;
            btnCriar.Location = new Point(1047, 0);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(100, 33);
            btnCriar.TabIndex = 2;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // cbxFase
            // 
            cbxFase.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFase.FormattingEnabled = true;
            cbxFase.Items.AddRange(new object[] { "Todos", "Conhecimento", "Execução", "Recursal", "Arquivado" });
            cbxFase.Location = new Point(395, 53);
            cbxFase.Name = "cbxFase";
            cbxFase.Size = new Size(192, 23);
            cbxFase.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 14;
            label1.Text = "Titulo do Processo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(395, 31);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 17;
            label4.Text = "Fase do Processo";
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
            // cbxFiltro
            // 
            cbxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Todos", "Trabalhista", "Cível", "Criminal", "Tributário", "Família", "Outros" });
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
            label3.Size = new Size(88, 15);
            label3.TabIndex = 15;
            label3.Text = "Área do Direito";
            // 
            // pnlProcesso
            // 
            pnlProcesso.Dock = DockStyle.Fill;
            pnlProcesso.Location = new Point(0, 85);
            pnlProcesso.Name = "pnlProcesso";
            pnlProcesso.Size = new Size(1147, 502);
            pnlProcesso.TabIndex = 2;
            // 
            // formProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 587);
            Controls.Add(pnlProcesso);
            Controls.Add(panel1);
            Name = "formProcesso";
            Text = "formProcesso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPesquisar;
        private Button btnCriar;
        private ComboBox cbxFase;
        private Label label1;
        private Label label4;
        private TextBox tbxPesquisa;
        private ComboBox cbxFiltro;
        private Label label3;
        private Panel pnlProcesso;
        private ComboBox cbxStatus;
        private Label label2;
    }
}