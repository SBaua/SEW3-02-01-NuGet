using NLog;
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

namespace SEW3_02_01_NuGet_Log
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        int z1;
        int z2;
        public MainWindow()
        {
            InitializeComponent();
        }

       
            
        

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("Button wurde betätigt");

            try
            {
                logger.Info("Zahl 1, Zahl 2 konvertiert");
                z1 = Convert.ToInt32(tbx_Eingabe_1.Text);
                z2 = Convert.ToInt32(tbx_Eingabe_2.Text);
            }

            catch (Exception ex)
            {
                logger.Error(ex, "Fehler beim Konvertieren der Zahlen");
            }

            try
            {
                logger.Info("Ergebnis konvertiert und ausgegeben");
                tbk_sum.Text = Convert.ToString(z1 + z2);
            }

            catch
            {
                logger.Info("Fehler beim Konvertieren des Ergebnis");
            }
        }
    }
}