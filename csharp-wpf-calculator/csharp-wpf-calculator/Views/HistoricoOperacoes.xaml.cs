using csharp_wpf_calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace csharp_wpf_calculator.Views
{
    public partial class HistoricoOperacoes : Window
    {
        public HistoricoOperacoes()
        {
            InitializeComponent();
            App aplicacaoAtual = Application.Current as App;
            HistoricoListControl.ItemsSource = aplicacaoAtual.Historico;
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}