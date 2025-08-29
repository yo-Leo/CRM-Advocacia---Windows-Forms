namespace CRM_Advocacia___Windows_Forms
{
    partial class formEditarCliente
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
            tbxCEP = new MaskedTextBox();
            label10 = new Label();
            tbxComplemento = new TextBox();
            cbxTipo = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            tbxNumero = new TextBox();
            label7 = new Label();
            tbxLogradouro = new TextBox();
            label6 = new Label();
            tbxBairro = new TextBox();
            label5 = new Label();
            tbxCidade = new TextBox();
            label4 = new Label();
            tbxEstado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbxDocumento = new MaskedTextBox();
            btnSalvar = new Button();
            dateContatoCliente = new DateTimePicker();
            lbDataCliente = new Label();
            lbTelefone = new Label();
            tbxTelefone = new TextBox();
            lbEmailCliente = new Label();
            tbxEmail = new TextBox();
            rtbxDesc = new RichTextBox();
            lbDescricaoCliente = new Label();
            lbDocumento = new Label();
            cbxTipoCliente = new ComboBox();
            lbTipo = new Label();
            lbNome = new Label();
            tbxNomeCliente = new TextBox();
            lbTituloAC = new Label();
            cbxAtividade = new ComboBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // tbxCEP
            // 
            tbxCEP.Location = new Point(301, 95);
            tbxCEP.Mask = "00000-000";
            tbxCEP.Name = "tbxCEP";
            tbxCEP.Size = new Size(214, 23);
            tbxCEP.TabIndex = 75;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(300, 375);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 74;
            label10.Text = "Complemento";
            // 
            // tbxComplemento
            // 
            tbxComplemento.Font = new Font("Microsoft Sans Serif", 9F);
            tbxComplemento.Location = new Point(300, 393);
            tbxComplemento.Name = "tbxComplemento";
            tbxComplemento.PlaceholderText = "Digite aqui";
            tbxComplemento.Size = new Size(215, 21);
            tbxComplemento.TabIndex = 73;
            // 
            // cbxTipo
            // 
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipo.Font = new Font("Microsoft Sans Serif", 9F);
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Residencial", "Comercial", "Outro" });
            cbxTipo.Location = new Point(300, 349);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(215, 23);
            cbxTipo.TabIndex = 72;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(300, 331);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 71;
            label9.Text = "Tipo de Endereço";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(300, 289);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 70;
            label8.Text = "Numero Residencial";
            // 
            // tbxNumero
            // 
            tbxNumero.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNumero.Location = new Point(300, 307);
            tbxNumero.Name = "tbxNumero";
            tbxNumero.PlaceholderText = "Digite aqui";
            tbxNumero.Size = new Size(215, 21);
            tbxNumero.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(300, 247);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 68;
            label7.Text = "Logradouro";
            // 
            // tbxLogradouro
            // 
            tbxLogradouro.BackColor = SystemColors.Window;
            tbxLogradouro.Font = new Font("Microsoft Sans Serif", 9F);
            tbxLogradouro.Location = new Point(300, 265);
            tbxLogradouro.Name = "tbxLogradouro";
            tbxLogradouro.PlaceholderText = "Digite aqui";
            tbxLogradouro.ReadOnly = true;
            tbxLogradouro.Size = new Size(215, 21);
            tbxLogradouro.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(299, 205);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 66;
            label6.Text = "Bairro";
            // 
            // tbxBairro
            // 
            tbxBairro.BackColor = SystemColors.Window;
            tbxBairro.Font = new Font("Microsoft Sans Serif", 9F);
            tbxBairro.Location = new Point(299, 223);
            tbxBairro.Name = "tbxBairro";
            tbxBairro.PlaceholderText = "Digite aqui";
            tbxBairro.ReadOnly = true;
            tbxBairro.Size = new Size(215, 21);
            tbxBairro.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(300, 163);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 64;
            label5.Text = "Cidade";
            // 
            // tbxCidade
            // 
            tbxCidade.BackColor = SystemColors.Window;
            tbxCidade.Font = new Font("Microsoft Sans Serif", 9F);
            tbxCidade.Location = new Point(300, 181);
            tbxCidade.Name = "tbxCidade";
            tbxCidade.PlaceholderText = "Digite aqui";
            tbxCidade.ReadOnly = true;
            tbxCidade.Size = new Size(215, 21);
            tbxCidade.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(300, 121);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 62;
            label4.Text = "Estado";
            // 
            // tbxEstado
            // 
            tbxEstado.BackColor = SystemColors.Window;
            tbxEstado.Font = new Font("Microsoft Sans Serif", 9F);
            tbxEstado.Location = new Point(300, 139);
            tbxEstado.Name = "tbxEstado";
            tbxEstado.PlaceholderText = "Digite aqui";
            tbxEstado.ReadOnly = true;
            tbxEstado.Size = new Size(215, 21);
            tbxEstado.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(300, 79);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 60;
            label3.Text = "CEP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 50);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 59;
            label2.Text = "Dados de Endereço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 58;
            label1.Text = "Dados Pessoais";
            // 
            // tbxDocumento
            // 
            tbxDocumento.Location = new Point(14, 183);
            tbxDocumento.Name = "tbxDocumento";
            tbxDocumento.Size = new Size(215, 23);
            tbxDocumento.TabIndex = 57;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkGreen;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Location = new Point(708, 424);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 46);
            btnSalvar.TabIndex = 56;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dateContatoCliente
            // 
            dateContatoCliente.Format = DateTimePickerFormat.Short;
            dateContatoCliente.Location = new Point(13, 311);
            dateContatoCliente.Name = "dateContatoCliente";
            dateContatoCliente.Size = new Size(216, 23);
            dateContatoCliente.TabIndex = 55;
            // 
            // lbDataCliente
            // 
            lbDataCliente.AutoSize = true;
            lbDataCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDataCliente.Location = new Point(12, 293);
            lbDataCliente.Name = "lbDataCliente";
            lbDataCliente.Size = new Size(99, 15);
            lbDataCliente.TabIndex = 54;
            lbDataCliente.Text = "Primeiro Contato";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(13, 251);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(55, 15);
            lbTelefone.TabIndex = 53;
            lbTelefone.Text = "Telefone";
            // 
            // tbxTelefone
            // 
            tbxTelefone.Font = new Font("Microsoft Sans Serif", 9F);
            tbxTelefone.Location = new Point(12, 269);
            tbxTelefone.Name = "tbxTelefone";
            tbxTelefone.PlaceholderText = "Digite aqui";
            tbxTelefone.Size = new Size(216, 21);
            tbxTelefone.TabIndex = 52;
            // 
            // lbEmailCliente
            // 
            lbEmailCliente.AutoSize = true;
            lbEmailCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmailCliente.Location = new Point(13, 209);
            lbEmailCliente.Name = "lbEmailCliente";
            lbEmailCliente.Size = new Size(39, 15);
            lbEmailCliente.TabIndex = 51;
            lbEmailCliente.Text = "Email";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Microsoft Sans Serif", 9F);
            tbxEmail.Location = new Point(13, 227);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Digite aqui";
            tbxEmail.Size = new Size(216, 21);
            tbxEmail.TabIndex = 50;
            // 
            // rtbxDesc
            // 
            rtbxDesc.Location = new Point(13, 355);
            rtbxDesc.Name = "rtbxDesc";
            rtbxDesc.Size = new Size(215, 99);
            rtbxDesc.TabIndex = 49;
            rtbxDesc.Text = "";
            // 
            // lbDescricaoCliente
            // 
            lbDescricaoCliente.AutoSize = true;
            lbDescricaoCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescricaoCliente.Location = new Point(13, 337);
            lbDescricaoCliente.Name = "lbDescricaoCliente";
            lbDescricaoCliente.Size = new Size(62, 15);
            lbDescricaoCliente.TabIndex = 48;
            lbDescricaoCliente.Text = "Descrição";
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDocumento.Location = new Point(12, 165);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(30, 15);
            lbDocumento.TabIndex = 47;
            lbDocumento.Text = "CPF";
            // 
            // cbxTipoCliente
            // 
            cbxTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoCliente.Font = new Font("Microsoft Sans Serif", 9F);
            cbxTipoCliente.FormattingEnabled = true;
            cbxTipoCliente.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            cbxTipoCliente.Location = new Point(12, 139);
            cbxTipoCliente.Name = "cbxTipoCliente";
            cbxTipoCliente.Size = new Size(215, 23);
            cbxTipoCliente.TabIndex = 46;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTipo.Location = new Point(12, 121);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(89, 15);
            lbTipo.TabIndex = 45;
            lbTipo.Text = "Tipo do Cliente";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(12, 79);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(99, 15);
            lbNome.TabIndex = 44;
            lbNome.Text = "Nome do Cliente";
            // 
            // tbxNomeCliente
            // 
            tbxNomeCliente.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNomeCliente.Location = new Point(12, 97);
            tbxNomeCliente.Name = "tbxNomeCliente";
            tbxNomeCliente.PlaceholderText = "Digite aqui";
            tbxNomeCliente.Size = new Size(215, 21);
            tbxNomeCliente.TabIndex = 43;
            // 
            // lbTituloAC
            // 
            lbTituloAC.AutoSize = true;
            lbTituloAC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloAC.Location = new Point(300, 6);
            lbTituloAC.Name = "lbTituloAC";
            lbTituloAC.Size = new Size(135, 24);
            lbTituloAC.TabIndex = 42;
            lbTituloAC.Text = "Editar Cliente";
            // 
            // cbxAtividade
            // 
            cbxAtividade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAtividade.Font = new Font("Microsoft Sans Serif", 9F);
            cbxAtividade.FormattingEnabled = true;
            cbxAtividade.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cbxAtividade.Location = new Point(558, 97);
            cbxAtividade.Name = "cbxAtividade";
            cbxAtividade.Size = new Size(215, 23);
            cbxAtividade.TabIndex = 77;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(558, 79);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 76;
            label11.Text = "Atividade";
            // 
            // formEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 476);
            Controls.Add(cbxAtividade);
            Controls.Add(label11);
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
            Controls.Add(btnSalvar);
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
            Name = "formEditarCliente";
            Text = "formEditarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox tbxCEP;
        private Label label10;
        private TextBox tbxComplemento;
        private ComboBox cbxTipo;
        private Label label9;
        private Label label8;
        private TextBox tbxNumero;
        private Label label7;
        private TextBox tbxLogradouro;
        private Label label6;
        private TextBox tbxBairro;
        private Label label5;
        private TextBox tbxCidade;
        private Label label4;
        private TextBox tbxEstado;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox tbxDocumento;
        private Button btnSalvar;
        private DateTimePicker dateContatoCliente;
        private Label lbDataCliente;
        private Label lbTelefone;
        private TextBox tbxTelefone;
        private Label lbEmailCliente;
        private TextBox tbxEmail;
        private RichTextBox rtbxDesc;
        private Label lbDescricaoCliente;
        private Label lbDocumento;
        private ComboBox cbxTipoCliente;
        private Label lbTipo;
        private Label lbNome;
        private TextBox tbxNomeCliente;
        private Label lbTituloAC;
        private ComboBox cbxAtividade;
        private Label label11;
    }
}