namespace CRM_Advocacia___Windows_Forms
{
    partial class formEditarEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditarEquipe));
            btnCriar = new Button();
            cbxTipoEquipe = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            btnFoto = new Button();
            pbxFoto = new PictureBox();
            label2 = new Label();
            lbTelefone = new Label();
            tbxTelefone = new TextBox();
            lbEmailCliente = new Label();
            tbxEmail = new TextBox();
            label1 = new Label();
            lbNome = new Label();
            tbxNome = new TextBox();
            lbTituloAC = new Label();
            cbxAtividade = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxFoto).BeginInit();
            SuspendLayout();
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkGreen;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.Control;
            btnCriar.Location = new Point(708, 423);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(115, 46);
            btnCriar.TabIndex = 71;
            btnCriar.Text = "ATUALIZAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnAtualizar_Click;
            // 
            // cbxTipoEquipe
            // 
            cbxTipoEquipe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoEquipe.Font = new Font("Microsoft Sans Serif", 9F);
            cbxTipoEquipe.FormattingEnabled = true;
            cbxTipoEquipe.Items.AddRange(new object[] { "Secretário", "Estagiário", "Financeiro", "RH", "Outro" });
            cbxTipoEquipe.Location = new Point(331, 111);
            cbxTipoEquipe.Name = "cbxTipoEquipe";
            cbxTipoEquipe.Size = new Size(215, 23);
            cbxTipoEquipe.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(331, 95);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 69;
            label5.Text = "Cargo do Membro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 66);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 68;
            label3.Text = "Dados Profissionais";
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(117, 315);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(118, 23);
            btnFoto.TabIndex = 67;
            btnFoto.Text = "Selecionar imagem";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // pbxFoto
            // 
            pbxFoto.Image = (Image)resources.GetObject("pbxFoto.Image");
            pbxFoto.Location = new Point(11, 239);
            pbxFoto.Name = "pbxFoto";
            pbxFoto.Size = new Size(100, 99);
            pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFoto.TabIndex = 66;
            pbxFoto.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 65;
            label2.Text = "Foto";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(12, 179);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(55, 15);
            lbTelefone.TabIndex = 64;
            lbTelefone.Text = "Telefone";
            // 
            // tbxTelefone
            // 
            tbxTelefone.Font = new Font("Microsoft Sans Serif", 9F);
            tbxTelefone.Location = new Point(11, 197);
            tbxTelefone.Name = "tbxTelefone";
            tbxTelefone.PlaceholderText = "Digite aqui";
            tbxTelefone.Size = new Size(216, 21);
            tbxTelefone.TabIndex = 63;
            // 
            // lbEmailCliente
            // 
            lbEmailCliente.AutoSize = true;
            lbEmailCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmailCliente.Location = new Point(12, 137);
            lbEmailCliente.Name = "lbEmailCliente";
            lbEmailCliente.Size = new Size(39, 15);
            lbEmailCliente.TabIndex = 62;
            lbEmailCliente.Text = "Email";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Microsoft Sans Serif", 9F);
            tbxEmail.Location = new Point(12, 155);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Digite aqui";
            tbxEmail.Size = new Size(216, 21);
            tbxEmail.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 60;
            label1.Text = "Dados Pessoais";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(12, 95);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(108, 15);
            lbNome.TabIndex = 59;
            lbNome.Text = "Nome do Membro";
            // 
            // tbxNome
            // 
            tbxNome.Font = new Font("Microsoft Sans Serif", 9F);
            tbxNome.Location = new Point(12, 113);
            tbxNome.Name = "tbxNome";
            tbxNome.PlaceholderText = "Digite aqui";
            tbxNome.Size = new Size(215, 21);
            tbxNome.TabIndex = 58;
            // 
            // lbTituloAC
            // 
            lbTituloAC.AutoSize = true;
            lbTituloAC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloAC.Location = new Point(262, 8);
            lbTituloAC.Name = "lbTituloAC";
            lbTituloAC.Size = new Size(275, 24);
            lbTituloAC.TabIndex = 57;
            lbTituloAC.Text = "Atualizar Membro da Equipe";
            // 
            // cbxAtividade
            // 
            cbxAtividade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAtividade.Font = new Font("Microsoft Sans Serif", 9F);
            cbxAtividade.FormattingEnabled = true;
            cbxAtividade.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cbxAtividade.Location = new Point(331, 153);
            cbxAtividade.Name = "cbxAtividade";
            cbxAtividade.Size = new Size(215, 23);
            cbxAtividade.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(331, 137);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 72;
            label4.Text = "Atividade";
            // 
            // formEditarEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 476);
            Controls.Add(cbxAtividade);
            Controls.Add(label4);
            Controls.Add(btnCriar);
            Controls.Add(cbxTipoEquipe);
            Controls.Add(label5);
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
            Name = "formEditarEquipe";
            Text = "formEditarEquipe";
            ((System.ComponentModel.ISupportInitialize)pbxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCriar;
        private ComboBox cbxTipoEquipe;
        private Label label5;
        private Label label3;
        private Button btnFoto;
        private PictureBox pbxFoto;
        private Label label2;
        private Label lbTelefone;
        private TextBox tbxTelefone;
        private Label lbEmailCliente;
        private TextBox tbxEmail;
        private Label label1;
        private Label lbNome;
        private TextBox tbxNome;
        private Label lbTituloAC;
        private ComboBox cbxAtividade;
        private Label label4;
    }
}