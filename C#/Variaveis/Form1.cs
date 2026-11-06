namespace Variaveis
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }
                 
        private void btnInteiros_Click(object sender, EventArgs e)
        {
            /*declaração das variáveis*/
            int a, b, soma;

            /*entrada de dados*/
            a = Int32.Parse(txtA.Text);
            b = Int32.Parse(txtB.Text);

            /*processamento*/
            soma = a + b;

            /*saída de dados*/
            txtResultado.Text = soma.ToString();
        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            /*declaração de variáveis*/
            double a, b, soma;

            /*entrada de dados*/
            a = Convert.ToDouble(txtA.Text);
            b = double.Parse(txtB.Text);

            /*processamento*/

            soma = a + b;

            /*saída de dados*/
            txtResultado.Text = soma.ToString();
        }
    }
}
