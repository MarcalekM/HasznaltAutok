using System.Collections.ObjectModel;
using System.IO;
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

namespace HasznaltAutok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Auto> autok;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            autok = new();
            using StreamReader sr = new(
                path: @"..\..\..\src\Autok.txt",
                encoding: System.Text.Encoding.UTF8);
            while (!sr.EndOfStream) autok.Add(new Auto(sr.ReadLine()));
            ListedCars.ItemsSource = autok;
        }

        public void ListedCars_SelectionChange()
        {

        }
    }
}