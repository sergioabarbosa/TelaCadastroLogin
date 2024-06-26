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
    public partial class FormLogin : Form
    {
        public FormLogin()
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
            btnLogin.BackColor = Color.Green;
            btnLogin.ForeColor = Color.White;
            btnLogin.Font = new Font("Arial", 12);
            btnOpenRegister.BackColor = Color.Green;
            btnOpenRegister.ForeColor = Color.White;
            btnOpenRegister.Font = new Font("Arial", 12);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (db.LoginUser(username, password))
            {
                MessageBox.Show("Login bem-sucedido!");
                // Adicione a lógica para abrir a próxima tela ou funcionalidade do seu aplicativo
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                FormRegister formRegister = new FormRegister();
                formRegister.Show();
            }
        }
    }
}
