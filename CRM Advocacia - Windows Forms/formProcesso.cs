using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRM_Advocacia___Windows_Forms.MetodosProcessos;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formProcesso : Form
    {
        public formProcesso()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            formAdicionarProcesso processo = new formAdicionarProcesso();

            processo.ShowDialog();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            string filtroTipo = cbxFiltro.SelectedItem?.ToString() ?? "Todos"; 
            string pesquisa = tbxPesquisa.Text.Trim(); 
            string fase = cbxFase.SelectedItem?.ToString() ?? "Todos"; 
            string status = cbxStatus.SelectedItem?.ToString() ?? "Todos";

            CarregarProcessos(pnlProcesso, filtroTipo, pesquisa, fase, status);

        }

        public void CarregarProcessos(Panel pnlProcessos, string filtroTipo = "Todos", string pesquisa = "", string fase = "Todos", string status = "Todos")
        {
            pnlProcessos.Controls.Clear();

            DataTable processos = MetodosProcesso.BuscarProcessos(filtroTipo, pesquisa, fase, status);

            int espacamento = 10;
            int cardWidth = 300;
            int cardHeight = 180;
            int maxWidth = pnlProcessos.Width - 20;
            int posY = 10;
            int posX = 10;
            int linhaAltura = 0;

            foreach (DataRow row in processos.Rows)
            {
                Panel card = CriarCardProcesso(row, cardWidth, cardHeight);

                if (posX + cardWidth > maxWidth)
                {
                    posX = 10;
                    posY += linhaAltura + espacamento;
                    linhaAltura = 0;
                }

                card.Location = new Point(posX, posY);
                pnlProcessos.Controls.Add(card);

                posX += cardWidth + espacamento;
                linhaAltura = Math.Max(linhaAltura, cardHeight);
            }
        }

        private Panel CriarCardProcesso(DataRow row, int width, int height)
        {
            Panel card = new Panel
            {
                Width = width,
                Height = height,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };

            // Número e Título do processo
            Label lblTitulo = new Label
            {
                Text = $"{row["numero"]} - {row["titulo"]}",
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Cliente
            Label lblCliente = new Label
            {
                Text = $"Cliente: {row["cliente"]}",
                Location = new Point(10, 40),
                AutoSize = true
            };

            // Advogado
            Label lblAdvogado = new Label
            {
                Text = $"Advogado: {row["advogado"]}",
                Location = new Point(10, 65),
                AutoSize = true
            };

            // Valor
            Label lblValor = new Label
            {
                Text = $"Valor: R$ {Convert.ToDecimal(row["valor"]):N2}",
                Location = new Point(10, 90),
                AutoSize = true
            };

            // Fase e Status
            Label lblFaseStatus = new Label
            {
                Text = $"Fase: {row["fase"]} | Status: {row["status_processo"]}",
                Location = new Point(10, 115),
                AutoSize = true
            };

            // Botão Detalhes
            Button btnDetalhes = new Button
            {
                Text = "Detalhes",
                Size = new Size(100, 30),
                Location = new Point(10, height - 40) // Melhor posição: canto inferior esquerdo
            };
            btnDetalhes.Click += (s, e) =>
            {
                int idProcesso = Convert.ToInt32(row["id_processo"]);
                DataRow processo = MetodosProcessos.BuscarProcessoPorId(idProcesso);
                if (processo != null)
                {
                    formDetalhesProcesso detalhesForm = new formDetalhesProcesso(processo);
                    detalhesForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Processo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Botão Editar
            Button btnEditar = new Button
            {
                Text = "Editar",
                Size = new Size(100, 30),
                Location = new Point(120, height - 40) // Ao lado do botão Detalhes
            };
            btnEditar.Click += (s, e) =>
            {
                int idProcesso = Convert.ToInt32(row["id_processo"]);
               /* AbrirEditarProcesso(idProcesso); // você cria esse método semelhante ao AbrirEditarCliente */
            };

            // Adiciona todos ao card
            card.Controls.Add(lblTitulo);
            card.Controls.Add(lblCliente);
            card.Controls.Add(lblAdvogado);
            card.Controls.Add(lblValor);
            card.Controls.Add(lblFaseStatus);
            card.Controls.Add(btnDetalhes);
            card.Controls.Add(btnEditar);

            return card;
        }

    }
}
