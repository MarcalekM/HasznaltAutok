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
            ListedCars.SelectionChanged += ListedCars_SelectionChanged;
            ListedCars.SelectedItem = autok[0];
        }

        private void ListedCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Auto item = (Auto)ListedCars.SelectedItem;
            Adatok.Text = $"Típus: {item.tipus}\nMeghajtás: {item.meghajtas}\nÜzemanyag: {item.uzemanyag}\nÁr: {item.ar}";

            Image finalImage = new();
            string currentDirectory = Directory.GetCurrentDirectory();
            finalImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, $@"..\Images\{item.kep}")));
            Kep.Children.Clear();
            Kep.Children.Add(finalImage);

        }
    }
}