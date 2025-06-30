using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Overview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string[] config;

        private string app1Path = "C:\\Overview\\Placeholder.bat";
        private string app2Path = "C:\\Overview\\Placeholder.bat";
        private string app3Path = "C:\\Overview\\Placeholder.bat";
        private string app4Path = "C:\\Overview\\Placeholder.bat";

        private string folder1Path = "C:\\Overview\\Placeholder.bat";
        private string folder2Path = "C:\\Overview\\Placeholder.bat";
        private string folder3Path = "C:\\Overview\\Placeholder.bat";
        private string folder4Path = "C:\\Overview\\Placeholder.bat";
        private string folder5Path = "C:\\Overview\\Placeholder.bat";
        private string folder6Path = "C:\\Overview\\Placeholder.bat";

        private string folder1Text = "";
        private string folder2Text = "";
        private string folder3Text = "";
        private string folder4Text = "";
        private string folder5Text = "";
        private string folder6Text = "";

        private BitmapImage appPlaceholderIcon = new BitmapImage(new Uri("C:\\Users\\Youtube\\Pictures\\placeholdericon2.png"));
        private BitmapImage appIcon;
        public MainWindow()
        {
            InitializeComponent();
            loadingAnimation();

            try
            {
                var imageBrush = new ImageBrush();
                imageBrush.ImageSource = new BitmapImage(new Uri(File.ReadAllText("C:\\Overview\\background.yml")));
                imageBrush.Stretch = Stretch.UniformToFill;
                mainPanel.Background = imageBrush;
            }
            catch
            {

            }
            try
            {
                config = File.ReadAllLines("C:\\Overview\\Config.yml");
            }
            catch
            {
                try
                {
                    File.WriteAllLines("C:\\Overview\\Config.yml", Enumerable.Range(1, 35).Select(n => n.ToString()));
                    config = File.ReadAllLines("C:\\Overview\\Config.yml");
                }
                catch
                {
                    try
                    {
                        string folderPath = "C:\\Overview";
                        Directory.CreateDirectory(folderPath);
                        File.WriteAllLines("C:\\Overview\\Config.yml", Enumerable.Range(1, 35).Select(n => n.ToString()));
                        config = File.ReadAllLines("C:\\Overview\\Config.yml");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Create Program folder Error");

                    }
                }
                
            }
            File.WriteAllText("C:\\Overview\\Placeholder.bat", "exit");
            File.WriteAllText("C:\\Overview\\LICENSE.txt", "LICENSE: GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007, License Link: https://www.gnu.org/licenses/gpl-3.0.html");

            try
            {
                if (config[0] != "1")
                {
                    app1Path = config[0];
                }
                if (config[1] != "2")
                {
                    app2Path = config[1];
                }
                if (config[2] != "3")
                {
                    app3Path = config[2];
                }
                if (config[3] != "4")
                {
                    app4Path = config[3];
                }
            }
            catch
            {

            }

            try
            {
                if (config[4] != "5")
                {
                    app1.Source = new BitmapImage(new Uri(config[4]));
                }
                if (config[5] != "6")
                {
                    app2.Source = new BitmapImage(new Uri(config[5]));
                }
                if (config[6] != "7")
                {
                    app3.Source = new BitmapImage(new Uri(config[6]));
                }
                if (config[7] != "8")
                {
                    app4.Source = new BitmapImage(new Uri(config[7]));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Icon Error");
            }

            try
            {
                if (Directory.Exists(config[8]))
                {
                    folder1Path = config[8];
                    folder1T.Content = System.IO.Path.GetFileName(config[8]);
                }
                else
                {
                    folder1T.Content = "----------";
                }

                if (Directory.Exists(config[9]))
                {
                    folder2Path = config[9];
                    folder2T.Content = System.IO.Path.GetFileName(config[9]);
                }
                else
                {
                    folder2T.Content = "----------";
                }

                if (Directory.Exists(config[10]))
                {
                    folder3Path = config[10];
                    folder3T.Content = System.IO.Path.GetFileName(config[10]);
                }
                else
                {
                    folder3T.Content = "----------";
                }

                if (Directory.Exists(config[11]))
                {
                    folder4Path = config[11];
                    folder4T.Content = System.IO.Path.GetFileName(config[11]);
                }
                else
                {
                    folder4T.Content = "----------";
                }

                if (Directory.Exists(config[12]))
                {
                    folder5Path = config[12];
                    folder5T.Content = System.IO.Path.GetFileName(config[12]);
                }
                else
                {
                    folder5T.Content = "----------";
                }

                if (Directory.Exists(config[13]))
                {
                    folder6Path = config[13];
                    folder6T.Content = System.IO.Path.GetFileName(config[13]);
                }
                else
                {
                    folder6T.Content = "----------";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Config Error");
            }



        }

        private async void loadingAnimation()
        {
            for (int i = -10; i <= 10; i++)
            {
                mainPanel.Margin = new Thickness(i, i, i, i);
                await Task.Delay(1);
            }
        }
        private void app1Click(object sender, MouseEventArgs e)
        {
            Process.Start(app1Path);
        }
        private void app2Click(object sender, MouseEventArgs e)
        {
            Process.Start(app2Path);
        }
        private void app3Click(object sender, MouseEventArgs e)
        {
            Process.Start(app3Path);
        }
        private void app4Click(object sender, MouseEventArgs e)
        {
            Process.Start(app4Path);
        }


        // Folder Logic
        private void folder1Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start("explorer.exe", folder1Path);
        }
        private void folder2Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start("explorer.exe", folder2Path);
        }
        private void folder3Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start("explorer.exe", folder3Path);
        }
        private void folder4Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start("explorer.exe", folder4Path);
        }
        private void folder5Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start("explorer.exe", folder5Path);
        }
        private void folder6Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start("explorer.exe", folder6Path);
        }
        // End of Folder Logic
        // Note Logic
        private void noteCreate(object sender, RoutedEventArgs e)
        {
            var noteWindow = new CreateNoteWindow();
            noteWindow.Show();
        }
        private void notesShow(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\Documents"
            };
            dlg.ShowDialog();
            Process.Start("explorer.exe", dlg.FileName);
        }

        private void openSettings(object sender, RoutedEventArgs e)
        {
            var settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }

        private void mainPanel_Drop(object sender, DragEventArgs e)
        {

            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files?.Length > 0)
                Console.WriteLine("");
            try
            {
                var imageBrush = new ImageBrush();
                imageBrush.ImageSource = new BitmapImage(new Uri(System.IO.Path.GetFullPath(files[0])));
                imageBrush.Stretch = Stretch.UniformToFill;
                mainPanel.Background = imageBrush;
                try
                {
                    File.Delete("C:\\Overview\\background.yml");
                }
                catch
                {

                }
                File.WriteAllText("C:\\Overview\\background.yml", System.IO.Path.GetFullPath(files[0]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Background Error");
            }
            


        }

        private void shortcut1Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                File.Delete("C:\\Overview\\Url.yml");
            }
            catch
            {

            }
            File.WriteAllText("C:\\Overview\\Url.yml", "https://music.youtube.com");
            var musicWindow = new WebWindow();
            musicWindow.Show();
        }
        private void shortcut2Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                File.Delete("C:\\Overview\\Url.yml");
            }
            catch
            {

            }
            File.WriteAllText("C:\\Overview\\Url.yml", "https://www.youtube.com");
            var musicWindow = new WebWindow();
            musicWindow.Show();
        }
        private void shortcut3Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                File.Delete("C:\\Overview\\Url.yml");
            }
            catch
            {

            }
            File.WriteAllText("C:\\Overview\\Url.yml", "https://www.google.com");
            var musicWindow = new WebWindow();
            musicWindow.Show();
        }
        private void shortcut4Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                File.Delete("C:\\Overview\\Url.yml");
            }
            catch
            {

            }
            File.WriteAllText("C:\\Overview\\Url.yml", "https://example.com");
            var musicWindow = new WebWindow();
            musicWindow.Show();
        }
    }
}