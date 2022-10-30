using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Wpf_Reader
{
    class AppViewModel: ViewModelBase
    {
        static int Count = 1;
        private ObservableCollection<string> resultsList =new ObservableCollection<string>();

        public ObservableCollection<string> ResultsList { get => resultsList; set => Set(ref resultsList, value); }


        private string fileName = "test.txt";

        public string FileName { get => fileName; set =>  Set(ref fileName, value);}
        
        private string result;

        public string Result { get => result; set =>  Set(ref result, value);}
        Thread thread;
        public AppViewModel()
        {
            thread = new Thread(CountWord);
        }

        private RelayCommand startCommand = null;

        public RelayCommand StartCommand => startCommand ??= new RelayCommand(
            () =>
        {
            Result = string.Empty;
            //thread = new Thread(CountWord);
            //thread.Start(FileName);

            //ThreadPool.SetMaxThreads(5, 2);
            //ThreadPool.QueueUserWorkItem(CountWord, "test.txt");

            Task.Run(() => CountWord(FileName));
        });
        void CountWord(object data)
        {
            var filename = data as string;
            var text = File.ReadAllText(filename);
            var words = text.Split(new[] { '.', ' ', '!', '?', ',', ';' });
            Result = "CountWords: " + words.Length;
            if (string.IsNullOrWhiteSpace(Result)) ResultsList.Add(Result);
            Application.Current.Dispatcher.Invoke(() =>
            {
                ResultsList.Add($"{Count++})" + Result);
            });
            //MessageBox.Show("CountWords: " + words.Length);
        }

    }
   
    //class AppViewModel : ViewModelBase
    //{
    //    private ObservableCollection<string> resultsList = new ObservableCollection<string>();

    //    public ObservableCollection<string> ResultsList { get => resultsList; set => Set(ref resultsList, value); }


    //    private string fileName = "test.txt";

    //    public string FileName { get => fileName; set => Set(ref fileName, value); }

    //    private string result;

    //    public string Result { get => result; set => Set(ref result, value); }

    //    private RelayCommand startCommand = null;

    //    public RelayCommand StartCommand => startCommand ??= new RelayCommand(
    //        () =>
    //        {
    //            Result = string.Empty;
    //            Thread thread = new Thread(CountWord);
    //            thread.IsBackground = false;
    //            thread.Start(FileName);
    //            //MessageBox.Show("test");
    //        });
    //    void CountWord(object data)
    //    {
    //        var filename = data as string;
    //        var text = File.ReadAllText(filename);
    //        var words = text.Split(new[] { '.', ' ', '!', '?', ',', ';' });
    //        Result = "CountWords: " + words.Length;
    //        if (string.IsNullOrWhiteSpace(Result)) ResultsList.Add(Result);
    //        //MessageBox.Show("CountWords: " + words.Length);
    //    }

    //}
}
