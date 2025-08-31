namespace CRM_Advocacia___Windows_Forms
{
    partial class formHonorario
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
            btnPesquisar = new Button();
            label1 = new Label();
            tbxPesquisa = new TextBox();
            cbxFiltro = new ComboBox();
            label3 = new Label();
            pnlHonorario = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbxPesquisa);
            panel1.Controls.Add(cbxFiltro);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 100);
            panel1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DeepSkyBlue;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = SystemColors.Control;
            btnPesquisar.Location = new Point(396, 63);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 31);
            btnPesquisar.TabIndex = 20;
            btnPesquisar.Text = "🔍︎";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(3, 51);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 18;
            label1.Text = "Descrição do Honorário";
            // 
            // tbxPesquisa
            // 
            tbxPesquisa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPesquisa.Location = new Point(3, 73);
            tbxPesquisa.Name = "tbxPesquisa";
            tbxPesquisa.PlaceholderText = "Digite aqui";
            tbxPesquisa.Size = new Size(192, 21);
            tbxPesquisa.TabIndex = 17;
            tbxPesquisa.Tag = "";
            // 
            // cbxFiltro
            // 
            cbxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Todos", "Pago ", "Pendente" });
            cbxFiltro.Location = new Point(198, 71);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(192, 23);
            cbxFiltro.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(198, 51);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 19;
            label3.Text = "Status de Pagamento";
            // 
            // pnlHonorario
            // 
            pnlHonorario.AutoScroll = true;
            pnlHonorario.Dock = DockStyle.Fill;
            pnlHonorario.Location = new Point(0, 100);
            pnlHonorario.Name = "pnlHonorario";
            pnlHonorario.Size = new Size(1147, 487);
            pnlHonorario.TabIndex = 1;
            // 
            // formHonorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 587);
            Controls.Add(pnlHonorario);
            Controls.Add(panel1);
            Name = "formHonorario";
            Text = "formHonorario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlHonorario;
        private Label label1;
        private TextBox tbxPesquisa;
        private ComboBox cbxFiltro;
        private Label label3;
        private Button btnPesquisar;
    }
}