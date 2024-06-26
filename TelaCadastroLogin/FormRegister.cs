using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCadastroLogin
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();



            // Estilizando o formulário
            this.BackColor = Color.LightBlue;
            this.Text = "Login";

            // Estilizando TextBoxes
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Font = new Font("Arial", 12);

            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Font = new Font("Arial", 12);

            // Estilizando Botões
            btnRegister.BackColor = Color.Green;
            btnRegister.ForeColor = Color.White;
            btnRegister.Font = new Font("Arial", 12);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {
                Database db = new Database();
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                db.RegisterUser(username, password);
                MessageBox.Show("Usuário registrado com sucesso!");
                this.Close();
            }

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
