using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Overview
{
    /// <summary>
    /// Interaktionslogik für SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            loadingAnimation();
        }

        private void autoStartOn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Auto Start is enabled", "Settings");
        }
        private void autoStartOff(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Auto Start is disable", "Settings");
        }
        private async void loadingAnimation()
        {
            for (int i = -30; i <= 10; i++)
            {
                mainPanel.Margin = new Thickness(i, i, i, i);
                await Task.Delay(1);
            }
        }
    }
}
