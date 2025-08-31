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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string filtroTipo = cbxFiltro.SelectedItem?.ToString() ?? "Todos";
            string atividade = cbxAtividade.SelectedItem?.ToString() ?? "Todos";
            string pesquisa = tbxPesquisa.Text.Trim();

            CarregarEquipe(pnlEquipe, filtroTipo, pesquisa, atividade);
        }

        public void CarregarEquipe(Panel pnlEquipe, string filtroTipo = "Todos", string pesquisa = "", string atividade = "Todos")
        {
            pnlEquipe.Controls.Clear(); // Limpa os cards existentes

            DataTable colaboradores = MetodoEquipe.BuscarEquipe(filtroTipo, pesquisa, atividade);

            int espacamento = 10; // espaçamento entre cards
            int cardWidth = 280;
            int cardHeight = 150;
            int maxWidth = pnlEquipe.Width - 20; // margem do painel
            int posY = 10;

            // Função auxiliar para adicionar uma seção
            void AdicionarSecao(string titulo, DataRow[] rows)
            {
                if (rows.Length == 0) return;

                // Label da seção
                Label lblSecao = new Label
                {
                    Text = titulo,
                    Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold),
                    Location = new Point(10, posY),
                    AutoSize = true
                };
                pnlEquipe.Controls.Add(lblSecao);
                posY += lblSecao.Height + espacamento;

                int posX = 10;
                int linhaAltura = 0;

                foreach (DataRow row in rows)
                {
                    Panel card = CriarCardColaborador(row, cardWidth, cardHeight);

                    // Se o próximo card ultrapassar a largura do painel, desce para próxima linha
                    if (posX + cardWidth > maxWidth)
                    {
                        posX = 10;
                        posY += linhaAltura + espacamento;
                        linhaAltura = 0;
                    }

                    card.Location = new Point(posX, posY);
                    pnlEquipe.Controls.Add(card);

                    posX += cardWidth + espacamento;
                    linhaAltura = Math.Max(linhaAltura, cardHeight);
                }

                posY += linhaAltura + espacamento; // Espaçamento após a seção
            }

            // Seção Advogados
            AdicionarSecao("Advogados", colaboradores.Select("tipo = 'Advogado'"));

            // Seção Equipe administrativa
            AdicionarSecao("Equipe", colaboradores.Select("tipo = 'Equipe'"));
        }

        private Panel CriarCardColaborador(DataRow row, int width, int height)
        {
            Panel card = new Panel
            {
                Width = width,
                Height = height,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };

            // Nome
            Label lblNome = new Label
            {
                Text = row["nome"].ToString(),
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Contato
            Label lblContato = new Label
            {
                Text = $"📞 {row["telefone"]} | ✉ {row["email"]}",
                Location = new Point(10, 35),
                AutoSize = true
            };

            // Status
            bool ativo = Convert.ToBoolean(row["ativo"]);
            Label lblStatus = new Label
            {
                Text = ativo ? "Ativo ✅" : "Inativo ❌",
                ForeColor = ativo ? Color.Green : Color.Red,
                Location = new Point(10, 60),
                AutoSize = true
            };

            // Especialidade ou Cargo
            Label lblExtra = new Label
            {
                Text = row["tipo"].ToString() == "Advogado"
                        ? $"Especialidade: {row["especialidade"]}"
                        : row["tipo"].ToString() == "Equipe"
                            ? $"Cargo: {row["cargo"]}"
                            : "",
                Location = new Point(10, 85),
                AutoSize = true
            };

            // Botões
            Button btnDetalhes = new Button
            {
                Text = "Detalhes",
                Size = new Size(80, 30),
                Location = new Point(10, 110)
            };
            btnDetalhes.Click += (s, e) =>
            {
                int idColaborador = Convert.ToInt32(row["id_colaborador"]);
                DataRow colaborador = MetodoEquipe.BuscarColaboradorPorId(idColaborador);
                if (colaborador != null)
                {
                    formDetalhesEquipe detalhesForm = new formDetalhesEquipe(colaborador);
                    detalhesForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Colaborador não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                Size = new Size(80, 30),
                Location = new Point(100, 110)
            };
            btnEditar.Click += (s, e) =>
            {
                int idColaborador = Convert.ToInt32(row["id_colaborador"]);
                /*AbrirEditarColaborador(idColaborador); */
            };

            card.Controls.Add(lblNome);
            card.Controls.Add(lblContato);
            card.Controls.Add(lblStatus);
            card.Controls.Add(lblExtra);
            card.Controls.Add(btnDetalhes);
            card.Controls.Add(btnEditar);

            return card;
        }

    }
}
