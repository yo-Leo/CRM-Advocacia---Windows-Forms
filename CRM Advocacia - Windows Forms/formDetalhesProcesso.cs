using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class formDetalhesProcesso : Form
    {
        private Label lblTitulo;
        private Label lblCliente;
        private Label lblClienteContato;
        private Label lblAdvogado;
        private Label lblAdvogadoEspecialidade;
        private Label lblArea;
        private Label lblValor;
        private Label lblFase;
        private Label lblStatus;
        private Label lblDataInicio;
        private TextBox txtDescricao;
        private Button btnAbrirDocs; // novo botão

        private DataRow processo;

        public formDetalhesProcesso(DataRow processo)
        {
            this.processo = processo;
            InitializeComponent();
            CriarControles();   // cria os labels e textbox
            CarregarDetalhes(); // só depois preenche os dados
        }

        private void CriarControles()
        {
            this.Text = "Detalhes do Processo";
            this.Size = new Size(700, 650); // aumentei para caber o botão
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;

            lblTitulo = new Label { Location = new Point(20, 20), AutoSize = true };
            lblCliente = new Label { Location = new Point(20, 60), AutoSize = true };
            lblClienteContato = new Label { Location = new Point(20, 85), AutoSize = true };
            lblAdvogado = new Label { Location = new Point(20, 120), AutoSize = true };
            lblAdvogadoEspecialidade = new Label { Location = new Point(20, 145), AutoSize = true };
            lblArea = new Label { Location = new Point(20, 190), AutoSize = true };
            lblValor = new Label { Location = new Point(20, 215), AutoSize = true };
            lblFase = new Label { Location = new Point(20, 240), AutoSize = true };
            lblStatus = new Label { Location = new Point(20, 265), AutoSize = true };
            lblDataInicio = new Label { Location = new Point(20, 290), AutoSize = true };

            txtDescricao = new TextBox
            {
                Location = new Point(20, 330),
                Size = new Size(640, 200),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };

            // Botão Documentos
            btnAbrirDocs = new Button
            {
                Text = "Documentos",
                Size = new Size(120, 35),
                Location = new Point(20, 545)
            };
            btnAbrirDocs.Click += BtnAbrirDocs_Click;

            // Adiciona controles ao Form
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblCliente);
            this.Controls.Add(lblClienteContato);
            this.Controls.Add(lblAdvogado);
            this.Controls.Add(lblAdvogadoEspecialidade);
            this.Controls.Add(lblArea);
            this.Controls.Add(lblValor);
            this.Controls.Add(lblFase);
            this.Controls.Add(lblStatus);
            this.Controls.Add(lblDataInicio);
            this.Controls.Add(txtDescricao);
            this.Controls.Add(btnAbrirDocs);
        }

        private void BtnAbrirDocs_Click(object sender, EventArgs e)
        {

            formDocumentos documentos = new formDocumentos(processo);
            documentos.ShowDialog();

        }

        private void CarregarDetalhes()
        {
            if (processo == null) return;

            lblTitulo.Text = $"{processo["numero"]} - {processo["titulo"]}";
            lblTitulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            lblCliente.Text = $"👤 Cliente: {processo["cliente_nome"]} ({processo["cliente_documento"]})";
            lblCliente.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            lblClienteContato.Text = $"📞 {processo["cliente_telefone"]} | ✉ {processo["cliente_email"]}";
            lblClienteContato.ForeColor = Color.DimGray;

            lblAdvogado.Text = $"⚖ Advogado: {processo["advogado_nome"]} - OAB {processo["advogado_oab"]}";
            lblAdvogado.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            lblAdvogadoEspecialidade.Text = $"Especialidade: {processo["advogado_especialidade"]}";

            lblArea.Text = $"Área: {processo["area_direito"]}";
            lblValor.Text = $"Valor da Causa: R$ {Convert.ToDecimal(processo["valor"]):N2}";
            lblFase.Text = $"Fase: {processo["fase"]}";
            lblStatus.Text = $"Status: {processo["status_processo"]}";
            lblDataInicio.Text = $"Data de Início: {Convert.ToDateTime(processo["data_inicio"]).ToString("dd/MM/yyyy")}";

            txtDescricao.Text = processo["descricao"].ToString();
        }
    }
}
