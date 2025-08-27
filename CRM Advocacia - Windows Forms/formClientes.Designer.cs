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
            panel1 = new Panel();
            btnPesquisar = new Button();
            cbxAtividade = new ComboBox();
            label4 = new Label();
            cbxTipoCliente = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tbxNumeroRegis = new TextBox();
            label1 = new Label();
            txtbNomeCliente = new TextBox();
            btnCriar = new Button();
            flpClientes = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(cbxAtividade);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbxTipoCliente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbxNumeroRegis);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtbNomeCliente);
            panel1.Controls.Add(btnCriar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1546, 85);
            panel1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DeepSkyBlue;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = SystemColors.Control;
            btnPesquisar.Location = new Point(1124, 50);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 31);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "🔍︎";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // cbxAtividade
            // 
            cbxAtividade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAtividade.FormattingEnabled = true;
            cbxAtividade.Items.AddRange(new object[] { "Ativo ", "Desativo" });
            cbxAtividade.Location = new Point(852, 50);
            cbxAtividade.Name = "cbxAtividade";
            cbxAtividade.Size = new Size(266, 30);
            cbxAtividade.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(852, 28);
            label4.Name = "label4";
            label4.Size = new Size(170, 22);
            label4.TabIndex = 10;
            label4.Text = "Atividade do Cliente";
            // 
            // cbxTipoCliente
            // 
            cbxTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoCliente.FormattingEnabled = true;
            cbxTipoCliente.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            cbxTipoCliente.Location = new Point(568, 50);
            cbxTipoCliente.Name = "cbxTipoCliente";
            cbxTipoCliente.Size = new Size(266, 30);
            cbxTipoCliente.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(568, 28);
            label3.Name = "label3";
            label3.Size = new Size(132, 22);
            label3.TabIndex = 8;
            label3.Text = "Tipo de Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(281, 28);
            label2.Name = "label2";
            label2.Size = new Size(170, 22);
            label2.TabIndex = 6;
            label2.Text = "Numero de Registro";
            // 
            // tbxNumeroRegis
            // 
            tbxNumeroRegis.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNumeroRegis.Location = new Point(281, 50);
            tbxNumeroRegis.Name = "tbxNumeroRegis";
            tbxNumeroRegis.PlaceholderText = "Digite aqui";
            tbxNumeroRegis.Size = new Size(266, 28);
            tbxNumeroRegis.TabIndex = 5;
            tbxNumeroRegis.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // txtbNomeCliente
            // 
            txtbNomeCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbNomeCliente.Location = new Point(3, 50);
            txtbNomeCliente.Name = "txtbNomeCliente";
            txtbNomeCliente.PlaceholderText = "Digite aqui";
            txtbNomeCliente.Size = new Size(266, 28);
            txtbNomeCliente.TabIndex = 1;
            txtbNomeCliente.Tag = "";
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkGreen;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.Control;
            btnCriar.Location = new Point(1443, 3);
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
            flpClientes.Size = new Size(1546, 841);
            flpClientes.TabIndex = 1;
            // 
            // formClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 926);
            Controls.Add(flpClientes);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F);
            Name = "formClientes";
            Text = "formClientes";
            Load += formClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCriar;
        private TextBox txtbNomeCliente;
        private Label label1;
        private Label label2;
        private TextBox tbxNumeroRegis;
        private Label label3;
        private ComboBox cbxTipoCliente;
        private Button btnPesquisar;
        private ComboBox cbxAtividade;
        private Label label4;
        private FlowLayoutPanel flpClientes;
    }
}