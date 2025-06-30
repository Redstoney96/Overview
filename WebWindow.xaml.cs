using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaktionslogik für WebWindow.xaml
    /// </summary>
    public partial class WebWindow : Window
    {
        public WebWindow()
        {
            InitializeComponent();
            loadingAnimation();
            webView.Source = new Uri(File.ReadAllText("C:\\Overview\\Url.yml"));
            this.Closed += WebWindow_Closed;
        }

        private async void loadingAnimation()
        {
            for (int i = -30; i <= 5; i++)
            {
                mainPanel.Margin = new Thickness(i, i, i, i);
                await Task.Delay(1);
            }
        }

        private void WebWindow_Closed(object? sender, EventArgs e)
        {
            try
            {
                webView.Source = new Uri("about:blank");
                webView.Dispose();
            }
            catch
            {
                // Ignorieren, falls WebView schon disposed ist
            }
        }
    }
}
