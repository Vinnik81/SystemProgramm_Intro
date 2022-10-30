using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Wpf_Reader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new AppViewModel();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Thread thread = new Thread(CountWord);
        //    thread.IsBackground = false;
        //    thread.Start(FileName.Text);
        //    //CountWord(FileName.Text);
        //}

        // void CountWord(object data)
        //{
        //    var filename = data as string;
        //    var text =  File.ReadAllText(filename);
        //    var words = text.Split(new[] { '.', ' ', '!', '?', ',', ';' });
        //    Dispatcher.Invoke(()=> Result.Content = "CountWords: " + words.Length);
        //    MessageBox.Show("CountWords: " + words.Length);
        //}
    }
}
