using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formClientes : Form
    {
        
        MetodoCoringa coringa = new MetodoCoringa();

        public formClientes()
        {

            InitializeComponent();

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            formAdicionarCliente formAdicionarCliente = new formAdicionarCliente();

            formAdicionarCliente.Show();

        }

        private void formClientes_Load(object sender, EventArgs e)
        {



        }

        private void CarregarCliente(object sender, EventArgs e) 
        { 
        
            flpClientes.Controls.Clear();
            


        }

    }
}
