namespace CRM_Advocacia___Windows_Forms
{
    partial class formEditarProcesso
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
            btnAtualizar = new Button();
            lbTituloAC = new Label();
            label4 = new Label();
            cbxFaseAtual = new ComboBox();
            label7 = new Label();
            cbxStatusAtual = new ComboBox();
            SuspendLayout();
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DarkGreen;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = SystemColors.Control;
            btnAtualizar.Location = new Point(99, 176);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(100, 33);
            btnAtualizar.TabIndex = 56;
            btnAtualizar.Text = "ATUALIZAR";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lbTituloAC
            // 
            lbTituloAC.AutoSize = true;
            lbTituloAC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloAC.Location = new Point(48, 9);
            lbTituloAC.Name = "lbTituloAC";
            lbTituloAC.Size = new Size(183, 24);
            lbTituloAC.TabIndex = 39;
            lbTituloAC.Text = "Atualizar Processo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 68);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 54;
            label4.Text = "Fase Atual";
            // 
            // cbxFaseAtual
            // 
            cbxFaseAtual.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFaseAtual.Font = new Font("Microsoft Sans Serif", 9F);
            cbxFaseAtual.FormattingEnabled = true;
            cbxFaseAtual.Items.AddRange(new object[] { "Conhecimento", "Execução", "Recursal", "Arquivado" });
            cbxFaseAtual.Location = new Point(48, 84);
            cbxFaseAtual.Name = "cbxFaseAtual";
            cbxFaseAtual.Size = new Size(215, 23);
            cbxFaseAtual.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 110);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 60;
            label7.Text = "Status do Processo";
            // 
            // cbxStatusAtual
            // 
            cbxStatusAtual.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatusAtual.Font = new Font("Microsoft Sans Serif", 9F);
            cbxStatusAtual.FormattingEnabled = true;
            cbxStatusAtual.Items.AddRange(new object[] { "Ativo", "Suspenso", "Encerrado" });
            cbxStatusAtual.Location = new Point(48, 128);
            cbxStatusAtual.Name = "cbxStatusAtual";
            cbxStatusAtual.Size = new Size(215, 23);
            cbxStatusAtual.TabIndex = 64;
            // 
            // formEditarProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 255);
            Controls.Add(cbxStatusAtual);
            Controls.Add(cbxFaseAtual);
            Controls.Add(label7);
            Controls.Add(btnAtualizar);
            Controls.Add(label4);
            Controls.Add(lbTituloAC);
            Name = "formEditarProcesso";
            Text = "formEditarProcesso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAtualizar;
        private Label lbTituloAC;
        private Label label4;
        private ComboBox cbxFaseAtual;
        private Label label7;
        private ComboBox cbxStatusAtual;
    }
}