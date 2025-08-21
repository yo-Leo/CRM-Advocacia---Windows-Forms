namespace CRM_Advocacia___Windows_Forms
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            picLogo = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            picProfile = new PictureBox();
            labelUserName = new Label();
            btnPaginaInici = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnPaginaInici);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 661);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelUserName);
            panel2.Controls.Add(picProfile);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 150);
            panel2.TabIndex = 2;
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
            // btnPaginaInici
            // 
            btnPaginaInici.Dock = DockStyle.Top;
            btnPaginaInici.FlatAppearance.BorderSize = 0;
            btnPaginaInici.FlatStyle = FlatStyle.Flat;
            btnPaginaInici.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaginaInici.ForeColor = Color.White;
            btnPaginaInici.Location = new Point(0, 150);
            btnPaginaInici.Name = "btnPaginaInici";
            btnPaginaInici.Size = new Size(186, 42);
            btnPaginaInici.TabIndex = 2;
            btnPaginaInici.Text = "Pagina Principal";
            btnPaginaInici.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(panel1);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRM - LegalMind";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picLogo;
        private Panel panel1;
        private Panel panel2;
        private PictureBox picProfile;
        private Label labelUserName;
        private Button btnPaginaInici;
    }
}
 