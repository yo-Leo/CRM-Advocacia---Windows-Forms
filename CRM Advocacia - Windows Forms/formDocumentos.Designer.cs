namespace CRM_Advocacia___Windows_Forms
{
    partial class formDocumentos
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
            openFileDialog1 = new OpenFileDialog();
            btnAdd = new Button();
            btnSelecionar = new Button();
            dgvDocumentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(675, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 33);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADICIONAR";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.DodgerBlue;
            btnSelecionar.FlatAppearance.BorderSize = 0;
            btnSelecionar.FlatStyle = FlatStyle.Flat;
            btnSelecionar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecionar.ForeColor = SystemColors.Control;
            btnSelecionar.Location = new Point(675, 51);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(113, 33);
            btnSelecionar.TabIndex = 4;
            btnSelecionar.Text = "SELECIONAR";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // dgvDocumentos
            // 
            dgvDocumentos.BackgroundColor = Color.White;
            dgvDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentos.Location = new Point(12, 12);
            dgvDocumentos.Name = "dgvDocumentos";
            dgvDocumentos.Size = new Size(657, 426);
            dgvDocumentos.TabIndex = 5;
            // 
            // formDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDocumentos);
            Controls.Add(btnSelecionar);
            Controls.Add(btnAdd);
            Name = "formDocumentos";
            Text = "formDocumentos";
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnAdd;
        private Button btnSelecionar;
        private DataGridView dgvDocumentos;
    }
}