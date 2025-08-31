namespace CRM_Advocacia___Windows_Forms
{
    partial class formAdicionarProcesso
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
            lbNome = new Label();
            tbxTituloProcesso = new TextBox();
            label1 = new Label();
            tbxNumeroProcesso = new TextBox();
            cbxTipoProcesso = new ComboBox();
            lbTipo = new Label();
            dateInicioProcesso = new DateTimePicker();
            lbDataCliente = new Label();
            rtbxDesc = new RichTextBox();
            lbDescricaoCliente = new Label();
            label2 = new Label();
            tbxNomeCliente = new TextBox();
            label3 = new Label();
            tbxNomeAdvogado = new TextBox();
            label4 = new Label();
            numValorProces = new NumericUpDown();
            btnCriar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbxDescHonora = new TextBox();
            numValorHonor = new NumericUpDown();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numValorProces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValorHonor).BeginInit();
            SuspendLayout();
            // 
            // lbTituloAC
            // 
            lbTituloAC.AutoSize = true;
            lbTituloAC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloAC.Location = new Point(304, 9);
            lbTituloAC.Name = "lbTituloAC";
            lbTituloAC.Size = new Size(192, 24);
            lbTituloAC.TabIndex = 4;
            lbTituloAC.Text = "Adicionar Processo";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(12, 139);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(108, 15);
            lbNome.TabIndex = 7;
            lbNome.Text = "Titulo do Processo";
            // 
            // tbxTituloProcesso
            // 
            tbxTituloProcesso.Font = new Font("Microsoft Sans Serif", 9F);
            tbxTituloProcesso.Location = new Point(12, 157);
            tbxTituloProcesso.Name = "tbxTituloProcesso";
            tbxTituloProcesso.PlaceholderText = "Digite aqui";
            tbxTituloProcesso.Size = new Size(215, 21);
            tbxTituloProcesso.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 9;
            label1.Text = "Numero do Processo";
            // 
            // tbxNumeroProcesso
            // 
            tbxNumeroProcesso.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNumeroProcesso.Location = new Point(12, 115);
            tbxNumeroProcesso.Name = "tbxNumeroProcesso";
            tbxNumeroProcesso.PlaceholderText = "Digite aqui";
            tbxNumeroProcesso.Size = new Size(215, 21);
            tbxNumeroProcesso.TabIndex = 8;
            // 
            // cbxTipoProcesso
            // 
            cbxTipoProcesso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoProcesso.Font = new Font("Microsoft Sans Serif", 9F);
            cbxTipoProcesso.FormattingEnabled = true;
            cbxTipoProcesso.Items.AddRange(new object[] { "Trabalhista", "Cível", "Criminal", "Tributário", "Família", "Outros" });
            cbxTipoProcesso.Location = new Point(12, 199);
            cbxTipoProcesso.Name = "cbxTipoProcesso";
            cbxTipoProcesso.Size = new Size(215, 23);
            cbxTipoProcesso.TabIndex = 11;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTipo.Location = new Point(12, 181);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(88, 15);
            lbTipo.TabIndex = 10;
            lbTipo.Text = "Área do Direito";
            // 
            // dateInicioProcesso
            // 
            dateInicioProcesso.Format = DateTimePickerFormat.Short;
            dateInicioProcesso.Location = new Point(13, 243);
            dateInicioProcesso.Name = "dateInicioProcesso";
            dateInicioProcesso.Size = new Size(216, 23);
            dateInicioProcesso.TabIndex = 22;
            // 
            // lbDataCliente
            // 
            lbDataCliente.AutoSize = true;
            lbDataCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDataCliente.Location = new Point(12, 225);
            lbDataCliente.Name = "lbDataCliente";
            lbDataCliente.Size = new Size(82, 15);
            lbDataCliente.TabIndex = 21;
            lbDataCliente.Text = "Data de Inicio";
            // 
            // rtbxDesc
            // 
            rtbxDesc.Location = new Point(12, 287);
            rtbxDesc.Name = "rtbxDesc";
            rtbxDesc.Size = new Size(215, 99);
            rtbxDesc.TabIndex = 24;
            rtbxDesc.Text = "";
            // 
            // lbDescricaoCliente
            // 
            lbDescricaoCliente.AutoSize = true;
            lbDescricaoCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescricaoCliente.Location = new Point(12, 269);
            lbDescricaoCliente.Name = "lbDescricaoCliente";
            lbDescricaoCliente.Size = new Size(62, 15);
            lbDescricaoCliente.TabIndex = 23;
            lbDescricaoCliente.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 389);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 26;
            label2.Text = "Nome do Cliente";
            // 
            // tbxNomeCliente
            // 
            tbxNomeCliente.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNomeCliente.Location = new Point(12, 407);
            tbxNomeCliente.Name = "tbxNomeCliente";
            tbxNomeCliente.PlaceholderText = "Digite aqui";
            tbxNomeCliente.Size = new Size(215, 21);
            tbxNomeCliente.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 431);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 28;
            label3.Text = "Nome do Advogado";
            // 
            // tbxNomeAdvogado
            // 
            tbxNomeAdvogado.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNomeAdvogado.Location = new Point(12, 449);
            tbxNomeAdvogado.Name = "tbxNomeAdvogado";
            tbxNomeAdvogado.PlaceholderText = "Digite aqui";
            tbxNomeAdvogado.Size = new Size(215, 21);
            tbxNomeAdvogado.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 97);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 30;
            label4.Text = "Valor do Processo";
            // 
            // numValorProces
            // 
            numValorProces.DecimalPlaces = 2;
            numValorProces.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numValorProces.Location = new Point(390, 115);
            numValorProces.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numValorProces.Name = "numValorProces";
            numValorProces.Size = new Size(215, 23);
            numValorProces.TabIndex = 31;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkGreen;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.Control;
            btnCriar.Location = new Point(723, 431);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(100, 33);
            btnCriar.TabIndex = 32;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 68);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 33;
            label5.Text = "Dados do Processo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(390, 68);
            label6.Name = "label6";
            label6.Size = new Size(207, 20);
            label6.TabIndex = 34;
            label6.Text = "Informações Financeiras";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(390, 139);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 36;
            label7.Text = "Descrição do Honorario";
            // 
            // tbxDescHonora
            // 
            tbxDescHonora.Font = new Font("Microsoft Sans Serif", 9F);
            tbxDescHonora.Location = new Point(390, 157);
            tbxDescHonora.Name = "tbxDescHonora";
            tbxDescHonora.PlaceholderText = "Digite aqui";
            tbxDescHonora.Size = new Size(215, 21);
            tbxDescHonora.TabIndex = 35;
            // 
            // numValorHonor
            // 
            numValorHonor.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numValorHonor.Location = new Point(390, 199);
            numValorHonor.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numValorHonor.Name = "numValorHonor";
            numValorHonor.Size = new Size(215, 23);
            numValorHonor.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(390, 181);
            label8.Name = "label8";
            label8.Size = new Size(153, 15);
            label8.TabIndex = 37;
            label8.Text = "Valor do Honorario (em %)";
            // 
            // formAdicionarProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 476);
            Controls.Add(numValorHonor);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tbxDescHonora);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCriar);
            Controls.Add(numValorProces);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbxNomeAdvogado);
            Controls.Add(label2);
            Controls.Add(tbxNomeCliente);
            Controls.Add(rtbxDesc);
            Controls.Add(lbDescricaoCliente);
            Controls.Add(dateInicioProcesso);
            Controls.Add(lbDataCliente);
            Controls.Add(cbxTipoProcesso);
            Controls.Add(lbTipo);
            Controls.Add(label1);
            Controls.Add(tbxNumeroProcesso);
            Controls.Add(lbNome);
            Controls.Add(tbxTituloProcesso);
            Controls.Add(lbTituloAC);
            Name = "formAdicionarProcesso";
            Text = "formAdicionarProcesso";
            Load += formAdicionarProcesso_Load;
            ((System.ComponentModel.ISupportInitialize)numValorProces).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValorHonor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloAC;
        private Label lbNome;
        private TextBox tbxTituloProcesso;
        private Label label1;
        private TextBox tbxNumeroProcesso;
        private ComboBox cbxTipoProcesso;
        private Label lbTipo;
        private DateTimePicker dateInicioProcesso;
        private Label lbDataCliente;
        private RichTextBox rtbxDesc;
        private Label lbDescricaoCliente;
        private Label label2;
        private TextBox tbxNomeCliente;
        private Label label3;
        private TextBox tbxNomeAdvogado;
        private Label label4;
        private TextBox tbxDescHonora;
        private NumericUpDown numValorProces;
        private Button btnCriar;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numValorHonor;
        private Label label8;
    }
}