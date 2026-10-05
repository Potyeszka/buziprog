using Microsoft.Win32;
using System.IO;
using System.Runtime.CompilerServices;
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

namespace gyak4_kepvalogato
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

        private void loadImages(string folder)
        {
            string[] fileNames = Directory.GetFiles(folder);

            for (int i = 0; i < fileNames.Length; i++)
            { 
             if(fileNames[i].EndsWith(".jpg") || fileNames[i].EndsWith(".png"))
                {
                    BitmapImage bm_im = new BitmapImage(new Uri(fileNames[i]));

                    Border border = new Border() { Width = 140, Height = 100 };
                    wrapPanel.Children.Add(border);

                    Image im = new Image() { Width = 120, Height = 80, HorizontalAlignment=HorizontalAlignment.Center, VerticalAlignment=VerticalAlignment.Center,Source=bm_im};

                    border.Child= im;

                }
                

                
                
            }
        }

        private void mappa_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog dialog = new OpenFolderDialog();

            if (dialog.ShowDialog() == true)
            {
                string folder = dialog.FolderName;
                kepnev.Text= folder;

                loadImages(folder);
            }
        }
    }
}