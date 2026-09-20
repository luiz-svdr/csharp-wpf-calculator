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
        
    }
}