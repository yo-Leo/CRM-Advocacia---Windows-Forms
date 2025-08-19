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
            picLogo.Location = new Point(1737, 800);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(167, 180);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tbTelaPrincipal
            // 
            tbTelaPrincipal.BackColor = SystemColors.Control;
            tbTelaPrincipal.BorderStyle = BorderStyle.None;
            tbTelaPrincipal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTelaPrincipal.Location = new Point(13, 25);
            tbTelaPrincipal.Margin = new Padding(4, 5, 4, 5);
            tbTelaPrincipal.Name = "tbTelaPrincipal";
            tbTelaPrincipal.Size = new Size(177, 38);
            tbTelaPrincipal.TabIndex = 1;
            tbTelaPrincipal.Text = "LEGALMIND";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1918, 964);
            Controls.Add(tbTelaPrincipal);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
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
 