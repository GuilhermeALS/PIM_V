using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace PIM_V
{
    public partial class FormLogin : Form
    {
        Thread nt;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            String Login = "admin";
            String Senha = "admin";

            if(txtLogin.Text == Login & TxtSenha.Text == Senha)
            {
                MessageBox.Show("Acesso Liberado!");
                Form1 FrmMain = new Form1();
                FrmMain.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Login/Senha Inválidos(s). Tente novamente!");
            }
        }

        private void BtnEnt_Click(object sender, EventArgs e)
        {
            String Login = "admin";
            String Senha = "admin";

            if (txtLogin.Text == Login & TxtSenha.Text == Senha)
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                Form1 FrmMain = new Form1();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login/Senha Incorretos!");
            }
        }

        private void novoForm()
        {
            Application.Run(new FormMenu());
        }
    }
    }

