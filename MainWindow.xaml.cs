using System.Diagnostics;
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

namespace MessengerWebAPIFrontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindow Main;
        public MainWindow()
        {
            InitializeComponent();
            Main = this;
        }

        private async void Move(object sender, MouseEventArgs e)
        {
            
            
            MessageBox.Show("asdasd");

        }
        

    }
}