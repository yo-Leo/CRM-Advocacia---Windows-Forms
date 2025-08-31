namespace CRM_Advocacia___Windows_Forms
{
    partial class formAdicionarAdvogado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdicionarAdvogado));
            lbTituloAC = new Label();
            label1 = new Label();
            lbNome = new Label();
            tbxNome = new TextBox();
            lbTelefone = new Label();
            tbxTelefone = new TextBox();
            lbEmailCliente = new Label();
            tbxEmail = new TextBox();
            label2 = new Label();
            pbxFoto = new PictureBox();
            btnFoto = new Button();
            label3 = new Label();
            label4 = new Label();
            tbxOAB = new TextBox();
            label5 = new Label();
            cbxTipoAdvogado = new ComboBox();
            btnCriar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxFoto).BeginInit();
            SuspendLayout();
            // 
            // lbTituloAC
            // 
            lbTituloAC.AutoSize = true;
            lbTituloAC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloAC.Location = new Point(287, 9);
            lbTituloAC.Name = "lbTituloAC";
            lbTituloAC.Size = new Size(200, 24);
            lbTituloAC.TabIndex = 4;
            lbTituloAC.Text = "Adicionar Advogado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 26;
            label1.Text = "Dados Pessoais";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(12, 99);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(115, 15);
            lbNome.TabIndex = 25;
            lbNome.Text = "Nome do Advogado";
            // 
            // tbxNome
            // 
            tbxNome.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNome.Location = new Point(12, 117);
            tbxNome.Name = "tbxNome";
            tbxNome.PlaceholderText = "Digite aqui";
            tbxNome.Size = new Size(215, 21);
            tbxNome.TabIndex = 24;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(12, 183);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(55, 15);
            lbTelefone.TabIndex = 30;
            lbTelefone.Text = "Telefone";
            // 
            // tbxTelefone
            // 
            tbxTelefone.Font = new Font("Microsoft Sans Serif", 9F);
            tbxTelefone.Location = new Point(11, 201);
            tbxTelefone.Name = "tbxTelefone";
            tbxTelefone.PlaceholderText = "Digite aqui";
            tbxTelefone.Size = new Size(216, 21);
            tbxTelefone.TabIndex = 29;
            // 
            // lbEmailCliente
            // 
            lbEmailCliente.AutoSize = true;
            lbEmailCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmailCliente.Location = new Point(12, 141);
            lbEmailCliente.Name = "lbEmailCliente";
            lbEmailCliente.Size = new Size(39, 15);
            lbEmailCliente.TabIndex = 28;
            lbEmailCliente.Text = "Email";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Microsoft Sans Serif", 9F);
            tbxEmail.Location = new Point(12, 159);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Digite aqui";
            tbxEmail.Size = new Size(216, 21);
            tbxEmail.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 31;
            label2.Text = "Foto";
            // 
            // pbxFoto
            // 
            pbxFoto.Image = (Image)resources.GetObject("pbxFoto.Image");
            pbxFoto.Location = new Point(11, 243);
            pbxFoto.Name = "pbxFoto";
            pbxFoto.Size = new Size(100, 99);
            pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFoto.TabIndex = 32;
            pbxFoto.TabStop = false;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(117, 319);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(118, 23);
            btnFoto.TabIndex = 33;
            btnFoto.Text = "Selecionar imagem";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 70);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 34;
            label3.Text = "Dados Profissionais";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(331, 99);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 36;
            label4.Text = "Nº de Registro da OAB";
            // 
            // tbxOAB
            // 
            tbxOAB.Font = new Font("Microsoft Sans Serif", 9F);
            tbxOAB.Location = new Point(331, 117);
            tbxOAB.Name = "tbxOAB";
            tbxOAB.PlaceholderText = "Digite aqui";
            tbxOAB.Size = new Size(215, 21);
            tbxOAB.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(331, 141);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 37;
            label5.Text = "Especialidade";
            // 
            // cbxTipoAdvogado
            // 
            cbxTipoAdvogado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoAdvogado.Font = new Font("Microsoft Sans Serif", 9F);
            cbxTipoAdvogado.FormattingEnabled = true;
            cbxTipoAdvogado.Items.AddRange(new object[] { "Trabalhista", "Cível", "Criminal", "Tributário", "Família", "Outros" });
            cbxTipoAdvogado.Location = new Point(331, 157);
            cbxTipoAdvogado.Name = "cbxTipoAdvogado";
            cbxTipoAdvogado.Size = new Size(215, 23);
            cbxTipoAdvogado.TabIndex = 38;
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
            btnCriar.TabIndex = 39;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // formAdicionarAdvogado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 476);
            Controls.Add(btnCriar);
            Controls.Add(cbxTipoAdvogado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbxOAB);
            Controls.Add(label3);
            Controls.Add(btnFoto);
            Controls.Add(pbxFoto);
            Controls.Add(label2);
            Controls.Add(lbTelefone);
            Controls.Add(tbxTelefone);
            Controls.Add(lbEmailCliente);
            Controls.Add(tbxEmail);
            Controls.Add(label1);
            Controls.Add(lbNome);
            Controls.Add(tbxNome);
            Controls.Add(lbTituloAC);
            Name = "formAdicionarAdvogado";
            Text = "formAdicionarAdvogado";
            Load += formAdicionarAdvogado_Load;
            ((System.ComponentModel.ISupportInitialize)pbxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloAC;
        private Label label1;
        private Label lbNome;
        private TextBox tbxNome;
        private Label lbTelefone;
        private TextBox tbxTelefone;
        private Label lbEmailCliente;
        private TextBox tbxEmail;
        private Label label2;
        public PictureBox pbxFoto;
        private Button btnFoto;
        private Label label3;
        private Label label4;
        private TextBox tbxOAB;
        private Label label5;
        private ComboBox cbxTipoAdvogado;
        private Button btnCriar;
    }
}