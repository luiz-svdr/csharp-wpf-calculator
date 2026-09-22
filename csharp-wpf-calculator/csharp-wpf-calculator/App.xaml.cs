using csharp_wpf_calculator.Models;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace csharp_wpf_calculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application{

        public ObservableCollection<HistoricoItem> Historico { get; set; } = new ObservableCollection<HistoricoItem>();
    }
    
    
}
