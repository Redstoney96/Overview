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
using System.IO;
using System.Media;

namespace Overview
{
    /// <summary>
    /// Interaktionslogik für CreateNoteWindow.xaml
    /// </summary>
    public partial class CreateNoteWindow : Window
    {
        public CreateNoteWindow()
        {
            InitializeComponent();
            loadingAnimation();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Random random = new Random();
                int nummber = random.Next(1, 20000);
                File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Documents\\Note" + nummber.ToString() + ".txt", TextBox.Text);
                //MessageBox.Show("Note has ben created", "Notes");
                this.Close();
            }
        }
        private async void loadingAnimation()
        {
            for (int i = -10; i <= 3; i++)
            {
                mainPanel.Margin = new Thickness(i, i, i, i);
                await Task.Delay(1);
            }
        }
    }
}
