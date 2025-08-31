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
    public partial class formPrazo : Form
    {
        public formPrazo()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            formAdicionarPrazo prazo = new formAdicionarPrazo();
            prazo.ShowDialog();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            string filtro = cbxFiltro.SelectedItem?.ToString() ?? "Todos";
            string data = dateDataPrazo.Value.ToString("yyyy-MM-dd");
            string status = cbxStatus.SelectedItem?.ToString() ?? "Todos";

            DataTable prazos = MetodoPrazo.BuscarPrazos(filtro, data, status);

            CarregarPrazos(prazos);

        }

        public void CarregarPrazos(DataTable prazos)
        {
            pnlPrazo.Controls.Clear();
            int y = 10;

            foreach (DataRow row in prazos.Rows)
            {
                int idPrazo = Convert.ToInt32(row["id_prazo"]);
                bool cumprido = Convert.ToBoolean(row["cumprido"]);

                Panel card = new Panel
                {
                    Width = pnlPrazo.Width - 25,
                    Height = 100,
                    BackColor = Color.LightYellow,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(10, y)
                };

                // Tipo
                Label lblTipo = new Label
                {
                    Text = $"Tipo: {row["tipo"]}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                // Data
                Label lblData = new Label
                {
                    Text = $"Data do Prazo: {Convert.ToDateTime(row["data_prazo"]).ToString("dd/MM/yyyy")}",
                    Font = new Font("Segoe UI", 10),
                    Location = new Point(10, 35),
                    AutoSize = true
                };

                // Observação
                Label lblObs = new Label
                {
                    Text = $"Observação: {row["observacao"]}",
                    Font = new Font("Segoe UI", 9, FontStyle.Italic),
                    Location = new Point(10, 60),
                    AutoSize = true
                };

                // Status
                Label lblStatus = new Label
                {
                    Text = cumprido ? "Cumprido ✅" : "Pendente ❌",
                    ForeColor = cumprido ? Color.Green : Color.Red,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(card.Width - 300, 35),
                    AutoSize = true
                };

                // Botão para marcar como cumprido
                Button btnCumprido = new Button
                {
                    Text = cumprido ? "Cumprido" : "Cumprir",
                    Width = 130,
                    Height = 30,
                    Location = new Point(card.Width - 300, 60),
                    Enabled = !cumprido
                };

                btnCumprido.Click += (s, e) =>
                {
                    if (MetodoPrazo.MarcarPrazoCumprido(idPrazo))
                    {
                        cumprido = true;
                        lblStatus.Text = "Cumprido ✅";
                        lblStatus.ForeColor = Color.Green;
                        btnCumprido.Text = "Cumprido";
                        btnCumprido.Enabled = false;
                    }
                };

                // Botão para excluir o prazo
                Button btnExcluir = new Button
                {
                    Text = "Excluir",
                    Width = 80,
                    Height = 30,
                    Location = new Point(card.Width - 150, 60)
                };

                btnExcluir.Click += (s, e) =>
                {
                    var confirm = MessageBox.Show("Deseja realmente excluir este prazo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        if (MetodoPrazo.ExcluirPrazo(idPrazo))
                        {
                            pnlPrazo.Controls.Remove(card);
                            card.Dispose();
                        }
                    }
                };

                card.Controls.Add(lblTipo);
                card.Controls.Add(lblData);
                card.Controls.Add(lblObs);
                card.Controls.Add(lblStatus);
                card.Controls.Add(btnCumprido);
                card.Controls.Add(btnExcluir);

                pnlPrazo.Controls.Add(card);

                y += card.Height + 10;
            }
        }
    }
}
