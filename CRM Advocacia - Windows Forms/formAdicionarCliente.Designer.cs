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
            lbDocumento = new Label();
            lbDescricaoCliente = new Label();
            rtbxDesc = new RichTextBox();
            lbEmailCliente = new Label();
            tbxEmail = new TextBox();
            lbTelefone = new Label();
            tbxTelefone = new TextBox();
            lbDataCliente = new Label();
            dateContatoCliente = new DateTimePicker();
            btnCriar = new Button();
            tbxDocumento = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxEstado = new TextBox();
            label5 = new Label();
            tbxCidade = new TextBox();
            label6 = new Label();
            tbxBairro = new TextBox();
            label7 = new Label();
            tbxLogradouro = new TextBox();
            label8 = new Label();
            tbxNumero = new TextBox();
            label9 = new Label();
            cbxTipo = new ComboBox();
            label10 = new Label();
            tbxComplemento = new TextBox();
            tbxCEP = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbTituloAC
            // 
            lbTituloAC.AutoSize = true;
            lbTituloAC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloAC.Location = new Point(300, 9);
            lbTituloAC.Name = "lbTituloAC";
            lbTituloAC.Size = new Size(180, 24);
            lbTituloAC.TabIndex = 3;
            lbTituloAC.Text = "Adicionar Clientes";
            // 
            // tbxNomeCliente
            // 
            tbxNomeCliente.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNomeCliente.Location = new Point(12, 100);
            tbxNomeCliente.Name = "tbxNomeCliente";
            tbxNomeCliente.PlaceholderText = "Digite aqui";
            tbxNomeCliente.Size = new Size(215, 21);
            tbxNomeCliente.TabIndex = 4;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(12, 82);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(99, 15);
            lbNome.TabIndex = 5;
            lbNome.Text = "Nome do Cliente";
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTipo.Location = new Point(12, 124);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(89, 15);
            lbTipo.TabIndex = 6;
            lbTipo.Text = "Tipo do Cliente";
            // 
            // cbxTipoCliente
            // 
            cbxTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoCliente.Font = new Font("Microsoft Sans Serif", 9F);
            cbxTipoCliente.FormattingEnabled = true;
            cbxTipoCliente.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            cbxTipoCliente.Location = new Point(12, 142);
            cbxTipoCliente.Name = "cbxTipoCliente";
            cbxTipoCliente.Size = new Size(215, 23);
            cbxTipoCliente.TabIndex = 7;
            cbxTipoCliente.SelectedIndexChanged += cbxTipoCliente_SelectedIndexChanged;
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDocumento.Location = new Point(12, 168);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(30, 15);
            lbDocumento.TabIndex = 9;
            lbDocumento.Text = "CPF";
            // 
            // lbDescricaoCliente
            // 
            lbDescricaoCliente.AutoSize = true;
            lbDescricaoCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescricaoCliente.Location = new Point(13, 340);
            lbDescricaoCliente.Name = "lbDescricaoCliente";
            lbDescricaoCliente.Size = new Size(62, 15);
            lbDescricaoCliente.TabIndex = 13;
            lbDescricaoCliente.Text = "Descrição";
            // 
            // rtbxDesc
            // 
            rtbxDesc.Location = new Point(13, 358);
            rtbxDesc.Name = "rtbxDesc";
            rtbxDesc.Size = new Size(215, 99);
            rtbxDesc.TabIndex = 14;
            rtbxDesc.Text = "";
            // 
            // lbEmailCliente
            // 
            lbEmailCliente.AutoSize = true;
            lbEmailCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmailCliente.Location = new Point(13, 212);
            lbEmailCliente.Name = "lbEmailCliente";
            lbEmailCliente.Size = new Size(39, 15);
            lbEmailCliente.TabIndex = 16;
            lbEmailCliente.Text = "Email";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Microsoft Sans Serif", 9F);
            tbxEmail.Location = new Point(13, 230);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Digite aqui";
            tbxEmail.Size = new Size(216, 21);
            tbxEmail.TabIndex = 15;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(13, 254);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(55, 15);
            lbTelefone.TabIndex = 18;
            lbTelefone.Text = "Telefone";
            // 
            // tbxTelefone
            // 
            tbxTelefone.Font = new Font("Microsoft Sans Serif", 9F);
            tbxTelefone.Location = new Point(12, 272);
            tbxTelefone.Name = "tbxTelefone";
            tbxTelefone.PlaceholderText = "Digite aqui";
            tbxTelefone.Size = new Size(216, 21);
            tbxTelefone.TabIndex = 17;
            // 
            // lbDataCliente
            // 
            lbDataCliente.AutoSize = true;
            lbDataCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDataCliente.Location = new Point(12, 296);
            lbDataCliente.Name = "lbDataCliente";
            lbDataCliente.Size = new Size(99, 15);
            lbDataCliente.TabIndex = 19;
            lbDataCliente.Text = "Primeiro Contato";
            // 
            // dateContatoCliente
            // 
            dateContatoCliente.Format = DateTimePickerFormat.Short;
            dateContatoCliente.Location = new Point(13, 314);
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
            btnCriar.Location = new Point(708, 427);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(115, 46);
            btnCriar.TabIndex = 21;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // tbxDocumento
            // 
            tbxDocumento.Location = new Point(14, 186);
            tbxDocumento.Name = "tbxDocumento";
            tbxDocumento.Size = new Size(215, 23);
            tbxDocumento.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 23;
            label1.Text = "Dados Pessoais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 53);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 24;
            label2.Text = "Dados de Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(300, 82);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 26;
            label3.Text = "CEP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(300, 124);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 28;
            label4.Text = "Estado";
            // 
            // tbxEstado
            // 
            tbxEstado.BackColor = SystemColors.Window;
            tbxEstado.Font = new Font("Microsoft Sans Serif", 9F);
            tbxEstado.Location = new Point(300, 142);
            tbxEstado.Name = "tbxEstado";
            tbxEstado.PlaceholderText = "Digite aqui";
            tbxEstado.ReadOnly = true;
            tbxEstado.Size = new Size(215, 21);
            tbxEstado.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(300, 166);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 30;
            label5.Text = "Cidade";
            // 
            // tbxCidade
            // 
            tbxCidade.BackColor = SystemColors.Window;
            tbxCidade.Font = new Font("Microsoft Sans Serif", 9F);
            tbxCidade.Location = new Point(300, 184);
            tbxCidade.Name = "tbxCidade";
            tbxCidade.PlaceholderText = "Digite aqui";
            tbxCidade.ReadOnly = true;
            tbxCidade.Size = new Size(215, 21);
            tbxCidade.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(299, 208);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 32;
            label6.Text = "Bairro";
            // 
            // tbxBairro
            // 
            tbxBairro.BackColor = SystemColors.Window;
            tbxBairro.Font = new Font("Microsoft Sans Serif", 9F);
            tbxBairro.Location = new Point(299, 226);
            tbxBairro.Name = "tbxBairro";
            tbxBairro.PlaceholderText = "Digite aqui";
            tbxBairro.ReadOnly = true;
            tbxBairro.Size = new Size(215, 21);
            tbxBairro.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(300, 250);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 34;
            label7.Text = "Logradouro";
            // 
            // tbxLogradouro
            // 
            tbxLogradouro.BackColor = SystemColors.Window;
            tbxLogradouro.Font = new Font("Microsoft Sans Serif", 9F);
            tbxLogradouro.Location = new Point(300, 268);
            tbxLogradouro.Name = "tbxLogradouro";
            tbxLogradouro.PlaceholderText = "Digite aqui";
            tbxLogradouro.ReadOnly = true;
            tbxLogradouro.Size = new Size(215, 21);
            tbxLogradouro.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(300, 292);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 36;
            label8.Text = "Numero Residencial";
            // 
            // tbxNumero
            // 
            tbxNumero.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNumero.Location = new Point(300, 310);
            tbxNumero.Name = "tbxNumero";
            tbxNumero.PlaceholderText = "Digite aqui";
            tbxNumero.Size = new Size(215, 21);
            tbxNumero.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(300, 334);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 37;
            label9.Text = "Tipo de Endereço";
            // 
            // cbxTipo
            // 
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipo.Font = new Font("Microsoft Sans Serif", 9F);
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Residencial", "Comercial", "Outro" });
            cbxTipo.Location = new Point(300, 352);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(215, 23);
            cbxTipo.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(300, 378);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 40;
            label10.Text = "Complemento";
            // 
            // tbxComplemento
            // 
            tbxComplemento.Font = new Font("Microsoft Sans Serif", 9F);
            tbxComplemento.Location = new Point(300, 396);
            tbxComplemento.Name = "tbxComplemento";
            tbxComplemento.PlaceholderText = "Digite aqui";
            tbxComplemento.Size = new Size(215, 21);
            tbxComplemento.TabIndex = 39;
            // 
            // tbxCEP
            // 
            tbxCEP.Location = new Point(301, 98);
            tbxCEP.Mask = "00000-000";
            tbxCEP.Name = "tbxCEP";
            tbxCEP.Size = new Size(214, 23);
            tbxCEP.TabIndex = 41;
            tbxCEP.Leave += tbxCEP_Leave;
            // 
            // formAdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 476);
            Controls.Add(tbxCEP);
            Controls.Add(label10);
            Controls.Add(tbxComplemento);
            Controls.Add(cbxTipo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tbxNumero);
            Controls.Add(label7);
            Controls.Add(tbxLogradouro);
            Controls.Add(label6);
            Controls.Add(tbxBairro);
            Controls.Add(label5);
            Controls.Add(tbxCidade);
            Controls.Add(label4);
            Controls.Add(tbxEstado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxDocumento);
            Controls.Add(btnCriar);
            Controls.Add(dateContatoCliente);
            Controls.Add(lbDataCliente);
            Controls.Add(lbTelefone);
            Controls.Add(tbxTelefone);
            Controls.Add(lbEmailCliente);
            Controls.Add(tbxEmail);
            Controls.Add(rtbxDesc);
            Controls.Add(lbDescricaoCliente);
            Controls.Add(lbDocumento);
            Controls.Add(cbxTipoCliente);
            Controls.Add(lbTipo);
            Controls.Add(lbNome);
            Controls.Add(tbxNomeCliente);
            Controls.Add(lbTituloAC);
            Name = "formAdicionarCliente";
            Text = "Adicionar Cliente";
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
        private Label lbDocumento;
        private Label lbDescricaoCliente;
        private RichTextBox rtbxDesc;
        private Label lbEmailCliente;
        private TextBox tbxEmail;
        private Label lbTelefone;
        private TextBox tbxTelefone;
        private Label lbDataCliente;
        private DateTimePicker dateContatoCliente;
        private Button btnCriar;
        private MaskedTextBox tbxDocumento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxEstado;
        private Label label5;
        private TextBox tbxCidade;
        private Label label6;
        private TextBox tbxBairro;
        private Label label7;
        private TextBox tbxLogradouro;
        private Label label8;
        private TextBox tbxNumero;
        private Label label9;
        private ComboBox cbxTipo;
        private Label label10;
        private TextBox tbxComplemento;
        private MaskedTextBox tbxCEP;
    }
}