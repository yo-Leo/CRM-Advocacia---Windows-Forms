namespace CRM_Advocacia___Windows_Forms
{
    partial class formAdicionarPrazo
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
            tbxNumero = new TextBox();
            cbxTipo = new ComboBox();
            label3 = new Label();
            rtbxDesc = new RichTextBox();
            lbDescricaoCliente = new Label();
            datePrazo = new DateTimePicker();
            label4 = new Label();
            btnCriar = new Button();
            SuspendLayout();
            // 
            // lbTituloAC
            // 
            lbTituloAC.AutoSize = true;
            lbTituloAC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloAC.Location = new Point(146, 9);
            lbTituloAC.Name = "lbTituloAC";
            lbTituloAC.Size = new Size(158, 24);
            lbTituloAC.TabIndex = 5;
            lbTituloAC.Text = "Adicionar Prazo";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(119, 64);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(164, 15);
            lbNome.TabIndex = 27;
            lbNome.Text = "Nº do Processo Relacionado";
            // 
            // tbxNumero
            // 
            tbxNumero.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNumero.Location = new Point(119, 82);
            tbxNumero.Name = "tbxNumero";
            tbxNumero.PlaceholderText = "Digite aqui";
            tbxNumero.Size = new Size(215, 21);
            tbxNumero.TabIndex = 26;
            // 
            // cbxTipo
            // 
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Todos", "Audiência", "Protocolo", "Prazo Recursal", "Outro" });
            cbxTipo.Location = new Point(119, 126);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(215, 23);
            cbxTipo.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(119, 106);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 28;
            label3.Text = "Tipo de Prazo";
            // 
            // rtbxDesc
            // 
            rtbxDesc.Location = new Point(119, 216);
            rtbxDesc.Name = "rtbxDesc";
            rtbxDesc.Size = new Size(215, 99);
            rtbxDesc.TabIndex = 31;
            rtbxDesc.Text = "";
            // 
            // lbDescricaoCliente
            // 
            lbDescricaoCliente.AutoSize = true;
            lbDescricaoCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescricaoCliente.Location = new Point(119, 198);
            lbDescricaoCliente.Name = "lbDescricaoCliente";
            lbDescricaoCliente.Size = new Size(78, 15);
            lbDescricaoCliente.TabIndex = 30;
            lbDescricaoCliente.Text = "Observações";
            // 
            // datePrazo
            // 
            datePrazo.Format = DateTimePickerFormat.Short;
            datePrazo.Location = new Point(119, 172);
            datePrazo.Name = "datePrazo";
            datePrazo.Size = new Size(215, 23);
            datePrazo.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(119, 152);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 32;
            label4.Text = "Data";
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkGreen;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.Control;
            btnCriar.Location = new Point(163, 445);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(100, 33);
            btnCriar.TabIndex = 34;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // formAdicionarPrazo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 490);
            Controls.Add(btnCriar);
            Controls.Add(datePrazo);
            Controls.Add(label4);
            Controls.Add(rtbxDesc);
            Controls.Add(lbDescricaoCliente);
            Controls.Add(cbxTipo);
            Controls.Add(label3);
            Controls.Add(lbNome);
            Controls.Add(tbxNumero);
            Controls.Add(lbTituloAC);
            Name = "formAdicionarPrazo";
            Text = "Adicionar Prazo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloAC;
        private Label lbNome;
        private TextBox tbxNumero;
        private ComboBox cbxTipo;
        private Label label3;
        private RichTextBox rtbxDesc;
        private Label lbDescricaoCliente;
        private DateTimePicker datePrazo;
        private Label label4;
        private Button btnCriar;
    }
}