namespace CRM_Advocacia___Windows_Forms
{
    partial class formTelaPadrão
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTelaPadrão));
            picLogo = new PictureBox();
            pnlMenu = new Panel();
            btnSair = new Button();
            pnlNav = new Panel();
            btnHonorarios = new Button();
            btnPrazo = new Button();
            btnProcessos = new Button();
            btnEquipe = new Button();
            btnClientes = new Button();
            btnPaginaInici = new Button();
            pnlProfile = new Panel();
            pnlFormLoader = new Panel();
            labelUserName = new Label();
            picProfile = new PictureBox();
            lbTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlMenu.SuspendLayout();
            pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackgroundImage = Properties.Resources._48ebd45a_28a5_4555_9ba7_10710817959d;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.InitialImage = null;
            picLogo.Location = new Point(1255, 657);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(117, 108);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.DimGray;
            pnlMenu.Controls.Add(btnSair);
            pnlMenu.Controls.Add(pnlNav);
            pnlMenu.Controls.Add(btnHonorarios);
            pnlMenu.Controls.Add(btnPrazo);
            pnlMenu.Controls.Add(btnProcessos);
            pnlMenu.Controls.Add(btnEquipe);
            pnlMenu.Controls.Add(btnClientes);
            pnlMenu.Controls.Add(btnPaginaInici);
            pnlMenu.Controls.Add(pnlProfile);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(186, 661);
            pnlMenu.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Bottom;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(0, 619);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(186, 42);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            btnSair.Leave += btnSair_Leave;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Gainsboro;
            pnlNav.Location = new Point(3, 192);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(5, 100);
            pnlNav.TabIndex = 3;
            // 
            // btnHonorarios
            // 
            btnHonorarios.Dock = DockStyle.Top;
            btnHonorarios.FlatAppearance.BorderSize = 0;
            btnHonorarios.FlatStyle = FlatStyle.Flat;
            btnHonorarios.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHonorarios.ForeColor = Color.White;
            btnHonorarios.Location = new Point(0, 360);
            btnHonorarios.Name = "btnHonorarios";
            btnHonorarios.Size = new Size(186, 42);
            btnHonorarios.TabIndex = 7;
            btnHonorarios.Text = "Honorarios";
            btnHonorarios.UseVisualStyleBackColor = true;
            btnHonorarios.Click += btnHonorarios_Click;
            btnHonorarios.Leave += btnHonorarios_Leave;
            // 
            // btnPrazo
            // 
            btnPrazo.Dock = DockStyle.Top;
            btnPrazo.FlatAppearance.BorderSize = 0;
            btnPrazo.FlatStyle = FlatStyle.Flat;
            btnPrazo.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrazo.ForeColor = Color.White;
            btnPrazo.Location = new Point(0, 318);
            btnPrazo.Name = "btnPrazo";
            btnPrazo.Size = new Size(186, 42);
            btnPrazo.TabIndex = 6;
            btnPrazo.Text = "Prazos";
            btnPrazo.UseVisualStyleBackColor = true;
            btnPrazo.Click += btnPrazo_Click;
            btnPrazo.Leave += btnPrazo_Leave;
            // 
            // btnProcessos
            // 
            btnProcessos.Dock = DockStyle.Top;
            btnProcessos.FlatAppearance.BorderSize = 0;
            btnProcessos.FlatStyle = FlatStyle.Flat;
            btnProcessos.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcessos.ForeColor = Color.White;
            btnProcessos.Location = new Point(0, 276);
            btnProcessos.Name = "btnProcessos";
            btnProcessos.Size = new Size(186, 42);
            btnProcessos.TabIndex = 5;
            btnProcessos.Text = "Processos";
            btnProcessos.UseVisualStyleBackColor = true;
            btnProcessos.Click += btnProcessos_Click;
            btnProcessos.Leave += btnProcessos_Leave;
            // 
            // btnEquipe
            // 
            btnEquipe.Dock = DockStyle.Top;
            btnEquipe.FlatAppearance.BorderSize = 0;
            btnEquipe.FlatStyle = FlatStyle.Flat;
            btnEquipe.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipe.ForeColor = Color.White;
            btnEquipe.Location = new Point(0, 234);
            btnEquipe.Name = "btnEquipe";
            btnEquipe.Size = new Size(186, 42);
            btnEquipe.TabIndex = 4;
            btnEquipe.Text = "Equipe";
            btnEquipe.UseVisualStyleBackColor = true;
            btnEquipe.Click += btnEquipe_Click;
            btnEquipe.Leave += btnEquipe_Leave;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 192);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(186, 42);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            btnClientes.Leave += btnClientes_Leave;
            // 
            // btnPaginaInici
            // 
            btnPaginaInici.BackColor = Color.DimGray;
            btnPaginaInici.Dock = DockStyle.Top;
            btnPaginaInici.FlatAppearance.BorderSize = 0;
            btnPaginaInici.FlatStyle = FlatStyle.Flat;
            btnPaginaInici.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaginaInici.ForeColor = Color.White;
            btnPaginaInici.Location = new Point(0, 150);
            btnPaginaInici.Name = "btnPaginaInici";
            btnPaginaInici.Size = new Size(186, 42);
            btnPaginaInici.TabIndex = 2;
            btnPaginaInici.Text = "Pagina Principal";
            btnPaginaInici.UseVisualStyleBackColor = false;
            btnPaginaInici.Click += btnPaginaInici_Click;
            btnPaginaInici.Leave += btnPaginaInici_Leave;
            // 
            // pnlProfile
            // 
            pnlProfile.Controls.Add(labelUserName);
            pnlProfile.Controls.Add(picProfile);
            pnlProfile.Dock = DockStyle.Top;
            pnlProfile.Location = new Point(0, 0);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(186, 150);
            pnlProfile.TabIndex = 2;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Location = new Point(186, 35);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1163, 626);
            pnlFormLoader.TabIndex = 3;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.ForeColor = Color.White;
            labelUserName.Location = new Point(49, 88);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(85, 16);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "User Name";
            // 
            // picProfile
            // 
            picProfile.Image = (Image)resources.GetObject("picProfile.Image");
            picProfile.Location = new Point(60, 22);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(63, 63);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 2;
            picProfile.TabStop = false;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(186, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(238, 32);
            lbTitulo.TabIndex = 2;
            lbTitulo.Text = "Pagina Principal";
            // 
            // formTelaPadrão
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 661);
            Controls.Add(lbTitulo);
            Controls.Add(pnlMenu);
            Controls.Add(picLogo);
            Controls.Add(pnlFormLoader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "formTelaPadrão";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRM - LegalMind";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Panel pnlMenu;
        private Panel pnlProfile;
        private PictureBox picProfile;
        private Label labelUserName;
        private Button btnPaginaInici;
        private Button btnEquipe;
        private Button btnClientes;
        private Button btnProcessos;
        private Button btnPrazo;
        private Button btnHonorarios;
        private Panel pnlNav;
        private Button btnSair;
        private Label lbTitulo;
        private Panel pnlFormLoader;
    }
}
 