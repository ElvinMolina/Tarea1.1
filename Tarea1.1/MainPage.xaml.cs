using Xamarin.Forms;



namespace CalculadoraApp
{
    public partial class MainPage : ContentPage
    {
        private Operaciones operaciones;

        public MainPage()
        {
            InitializeComponent();
            operaciones = new Operaciones();
        }

        private void CalcularSuma(object sender, System.EventArgs e)
        {
            double num1 = double.Parse(Numero1.Text);
            double num2 = double.Parse(Numero2.Text);
            double resultado = operaciones.Sumar(num1, num2);
            Resultado.Text = resultado.ToString();
        }

        private void CalcularResta(object sender, System.EventArgs e)
        {
            double num1 = double.Parse(Numero1.Text);
            double num2 = double.Parse(Numero2.Text);
            double resultado = operaciones.Restar(num1, num2);
            Resultado.Text = resultado.ToString();
        }

        private void CalcularMultiplicacion(object sender, System.EventArgs e)
        {
            double num1 = double.Parse(Numero1.Text);
            double num2 = double.Parse(Numero2.Text);
            double resultado = operaciones.Multiplicar(num1, num2);
            Resultado.Text = resultado.ToString();
        }

        private void CalcularDivision(object sender, System.EventArgs e)
        {
            double num1 = double.Parse(Numero1.Text);
            double num2 = double.Parse(Numero2.Text);
            double resultado = operaciones.Dividir(num1, num2);
            Resultado.Text = resultado.ToString();
        }
    }
}
