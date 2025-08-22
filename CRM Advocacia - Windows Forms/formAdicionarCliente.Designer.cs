namespace CRM_Advocacia___Windows_Forms
{
    partial class formAdicionarCliente
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
            lbTituloAC = new Label();
            tbxNomeCliente = new TextBox();
            lbNome = new Label();
            lbTipo = new Label();
            cbxTipoCliente = new ComboBox();
            label3 = new Label();
            tbxCPF = new TextBox();
            lbCNPJ = new Label();
            tbxCNPJ = new TextBox();
            lbDescricaoCliente = new Label();
            rtbxDesc = new RichTextBox();
            tbEmailCliente = new Label();
            tbxEmail = new TextBox();
            lbTelefone = new Label();
            tbxTelefone = new TextBox();
            lbDataCliente = new Label();
            dateContatoCliente = new DateTimePicker();
            btnCriar = new Button();
            SuspendLayout();
            // 
            // lbTituloAC
            // 
            lbTituloAC.AutoSize = true;
            lbTituloAC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloAC.Location = new Point(12, 9);
            lbTituloAC.Name = "lbTituloAC";
            lbTituloAC.Size = new Size(180, 24);
            lbTituloAC.TabIndex = 3;
            lbTituloAC.Text = "Adicionar Clientes";
            // 
            // tbxNomeCliente
            // 
            tbxNomeCliente.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNomeCliente.Location = new Point(1, 63);
            tbxNomeCliente.Name = "tbxNomeCliente";
            tbxNomeCliente.PlaceholderText = "Digite aqui";
            tbxNomeCliente.Size = new Size(215, 21);
            tbxNomeCliente.TabIndex = 4;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(1, 45);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(99, 15);
            lbNome.TabIndex = 5;
            lbNome.Text = "Nome do Cliente";
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTipo.Location = new Point(1, 87);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(89, 15);
            lbTipo.TabIndex = 6;
            lbTipo.Text = "Tipo do Cliente";
            // 
            // cbxTipoCliente
            // 
            cbxTipoCliente.Font = new Font("Microsoft Sans Serif", 9F);
            cbxTipoCliente.FormattingEnabled = true;
            cbxTipoCliente.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            cbxTipoCliente.Location = new Point(1, 105);
            cbxTipoCliente.Name = "cbxTipoCliente";
            cbxTipoCliente.Size = new Size(215, 23);
            cbxTipoCliente.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 131);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 9;
            label3.Text = "CPF";
            // 
            // tbxCPF
            // 
            tbxCPF.Font = new Font("Microsoft Sans Serif", 9F);
            tbxCPF.Location = new Point(1, 149);
            tbxCPF.Name = "tbxCPF";
            tbxCPF.PlaceholderText = "Digite aqui";
            tbxCPF.Size = new Size(215, 21);
            tbxCPF.TabIndex = 8;
            // 
            // lbCNPJ
            // 
            lbCNPJ.AutoSize = true;
            lbCNPJ.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCNPJ.Location = new Point(1, 175);
            lbCNPJ.Name = "lbCNPJ";
            lbCNPJ.Size = new Size(38, 15);
            lbCNPJ.TabIndex = 11;
            lbCNPJ.Text = "CNPJ";
            // 
            // tbxCNPJ
            // 
            tbxCNPJ.Font = new Font("Microsoft Sans Serif", 9F);
            tbxCNPJ.Location = new Point(1, 193);
            tbxCNPJ.Name = "tbxCNPJ";
            tbxCNPJ.PlaceholderText = "Digite aqui";
            tbxCNPJ.Size = new Size(215, 21);
            tbxCNPJ.TabIndex = 10;
            // 
            // lbDescricaoCliente
            // 
            lbDescricaoCliente.AutoSize = true;
            lbDescricaoCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescricaoCliente.Location = new Point(248, 175);
            lbDescricaoCliente.Name = "lbDescricaoCliente";
            lbDescricaoCliente.Size = new Size(62, 15);
            lbDescricaoCliente.TabIndex = 13;
            lbDescricaoCliente.Text = "Descrição";
            // 
            // rtbxDesc
            // 
            rtbxDesc.Location = new Point(248, 193);
            rtbxDesc.Name = "rtbxDesc";
            rtbxDesc.Size = new Size(215, 99);
            rtbxDesc.TabIndex = 14;
            rtbxDesc.Text = "";
            // 
            // tbEmailCliente
            // 
            tbEmailCliente.AutoSize = true;
            tbEmailCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmailCliente.Location = new Point(248, 45);
            tbEmailCliente.Name = "tbEmailCliente";
            tbEmailCliente.Size = new Size(39, 15);
            tbEmailCliente.TabIndex = 16;
            tbEmailCliente.Text = "Email";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Microsoft Sans Serif", 9F);
            tbxEmail.Location = new Point(248, 63);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Digite aqui";
            tbxEmail.Size = new Size(216, 21);
            tbxEmail.TabIndex = 15;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(248, 87);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(55, 15);
            lbTelefone.TabIndex = 18;
            lbTelefone.Text = "Telefone";
            // 
            // tbxTelefone
            // 
            tbxTelefone.Font = new Font("Microsoft Sans Serif", 9F);
            tbxTelefone.Location = new Point(248, 105);
            tbxTelefone.Name = "tbxTelefone";
            tbxTelefone.PlaceholderText = "Digite aqui";
            tbxTelefone.Size = new Size(216, 21);
            tbxTelefone.TabIndex = 17;
            // 
            // lbDataCliente
            // 
            lbDataCliente.AutoSize = true;
            lbDataCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDataCliente.Location = new Point(248, 131);
            lbDataCliente.Name = "lbDataCliente";
            lbDataCliente.Size = new Size(99, 15);
            lbDataCliente.TabIndex = 19;
            lbDataCliente.Text = "Primeiro Contato";
            // 
            // dateContatoCliente
            // 
            dateContatoCliente.Format = DateTimePickerFormat.Short;
            dateContatoCliente.Location = new Point(248, 149);
            dateContatoCliente.Name = "dateContatoCliente";
            dateContatoCliente.Size = new Size(216, 23);
            dateContatoCliente.TabIndex = 20;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkGreen;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.Control;
            btnCriar.Location = new Point(673, 392);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(115, 46);
            btnCriar.TabIndex = 21;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // formAdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCriar);
            Controls.Add(dateContatoCliente);
            Controls.Add(lbDataCliente);
            Controls.Add(lbTelefone);
            Controls.Add(tbxTelefone);
            Controls.Add(tbEmailCliente);
            Controls.Add(tbxEmail);
            Controls.Add(rtbxDesc);
            Controls.Add(lbDescricaoCliente);
            Controls.Add(lbCNPJ);
            Controls.Add(tbxCNPJ);
            Controls.Add(label3);
            Controls.Add(tbxCPF);
            Controls.Add(cbxTipoCliente);
            Controls.Add(lbTipo);
            Controls.Add(lbNome);
            Controls.Add(tbxNomeCliente);
            Controls.Add(lbTituloAC);
            Name = "formAdicionarCliente";
            Text = "formAdicionarCliente";
            Load += formAdicionarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloAC;
        private TextBox tbxNomeCliente;
        private Label lbNome;
        private Label lbTipo;
        private ComboBox cbxTipoCliente;
        private Label label3;
        private TextBox tbxCPF;
        private Label lbCNPJ;
        private TextBox tbxCNPJ;
        private Label lbDescricaoCliente;
        private RichTextBox rtbxDesc;
        private Label tbEmailCliente;
        private TextBox tbxEmail;
        private Label lbTelefone;
        private TextBox tbxTelefone;
        private Label lbDataCliente;
        private DateTimePicker dateContatoCliente;
        private Button btnCriar;
    }
}