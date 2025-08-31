using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formDetalhesEquipe : Form
    {


        private Label lblTitulo;
        private Label lblNome;
        private Label lblTipo;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblStatus;
        private Label lblExtra;
        public PictureBox pictureBoxFoto;
        private Button btnFechar;

        public formDetalhesEquipe(DataRow colaborador)
        {
            InitializeComponent();
            CriarControles();
            CarregarDados(colaborador);
        }

        private void CriarControles()
        {
            this.Text = "Detalhes do Colaborador";
            this.Size = new Size(500, 400);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            // Título
            lblTitulo = new Label
            {
                Text = "Detalhes do Colaborador",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(20, 10),
                AutoSize = true
            };
            this.Controls.Add(lblTitulo);

            // PictureBox da foto
            pictureBoxFoto = new PictureBox
            {
                Location = new Point(350, 50),
                Size = new Size(120, 120),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(pictureBoxFoto);

            // Nome
            lblNome = CriarLabel("Nome:", 20, 50);
            this.Controls.Add(lblNome);

            // Tipo
            lblTipo = CriarLabel("Tipo:", 20, 80);
            this.Controls.Add(lblTipo);

            // Telefone
            lblTelefone = CriarLabel("Telefone:", 20, 110);
            this.Controls.Add(lblTelefone);

            // Email
            lblEmail = CriarLabel("Email:", 20, 140);
            this.Controls.Add(lblEmail);

            // Status
            lblStatus = CriarLabel("Status:", 20, 170);
            this.Controls.Add(lblStatus);

            // Especialidade / Cargo
            lblExtra = CriarLabel("Extra:", 20, 200);
            this.Controls.Add(lblExtra);

            // Botão Fechar
            btnFechar = new Button
            {
                Text = "Fechar",
                Size = new Size(80, 30),
                Location = new Point(380, 320)
            };
            btnFechar.Click += (s, e) => this.Close();
            this.Controls.Add(btnFechar);
        }

        private Label CriarLabel(string texto, int x, int y)
        {
            return new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(x, y),
                AutoSize = true,
                ForeColor = Color.Black
            };
        }

        private void CarregarDados(DataRow row)
        {
            lblNome.Text = "Nome: " + row["nome"].ToString();
            lblTipo.Text = "Tipo: " + row["tipo"].ToString();
            lblTelefone.Text = "Telefone: " + row["telefone"].ToString();
            lblEmail.Text = "Email: " + row["email"].ToString();
            lblStatus.Text = "Status: " + (Convert.ToBoolean(row["ativo"]) ? "Ativo ✅" : "Inativo ❌");

            if (row["tipo"].ToString() == "Advogado")
            {
                lblExtra.Text = $"OAB: {row["oab"]}\nEspecialidade: {row["especialidade"]}";
            }
            else if (row["tipo"].ToString() == "Equipe")
            {
                lblExtra.Text = $"Cargo: {row["cargo"]}";
            }

            try
            {
                if (row["foto"] != DBNull.Value)
                {
                    byte[] bytesFoto = (byte[])row["foto"];
                    using (MemoryStream ms = new MemoryStream(bytesFoto))
                    {
                        pictureBoxFoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxFoto.Image = null; // Limpa se não tiver foto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
                pictureBoxFoto.Image = null;
            }
        }
    }
}
