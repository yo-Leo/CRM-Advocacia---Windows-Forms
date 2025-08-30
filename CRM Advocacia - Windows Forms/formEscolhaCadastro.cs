using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formEscolhaCadastro : Form
    {

        public string OpcaoEscolhida { get; set; }

        public formEscolhaCadastro()
        {
            InitializeComponent();

            Button btnAdv = new Button
            {
                Text = "Advogado",
                Width = 120,
                Height = 40,
                Left = 20,
                Top = 20
            };
            btnAdv.Click += (s, e) =>
            {
                OpcaoEscolhida = "Advogado";
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            Button btnEquipe = new Button
            {
                Text = "Membro da Equipe",
                Width = 150,
                Height = 40,
                Left = 160,
                Top = 20
            };
            btnEquipe.Click += (s, e) =>
            {
                OpcaoEscolhida = "Equipe";
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            this.Text = "Escolha o tipo de cadastro";
            this.Controls.Add(btnAdv);
            this.Controls.Add(btnEquipe);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(340, 90);

        }
    }
}
