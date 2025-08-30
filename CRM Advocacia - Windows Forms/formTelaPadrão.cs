using System.Runtime.InteropServices;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formTelaPadrão : Form
    {

        public formTelaPadrão()
        {

            InitializeComponent();

            pnlNav.Height = btnPaginaInici.Height;
            pnlNav.Top = btnPaginaInici.Top;
            pnlNav.Left = btnPaginaInici.Left;
            btnPaginaInici.BackColor = Color.DimGray;

            lbTitulo.Text = "Pagina Inicial";

            this.pnlFormLoader.Controls.Clear();
            formPaginaInicial frmPaginaInicial = new formPaginaInicial() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPaginaInicial.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmPaginaInicial);
            frmPaginaInicial.Show();

        }

        private void btnPaginaInici_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnPaginaInici.Height;
            pnlNav.Top = btnPaginaInici.Top;
            pnlNav.Left = btnPaginaInici.Left;
            btnPaginaInici.BackColor = Color.Gray;

            lbTitulo.Text = "Pagina Inicial";

            this.pnlFormLoader.Controls.Clear();
            formPaginaInicial frmPaginaInicial = new formPaginaInicial() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPaginaInicial.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmPaginaInicial);
            frmPaginaInicial.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnClientes.Height;
            pnlNav.Top = btnClientes.Top;
            pnlNav.Left = btnClientes.Left;
            btnClientes.BackColor = Color.Gray;

            lbTitulo.Text = "Clientes";

            this.pnlFormLoader.Controls.Clear();
            formClientes frmClientes = new formClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmClientes.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmClientes);
            frmClientes.Show();

        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnEquipe.Height;
            pnlNav.Top = btnEquipe.Top;
            pnlNav.Left = btnEquipe.Left;
            btnEquipe.BackColor = Color.Gray;

            lbTitulo.Text = "Equipe";

            this.pnlFormLoader.Controls.Clear();
            formEquipe frmEquipe = new formEquipe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEquipe.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmEquipe);
            frmEquipe.Show();


        }

        private void btnProcessos_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnProcessos.Height;
            pnlNav.Top = btnProcessos.Top;
            pnlNav.Left = btnProcessos.Left;
            btnProcessos.BackColor = Color.Gray;

            lbTitulo.Text = "Processos";

            this.pnlFormLoader.Controls.Clear();
            formProcesso frmProcesso = new formProcesso() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProcesso.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmProcesso);
            frmProcesso.Show();

        }

        private void btnPrazo_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnPrazo.Height;
            pnlNav.Top = btnPrazo.Top;
            pnlNav.Left = btnPrazo.Left;
            btnPrazo.BackColor = Color.Gray;

            lbTitulo.Text = "Prazos";

            this.pnlFormLoader.Controls.Clear();
            formPrazo frmPrazos = new formPrazo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPrazos.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmPrazos);
            frmPrazos.Show();

        }

        private void btnHonorarios_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnHonorarios.Height;
            pnlNav.Top = btnHonorarios.Top;
            pnlNav.Left = btnHonorarios.Left;
            btnHonorarios.BackColor = Color.Gray;

            lbTitulo.Text = "Honorários";

            this.pnlFormLoader.Controls.Clear();
            formHonorario frmHornorario = new formHonorario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHornorario.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmHornorario);
            frmHornorario.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnSair.Height;
            pnlNav.Top = btnSair.Top;
            pnlNav.Left = btnSair.Left;
            btnSair.BackColor = Color.Gray;

        }

        private void btnPaginaInici_Leave(object sender, EventArgs e)
        {

            btnPaginaInici.BackColor = Color.DimGray;

        }

        private void btnClientes_Leave(object sender, EventArgs e)
        {

            btnClientes.BackColor = Color.DimGray;

        }

        private void btnEquipe_Leave(object sender, EventArgs e)
        {

            btnEquipe.BackColor = Color.DimGray;

        }

        private void btnProcessos_Leave(object sender, EventArgs e)
        {

            btnProcessos.BackColor = Color.DimGray;

        }

        private void btnPrazo_Leave(object sender, EventArgs e)
        {

            btnPrazo.BackColor = Color.DimGray;

        }

        private void btnHonorarios_Leave(object sender, EventArgs e)
        {

            btnHonorarios.BackColor = Color.DimGray;

        }

        private void btnSair_Leave(object sender, EventArgs e)
        {

            btnSair.BackColor = Color.DimGray;

        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.picProfile.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
