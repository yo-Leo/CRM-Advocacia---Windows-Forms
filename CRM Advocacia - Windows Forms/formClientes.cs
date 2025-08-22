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
    public partial class formClientes : Form
    {
        public formClientes()
        {

            InitializeComponent();

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            formAdicionarCliente formAdicionarCliente = new formAdicionarCliente();

            formAdicionarCliente.ShowDialog();

        }
    }
}
