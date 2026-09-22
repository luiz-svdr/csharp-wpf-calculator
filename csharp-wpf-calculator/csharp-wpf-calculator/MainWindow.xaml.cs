using csharp_wpf_calculator.Models;
using csharp_wpf_calculator.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace csharp_wpf_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        

        private void NumeroBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
               string numeroClicado = button.Content.ToString();
               DisplayOperacao.Text += numeroClicado;
            }
        }
        private void OperacaoBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string operacaoClicada = button.Content.ToString();
                DisplayOperacao.Text += operacaoClicada;
            }
        }
        private void FuncaoBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string funcaoClicada = button.Content.ToString();
                DisplayOperacao.Text += funcaoClicada;
            }
        }

        private void FuncaoClearBtn_Click(object sender, RoutedEventArgs e)
        {
            DisplayOperacao.Text = string.Empty;
        }

        private void AcessoHistoricoBtn_Click (object sender, RoutedEventArgs e)
        {            
            HistoricoOperacoes historicoOperacoes = new HistoricoOperacoes();
            historicoOperacoes.Show();
        }

       private void FuncaoPorcentagemBtn_Click(object sender, RoutedEventArgs e)
        {
            string expressao = DisplayOperacao.Text;
            Services.CalculadoraService calculadoraService = new Services.CalculadoraService();
            calculadoraService.ResolverExpressao(expressao);
            double resultado = calculadoraService.NumerosConvertidos[0];
            resultado = resultado / 100;
            DisplayOperacao.Text = resultado.ToString();
        }

        private void FuncaoInversaoBtn_Click(object sender, RoutedEventArgs e)
        {
            string expressao = DisplayOperacao.Text;
            Services.CalculadoraService calculadoraService = new Services.CalculadoraService();
            calculadoraService.ResolverExpressao(expressao);
            double resultado = calculadoraService.NumerosConvertidos[0];
            resultado = resultado * -1;
            DisplayOperacao.Text = resultado.ToString();
        }

        private void IgualBtn_Click(object sender, RoutedEventArgs e)
        {
            string expressao = DisplayOperacao.Text;
            Services.CalculadoraService calculadoraService = new Services.CalculadoraService();
            calculadoraService.ResolverExpressao(expressao);
            double resultado = calculadoraService.NumerosConvertidos[0];
            DisplayOperacao.Text = resultado.ToString();

            App aplicacaoAtual = Application.Current as App;
            HistoricoItem novoItem = new HistoricoItem { Descricao = expressao + " = " + resultado.ToString() };
            aplicacaoAtual.Historico.Add(novoItem);
        }

    }
}