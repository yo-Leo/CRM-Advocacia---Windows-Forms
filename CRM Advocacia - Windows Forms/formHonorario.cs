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
    public partial class formHonorario : Form
    {

        public formHonorario()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            string pesquisa = tbxPesquisa.Text.Trim();
            string filtroStatus = cbxFiltro.SelectedItem?.ToString() ?? "Todos";

            DataTable honorarios = MetodoHonorario.BuscarHonorarios(pesquisa, filtroStatus);

            CarregarHonorarios(honorarios);

        }

        public void CarregarHonorarios(DataTable honorarios)
        {
            pnlHonorario.Controls.Clear();
            int y = 10;

            foreach (DataRow row in honorarios.Rows)
            {
                int idHonorario = Convert.ToInt32(row["id_honorario"]);
                bool pago = Convert.ToBoolean(row["pago"]);

                Panel card = new Panel
                {
                    Width = pnlHonorario.Width - 25,
                    Height = 100,
                    BackColor = Color.AliceBlue,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(10, y)
                };

                Label lblDesc = new Label
                {
                    Text = $"Descrição: {row["descricao"]}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblValor = new Label
                {
                    Text = $"Valor: R$ {Convert.ToDecimal(row["valor"]):N2}",
                    Font = new Font("Segoe UI", 10),
                    Location = new Point(10, 35),
                    AutoSize = true
                };

                Label lblData = new Label
                {
                    Text = $"Data: {Convert.ToDateTime(row["data_emissao"]):dd/MM/yyyy}",
                    Font = new Font("Segoe UI", 9, FontStyle.Italic),
                    Location = new Point(10, 60),
                    AutoSize = true
                };

                Label lblPago = new Label
                {
                    Text = pago ? "Pago ✅" : "Pendente ❌",
                    ForeColor = pago ? Color.Green : Color.Red,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(card.Width - 150, 35),
                    AutoSize = true
                };

                Button btnPagar = new Button
                {

                    Text = pago ? "Pago" : "Pagar",
                    Width = 80,
                    Height = 30,
                    Location = new Point(card.Width - 100, 60),
                    Enabled = !pago

                };

                btnPagar.Click += (s, e) =>
                {
                    if (MetodoHonorario.AtualizarHonorarioParaPago(idHonorario))
                    {

                        pago = true;
                        lblPago.Text = pago ? "Pago ✅" : "Pendente ❌";
                        lblPago.ForeColor = pago ? Color.Green : Color.Red;


                        btnPagar.Enabled = !pago;

                    }
                };

                card.Controls.Add(lblDesc);
                card.Controls.Add(lblValor);
                card.Controls.Add(lblData);
                card.Controls.Add(lblPago);
                card.Controls.Add(btnPagar);

                pnlHonorario.Controls.Add(card);

                y += card.Height + 10;

            }
        }
    }
}
