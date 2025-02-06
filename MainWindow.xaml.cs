using Entities;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFLabs.Components;
using WPFLabs.Repository;
using WPFLabs.View;

namespace WPFLabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      

        public event PropertyChangedEventHandler? PropertyChanged;

        private enum CategoryType 
        { 
            Tasks, History
        };
        private CategoryType Category = CategoryType.History;


        public MainWindow()
        {
            var stateRepo = LocalStateRepository.GetInstance();
            InitializeComponent();

            stateRepo.Frame = MainFrame;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}