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
            picLogo = new PictureBox();
            tbTelaPrincipal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackgroundImage = Properties.Resources._48ebd45a_28a5_4555_9ba7_10710817959d;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.InitialImage = null;
            picLogo.Location = new Point(775, 426);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(117, 108);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tbTelaPrincipal
            // 
            tbTelaPrincipal.BackColor = SystemColors.Control;
            tbTelaPrincipal.BorderStyle = BorderStyle.None;
            tbTelaPrincipal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTelaPrincipal.Location = new Point(37, 135);
            tbTelaPrincipal.Name = "tbTelaPrincipal";
            tbTelaPrincipal.Size = new Size(113, 26);
            tbTelaPrincipal.TabIndex = 1;
            tbTelaPrincipal.Text = "LEGALMIND";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 517);
            Controls.Add(tbTelaPrincipal);
            Controls.Add(picLogo);
            Name = "TelaPrincipal";
            Text = "CRM - LegalMind";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private TextBox tbTelaPrincipal;
    }
}
