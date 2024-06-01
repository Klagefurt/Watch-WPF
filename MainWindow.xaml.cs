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

namespace WatchWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CompositionTarget.Rendering += (s, e) =>
            {
                DateTime dt = DateTime.Now;
                rotateSecond.Angle = 6 * (dt.Second + dt.Millisecond / 1000.0);
                rotateMinute.Angle = 6 * dt.Minute + rotateSecond.Angle / 60;
                rotateHour.Angle = 30 * (dt.Hour % 12) + rotateMinute.Angle / 12;
            };
        }
    }
}