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
    public partial class formEquipe : Form
    {
        public formEquipe()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            using (var escolhaForm = new formEscolhaCadastro())
            {
                if (escolhaForm.ShowDialog() == DialogResult.OK)
                {
                    if (escolhaForm.OpcaoEscolhida == "Advogado")
                    {
                        formAdicionarAdvogado formAdv = new formAdicionarAdvogado();
                        formAdv.ShowDialog();
                    }
                    else if (escolhaForm.OpcaoEscolhida == "Equipe")
                    {
                        formAdicionarEquipe formEquipe = new formAdicionarEquipe();
                        formEquipe.ShowDialog();
                    }
                }
            }

        }
    }
}
