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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;

namespace Text_Editor
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string fileDialogName = "";
        public string[] readText = new string[1000];
        public string[] editText = new string[1000];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, RoutedEventArgs e)
        { 
            var fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = @"C:\Visual Studio Projekte\Text-Editor\Text Files";
            fileDialog.DefaultExt = "txt";
            fileDialog.Filter = "(*.txt)|";
            fileDialog.Multiselect = false;
            fileDialog.ShowDialog();
            fileDialogName = fileDialog.FileName;
            if (fileDialogName != "")
            {
                fileNameBlock.Text = "";
                fileSpaceBox.Text = "";
                fileNameBlock.Text = fileDialogName;
                readText = File.ReadAllLines(fileDialogName);
                for (int i = 0; i < readText.Length; i++)
                {
                    fileSpaceBox.Text += readText[i] + '\n';
                }

            }
        }

        private void saveFileBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fileSpaceBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }
    }
}
