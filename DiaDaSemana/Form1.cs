namespace DiaDaSemana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //codificando o botão para fechar
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //codificando o o Load do Form
            //esse evento permite executar tarefas antes do Form ser carregado
            lblDiaSemana.ResetText();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //declaração de variável
            int dia; 

            //convertendo a variável
            dia = Convert.ToInt32(txtDia.Text);

            //verificando a seleção do switch
            switch (dia)
            {
                case 1:
                    lblDiaSemana.Text = "Domingo";
                    break;
                case 2:
                    lblDiaSemana.Text = "Segunda - feira";
                    break;
                case 3:
                    lblDiaSemana.Text = "Terça - feira";
                    break;
                case 4:
                    lblDiaSemana.Text = "Quarta - feira";
                    break;
                case 5:
                    lblDiaSemana.Text = "Quinta - feira";
                    break;
                case 6:
                    lblDiaSemana.Text = "Sexta - feira";
                    break;
                case 7:
                    lblDiaSemana.Text = "Sábado";
                    break;
                default:
                    lblDiaSemana.Text = "Dia inválido";
                    break;
            }

        }
    }
}
