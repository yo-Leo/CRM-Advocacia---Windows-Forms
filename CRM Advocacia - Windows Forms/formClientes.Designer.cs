namespace CRM_Advocacia___Windows_Forms
{
    partial class formClientes
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
            panel1 = new Panel();
            txtbNomeCliente = new TextBox();
            btnRemove = new Button();
            btnCriar = new Button();
            cbTipoCliente = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbTipoCliente);
            panel1.Controls.Add(txtbNomeCliente);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnCriar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 51);
            panel1.TabIndex = 0;
            // 
            // txtbNomeCliente
            // 
            txtbNomeCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbNomeCliente.Location = new Point(3, 27);
            txtbNomeCliente.Name = "txtbNomeCliente";
            txtbNomeCliente.PlaceholderText = "Nome do cliente";
            txtbNomeCliente.Size = new Size(266, 21);
            txtbNomeCliente.TabIndex = 1;
            txtbNomeCliente.Tag = "";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DarkRed;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = SystemColors.Control;
            btnRemove.Location = new Point(902, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 23);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "REMOVER";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkGreen;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.Control;
            btnCriar.Location = new Point(995, 0);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(87, 23);
            btnCriar.TabIndex = 1;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // cbTipoCliente
            // 
            cbTipoCliente.FormattingEnabled = true;
            cbTipoCliente.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            cbTipoCliente.Location = new Point(311, 25);
            cbTipoCliente.Name = "cbTipoCliente";
            cbTipoCliente.Size = new Size(121, 23);
            cbTipoCliente.TabIndex = 3;
            // 
            // formClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 562);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F);
            Name = "formClientes";
            Text = "formClientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCriar;
        private Button btnRemove;
        private TextBox txtbNomeCliente;
        private ComboBox cbTipoCliente;
    }
}