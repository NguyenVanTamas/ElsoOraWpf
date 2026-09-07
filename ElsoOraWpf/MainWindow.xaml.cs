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

namespace ElsoOraWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int kor = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSubmit(object sender, RoutedEventArgs e)
        {
            bool eredmeny = Int32.TryParse(korTextBox.Text, out kor);

            if (!eredmeny)
            {
                MessageBox.Show("Kötelező számot megadni", "Hiba üzenet", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                eredmenyText.Text = $"Eredmény:{kor}";
            }
        }
    }
}