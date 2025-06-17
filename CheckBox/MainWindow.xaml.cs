using System.Windows;

namespace CheckBoxControlEvent
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
        private void ChkToanBo_Checked(object sender, RoutedEventArgs e)
        {
            chkTech.IsChecked = true;
            chkTour.IsChecked = true;
            chkFootball.IsChecked = true;
            chkMovie.IsChecked = true;
        }
        private void ChkToanBo_Unchecked(object sender, RoutedEventArgs e)
        {
            chkTech.IsChecked = false;
            chkTour.IsChecked = false;
            chkFootball.IsChecked = false;
            chkMovie.IsChecked = false;
        }
        private void chkSub_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (chkTech.IsChecked == true && chkTour.IsChecked == true && chkFootball.IsChecked == true && chkMovie.IsChecked == true)
            {
                chkAll.IsChecked = true;
            }
            else if (chkTech.IsChecked == false && chkTour.IsChecked == false && chkFootball.IsChecked == false && chkMovie.IsChecked == false)
                chkAll.IsChecked = false;
        }
    }
}