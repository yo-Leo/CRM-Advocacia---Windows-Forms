namespace CRM_Advocacia___Windows_Forms
{
    partial class formPrazo
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
            cbxStatus = new ComboBox();
            label1 = new Label();
            dateDataPrazo = new DateTimePicker();
            btnPesquisar = new Button();
            btnCriar = new Button();
            label4 = new Label();
            cbxFiltro = new ComboBox();
            label3 = new Label();
            pnlPrazo = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxStatus);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateDataPrazo);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(btnCriar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbxFiltro);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 85);
            panel1.TabIndex = 1;
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Todos", "Cumprido", "Pendente " });
            cbxStatus.Location = new Point(416, 51);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(192, 23);
            cbxStatus.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(416, 31);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 21;
            label1.Text = "Status do Prazo";
            // 
            // dateDataPrazo
            // 
            dateDataPrazo.Format = DateTimePickerFormat.Short;
            dateDataPrazo.Location = new Point(206, 51);
            dateDataPrazo.Name = "dateDataPrazo";
            dateDataPrazo.Size = new Size(200, 23);
            dateDataPrazo.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DeepSkyBlue;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = SystemColors.Control;
            btnPesquisar.Location = new Point(614, 48);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 31);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "🔍︎";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.DarkGreen;
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = SystemColors.Control;
            btnCriar.Location = new Point(1047, 0);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(100, 33);
            btnCriar.TabIndex = 2;
            btnCriar.Text = "CRIAR";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(206, 31);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 17;
            label4.Text = "Data";
            // 
            // cbxFiltro
            // 
            cbxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Todos", "Audiência", "Protocolo", "Prazo Recursal", "Outro" });
            cbxFiltro.Location = new Point(3, 51);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(192, 23);
            cbxFiltro.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(3, 31);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 15;
            label3.Text = "Tipo de Prazo";
            // 
            // pnlPrazo
            // 
            pnlPrazo.AutoScroll = true;
            pnlPrazo.Dock = DockStyle.Fill;
            pnlPrazo.Location = new Point(0, 85);
            pnlPrazo.Name = "pnlPrazo";
            pnlPrazo.Size = new Size(1147, 502);
            pnlPrazo.TabIndex = 2;
            // 
            // formPrazo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 587);
            Controls.Add(pnlPrazo);
            Controls.Add(panel1);
            Name = "formPrazo";
            Text = "formPrazo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPesquisar;
        private Button btnCriar;
        private Label label4;
        private ComboBox cbxFiltro;
        private Label label3;
        private DateTimePicker dateDataPrazo;
        private ComboBox cbxStatus;
        private Label label1;
        private Panel pnlPrazo;
    }
}