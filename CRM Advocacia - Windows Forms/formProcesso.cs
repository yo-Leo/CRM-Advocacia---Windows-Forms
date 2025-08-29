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
    public partial class formProcesso : Form
    {
        public formProcesso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string selectdoc;
                selectdoc = dlg.FileName;

                MessageBox.Show(selectdoc);
            }
        }
    }
}
