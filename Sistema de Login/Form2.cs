using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Login
{
    public partial class Form2 : Form
    {
        private Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome, senha, email;
            int idade;
            nome = textBox1.Text;
            idade = int.Parse(textBox2.Text);
            email = textBox3.Text;
            senha = textBox4.Text;

            if (idade < 0 || idade > 120)
            {
                MessageBox.Show("Idade Inválida");
                return;
            }
            else if (nome.Length < 5)
            {
                MessageBox.Show("Nome inválido");
                return;
            }
            else if (email.IndexOf("@gmail.com") == -1)
            {
                MessageBox.Show("Formato de email inválido");
                return;
            }
            else if (email.Length < 10)
            {
                MessageBox.Show("Formato de email inválido");
                return;
            }
            else if (senha.Length<5)
            {
                MessageBox.Show("A senha deve conter no minimo 5 caracteres");
                return;
            }
            else if (senha.IndexOf('@')==-1)
            {
                MessageBox.Show("A senha deve conter no minimo 1 caracter alfanumérico");
                return;
            }
            else if (Form1.usuarios.Count > 0)
            {
                foreach (var item in Form1.usuarios)
                {
                    if (email == item.Email)
                    {
                        MessageBox.Show("Esse email ja foi cadastrado");
                        return;
                    }
                    else if (idade < 0 || idade > 120)
                    {
                        MessageBox.Show("Idade Inválida");
                        return;
                    }
                    else if (email.IndexOf("@gmail.com") == -1)
                    {
                        MessageBox.Show("Formato de email inválido");
                        return;
                    }
                }
            }
            Form1.usuarios.Add(new Usuario(nome, idade, email, senha));
            MessageBox.Show("Cadastro realizado com sucesso!");
            this.Visible = false;
            form1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form1.Visible = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora o caractere não numérico

            }
        }
    }
}
