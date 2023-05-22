namespace Sistema_de_Login
{
    public partial class Form1 : Form
    {
        public static List<Usuario> usuarios = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Insira o email");
                return;
            }
            else if (textBox2.Text=="")
            {
                MessageBox.Show("Insira a senha");
                return;
            }
            string email = textBox1.Text;
            string senha = textBox2.Text;
            if (usuarios.Count > 0)
            {
                foreach (var item in usuarios)
                {
                    if (email == item.Email && senha == item.Senha)
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                        Form3 form3 = new Form3(email);
                        this.Visible = false;
                        form3.Visible = true;
                    }
                    else if (email == item.Email && senha != item.Senha)
                    {
                        MessageBox.Show("Senha incorreta");
                    }
                }
            }
            else
            {
                MessageBox.Show("Email não cadastrado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Visible = false;
            form2.Visible = true;
        }
    }
}