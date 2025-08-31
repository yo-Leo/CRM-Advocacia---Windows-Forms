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
    public partial class formPaginaInicial : Form
    {
        public formPaginaInicial()
        {
            InitializeComponent();
            ConfigurarLayout();
            CarregarDadosDashboard();
        }

        private void ConfigurarLayout()
        {
            this.BackColor = Color.White;

            Panel mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Size = new Size(1163, 626),
                BackColor = Color.White
            };
            this.Controls.Add(mainPanel);

            // === Prazos do Dia ===
            Label lblPrazos = new Label
            {
                Text = "Prazos do Dia",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50),
                Location = new Point(10, 10),
                AutoSize = true
            };
            mainPanel.Controls.Add(lblPrazos);

            FlowLayoutPanel pnlPrazos = new FlowLayoutPanel
            {
                Name = "pnlPrazos",
                Location = new Point(10, 40),
                Size = new Size(1140, 180),
                FlowDirection = FlowDirection.LeftToRight,
                AutoScroll = true,
                WrapContents = false,
                Padding = new Padding(5),
                BackColor = Color.Transparent
            };
            mainPanel.Controls.Add(pnlPrazos);

            // === Último Processo ===
            Panel cardUltimoProcesso = CriarCard(Color.FromArgb(240, 250, 255), 1140, 180);
            cardUltimoProcesso.Name = "cardUltimoProcesso";
            cardUltimoProcesso.Location = new Point(10, 230);
            mainPanel.Controls.Add(cardUltimoProcesso);

            // === Últimos 5 Clientes ===
            Label lblClientes = new Label
            {
                Text = "Últimos 5 Clientes Cadastrados",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50),
                Location = new Point(10, 420),
                AutoSize = true
            };
            mainPanel.Controls.Add(lblClientes);

            FlowLayoutPanel pnlClientes = new FlowLayoutPanel
            {
                Name = "pnlClientes",
                Location = new Point(10, 450),
                Size = new Size(1140, 160),
                FlowDirection = FlowDirection.LeftToRight,
                AutoScroll = true,
                WrapContents = false,
                Padding = new Padding(5),
                BackColor = Color.Transparent
            };
            mainPanel.Controls.Add(pnlClientes);
        }

        private Panel CriarCard(Color bgColor, int largura, int altura)
        {
            Panel card = new Panel
            {
                Width = largura,
                Height = altura,
                BackColor = bgColor,
                Margin = new Padding(5),
                Padding = new Padding(10),
                BorderStyle = BorderStyle.None
            };
            card.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 15, 15));
            return card;
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void CarregarDadosDashboard()
        {
            CarregarPrazos();
            CarregarUltimoProcesso();
            CarregarUltimosClientes();
        }

        private void CarregarPrazos()
        {
            var pnlPrazos = this.Controls.Find("pnlPrazos", true).FirstOrDefault() as FlowLayoutPanel;
            if (pnlPrazos == null) return;
            pnlPrazos.Controls.Clear();

            DataTable dtPrazos = PrazosDoDia();
            if (dtPrazos == null || dtPrazos.Rows.Count == 0)
            {
                Label lblVazio = new Label
                {
                    Text = "Nenhum prazo para hoje.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                pnlPrazos.Controls.Add(lblVazio);
                return;
            }

            foreach (DataRow row in dtPrazos.Rows)
            {
                Color corCard = row["tipo"].ToString() switch
                {
                    "Audiência" => Color.FromArgb(255, 200, 200),
                    "Protocolo" => Color.FromArgb(200, 230, 255),
                    "Prazo Recursal" => Color.FromArgb(200, 255, 200),
                    _ => Color.FromArgb(240, 240, 240)
                };

                Panel card = CriarCard(corCard, 200, 100);

                Label lblTipo = new Label { Text = row["tipo"].ToString(), Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Top };
                Label lblProcesso = new Label { Text = $"Processo: {row["processo_numero"]}", Font = new Font("Segoe UI", 9), Dock = DockStyle.Top };
                Label lblData = new Label { Text = $"Data: {Convert.ToDateTime(row["data_prazo"]).ToShortDateString()}", Font = new Font("Segoe UI", 9), Dock = DockStyle.Top };
                Label lblStatus = new Label { Text = $"Cumprido: {((bool)row["cumprido"] ? "Sim" : "Não")}", Font = new Font("Segoe UI", 9), Dock = DockStyle.Top };

                card.Controls.Add(lblStatus);
                card.Controls.Add(lblData);
                card.Controls.Add(lblProcesso);
                card.Controls.Add(lblTipo);

                pnlPrazos.Controls.Add(card);
            }
        }

        private void CarregarUltimoProcesso()
        {
            var cardProcesso = this.Controls.Find("cardUltimoProcesso", true).FirstOrDefault() as Panel;
            if (cardProcesso == null) return;
            cardProcesso.Controls.Clear();

            DataTable dtProcessos = MetodoProcesso.BuscarProcessos("Todos", "", "Todos", "Todos");
            if (dtProcessos.Rows.Count == 0)
            {
                Label lblVazio = new Label
                {
                    Text = "Nenhum processo cadastrado.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                cardProcesso.Controls.Add(lblVazio);
                return;
            }

            DataRow last = dtProcessos.Rows[dtProcessos.Rows.Count - 1];

            // Título
            Label lblTitulo = new Label
            {
                Text = last["titulo"].ToString(),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 30),
                Dock = DockStyle.Top,
                Height = 30
            };
            cardProcesso.Controls.Add(lblTitulo);

            // Número, Cliente e Advogado
            Label lblNumero = new Label { Text = $"Número: {last["numero"]}", Font = new Font("Segoe UI", 10), Dock = DockStyle.Top, Height = 25 };
            Label lblCliente = new Label { Text = $"Cliente: {last["cliente"]}", Font = new Font("Segoe UI", 10), Dock = DockStyle.Top, Height = 25 };
            Label lblAdvogado = new Label { Text = $"Advogado: {last["advogado"]}", Font = new Font("Segoe UI", 10), Dock = DockStyle.Top, Height = 25 };
            Label lblFase = new Label { Text = $"Fase: {last["fase"]}", Font = new Font("Segoe UI", 10), Dock = DockStyle.Top, Height = 25 };

            // Status com cor de destaque
            string status = last["status_processo"].ToString();
            Color corStatus = status switch
            {
                "Ativo" => Color.Green,
                "Suspenso" => Color.Orange,
                "Encerrado" => Color.Red,
                _ => Color.Gray
            };
            Label lblStatus = new Label
            {
                Text = $"Status: {status}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = corStatus,
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };

            cardProcesso.Controls.Add(lblStatus);
            cardProcesso.Controls.Add(lblFase);
            cardProcesso.Controls.Add(lblAdvogado);
            cardProcesso.Controls.Add(lblCliente);
            cardProcesso.Controls.Add(lblNumero);
        }

        private void CarregarUltimosClientes()
        {
            var pnlClientes = this.Controls.Find("pnlClientes", true).FirstOrDefault() as FlowLayoutPanel;
            if (pnlClientes == null) return;
            pnlClientes.Controls.Clear();

            DataTable dtClientes = Ultimos5Clientes();
            if (dtClientes == null || dtClientes.Rows.Count == 0)
            {
                Label lblVazio = new Label
                {
                    Text = "Nenhum cliente cadastrado.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                pnlClientes.Controls.Add(lblVazio);
                return;
            }

            foreach (DataRow row in dtClientes.Rows)
            {
                Panel card = CriarCard(Color.FromArgb(230, 250, 230), 200, 120);

                Label lblNome = new Label { Text = row["nome_razao"].ToString(), Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Top };
                Label lblTipo = new Label { Text = row["tipo"].ToString(), Font = new Font("Segoe UI", 9), Dock = DockStyle.Top };
                Label lblContato = new Label { Text = row["telefone"].ToString(), Font = new Font("Segoe UI", 9), Dock = DockStyle.Top };

                card.Controls.Add(lblContato);
                card.Controls.Add(lblTipo);
                card.Controls.Add(lblNome);

                pnlClientes.Controls.Add(card);
            }
        }

        private DataTable Ultimos5Clientes()
        {
            DataTable dt = MetodoCliente.BuscarClientes("", "", "");
            if (dt == null || dt.Rows.Count == 0)
                return new DataTable(); // retorna DataTable vazio para evitar erro em CopyToDataTable
            return dt.AsEnumerable()
                     .OrderByDescending(r => r.Field<DateTime>("contato_em"))
                     .Take(5)
                     .CopyToDataTable();
        }

        private DataTable PrazosDoDia()
        {
            DataTable dt = MetodoPrazo.BuscarPrazos("", DateTime.Now.ToString("yyyy-MM-dd"), "Todos");
            if (dt == null || dt.Rows.Count == 0)
                return new DataTable();
            return dt;
        }
    }

}
