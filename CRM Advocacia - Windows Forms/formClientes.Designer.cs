namespace CRM_Advocacia___Windows_Forms
{
    partial class formClientes
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
            plPesquisa = new Panel();
            btnPesquisar = new Button();
            cbxAtividade = new ComboBox();
            label4 = new Label();
            cbxFiltro = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            tbxPesquisa = new TextBox();
            btnCriar = new Button();
            flpClientes = new FlowLayoutPanel();
            plPesquisa.SuspendLayout();
            SuspendLayout();
            // 
            // plPesquisa
            // 
            plPesquisa.Controls.Add(btnPesquisar);
            plPesquisa.Controls.Add(cbxAtividade);
            plPesquisa.Controls.Add(label4);
            plPesquisa.Controls.Add(cbxFiltro);
            plPesquisa.Controls.Add(label3);
            plPesquisa.Controls.Add(label1);
            plPesquisa.Controls.Add(tbxPesquisa);
            plPesquisa.Controls.Add(btnCriar);
            plPesquisa.Dock = DockStyle.Top;
            plPesquisa.Location = new Point(0, 0);
            plPesquisa.Name = "plPesquisa";
            plPesquisa.Size = new Size(1147, 85);
            plPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DeepSkyBlue;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = SystemColors.Control;
            btnPesquisar.Location = new Point(593, 45);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 31);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "🔍︎";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // cbxAtividade
            // 
            cbxAtividade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAtividade.FormattingEnabled = true;
            cbxAtividade.Items.AddRange(new object[] { "Todos", "Ativo ", "Desativo" });
            cbxAtividade.Location = new Point(395, 50);
            cbxAtividade.Name = "cbxAtividade";
            cbxAtividade.Size = new Size(192, 23);
            cbxAtividade.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(395, 28);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 10;
            label4.Text = "Atividade do Cliente";
            // 
            // cbxFiltro
            // 
            cbxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Todos", "Pessoa Física", "Pessoa Jurídica" });
            cbxFiltro.Location = new Point(198, 48);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(192, 23);
            cbxFiltro.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(198, 28);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "Tipo de Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // tbxPesquisa
            // 
            tbxPesquisa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPesquisa.Location = new Point(3, 50);
            tbxPesquisa.Name = "tbxPesquisa";
            tbxPesquisa.PlaceholderText = "Digite aqui";
            tbxPesquisa.Size = new Size(192, 21);
            tbxPesquisa.TabIndex = 1;
            tbxPesquisa.Tag = "";
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
            btnCriar.TabIndex = 1;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // flpClientes
            // 
            flpClientes.AutoScroll = true;
            flpClientes.Dock = DockStyle.Fill;
            flpClientes.Location = new Point(0, 85);
            flpClientes.Name = "flpClientes";
            flpClientes.Size = new Size(1147, 502);
            flpClientes.TabIndex = 1;
            // 
            // formClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 587);
            Controls.Add(flpClientes);
            Controls.Add(plPesquisa);
            Font = new Font("Microsoft Sans Serif", 9F);
            Name = "formClientes";
            Text = "formClientes";
            Load += formClientes_Load;
            plPesquisa.ResumeLayout(false);
            plPesquisa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plPesquisa;
        private Button btnCriar;
        private TextBox tbxPesquisa;
        private Label label1;
        private Label label3;
        private ComboBox cbxFiltro;
        private Button btnPesquisar;
        private ComboBox cbxAtividade;
        private Label label4;
        private FlowLayoutPanel flpClientes;
    }
}