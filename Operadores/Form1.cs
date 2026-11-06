namespace Operadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            int x, y; // declaração de variáveis
            x = Convert.ToInt32(txtX.Text);  // entrada de dados, converte o Texto do TexBox em int

            y = ++x; // incremento pré-fixado

            MessageBox.Show("Y = " + y + "X = " +x , "Incremento Pré-Fixado"); // saida de dados
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            int x, y; // declaração de variáveis
            x = Convert.ToInt32(txtX.Text); // entrada de dados, converte o Texto do TexBox em int

            y = x++; // incremento pós-fixado

            MessageBox.Show("Y = " + y + "X = " + x , "Incremento Pós-Fixado");


        }
    }
}
