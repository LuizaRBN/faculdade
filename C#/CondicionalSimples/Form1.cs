namespace CondicionalSimples
{
    public partial class FormMedia : Form
    {
        public FormMedia()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //declarando variáveis média
            double media;

            //variavel media recebe o valor que foi digitado no TextBox
            //Convert.ToDouble, converter o texto do TextBox para o tipo double
            media = Convert.ToDouble(txtMedia.Text);

            //testa a condicao: se média é maior ou igual a sete
            //se condição verdadeira, apresenta a mensagem no MessageBox
            if (media >= 7)
            {
                MessageBox.Show("Aluno aprovado!!", "Média");
            }
            else
            {
                MessageBox.Show("Aluno Reprovado!!", "Média");
            }
        }
    }
}
