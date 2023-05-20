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
    public partial class Form3 : Form
    {


        public Form3(string emailv)
        {
            InitializeComponent();
            string email=emailv;
            foreach (var item in Form1.usuarios)
            {
                if (email == item.Email)
                {
                    label2.Text = $"Nome: {item.Nome}\nIdade: {item.Idade}\nEmail: {item.Email}\nSenha: {item.Senha}";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            Form1 form1= new Form1();
            form1.Visible=true;
        }
    }
}
