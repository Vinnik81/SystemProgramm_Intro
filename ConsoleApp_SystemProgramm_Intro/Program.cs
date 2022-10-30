using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_SystemProgramm_Intro
{
    class Program
    {
        static async void CountWord(object data)
        {
            var filename = data as string;
           var text = await File.ReadAllTextAsync(filename);
            var words = text.Split(new[] { '.', ' ', '!', '?', ',', ';' });
            Console.WriteLine("CountWords: " + words.Length);
        }

        // static void Func()
        //{
        //    Console.WriteLine("Test thread");
        //}
        static void Main(string[] args)
        {
            static void Print1(int count, string word)
            {
                for (int i = 1; i < count; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"{i}) " + word);
                }
            }
            Task task1 = new Task(() => Print1(20, "Vladimir"));
            Console.WriteLine("Start");
            task1.Start();
            task1.Wait();
            Console.WriteLine("Finish");

            //Task task1 = new Task(() => Print1(20, "Vladimir"));
            //Task task2 = new Task(() => Print1(20, "Dima"));
            //Console.WriteLine("Start");
            //task1.Start();
            //task2.Start();
            //Console.WriteLine("Finish");
            //task1.Wait();

            //Console.WriteLine("Start  Thread");
            //Task.Run(() => CountWord("test.txt"));
            //Console.WriteLine("Finish");
            //Console.ReadKey();

            //Console.WriteLine("Start  Thread");
            //ThreadPool.QueueUserWorkItem(CountWord, "test.txt");
            //Console.WriteLine("Finish");
            //Console.ReadKey();

            //Thread thread = new Thread(CountWord);
            //Console.WriteLine("Start First Thread");
            //thread.Start("test.txt");
            //Console.WriteLine("Start Second Thread");
            //thread.Start("test.txt");
            //Console.WriteLine("Finish");

            //Thread thread = new Thread(CountWord);
            //Console.WriteLine("Start");
            //thread.Start("test.txt");
            //Console.WriteLine("Finish");

            //File.WriteAllText("test.txt", "Hello");

            //Thread thread = new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Test thread");
            //});
            //thread.IsBackground = true;
            //Console.WriteLine("Start");
            //thread.Start();
            //Console.WriteLine("Finish");

            //Thread thread = new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Test thread");
            //});
            //thread.Start();
            //Console.WriteLine("Start");
            //Console.WriteLine("Finish");

            //Console.WriteLine("Start");
            //Thread thread1 = new Thread(Func);
            //Thread thread2 = new Thread(() =>Func());
            //Thread thread3 = new Thread(() => Console.WriteLine("Test thread"));
            //Thread thread4 = new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Test thread"); 
            //});
            //thread1.Start();
            //Console.WriteLine("Finish");

            //Console.WriteLine("Start");
            //Thread thread1 = new Thread(Func);
            //Thread thread2 = new Thread(() => Func());
            //Thread thread3 = new Thread(() => Console.WriteLine("Test thread"));
            //Thread thread4 = new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Test thread");
            //});
            //Process.Start("mspaint");
            //int count = 0;
            //do
            //{
            //    var arr = Process.GetProcesses().OrderByDescending(x => x.PagedMemorySize);
            //    count++;
            //    foreach (var item in arr)
            //    {
            //        try
            //        {
            //            Console.WriteLine($"{item.ProcessName.ToString().PadRight(30, ' ')}\t" +
            //                $"{item.PriorityClass.ToString().PadRight(20, ' ')}\t{item.Id}\t" +
            //                $"{item.MainWindowTitle.ToString().PadRight(20, ' ')}\t" +
            //                $"{item.PagedMemorySize.ToString().PadRight(30, ' ')}");
            //        }
            //        catch (Exception)
            //        { 
            //        }
            //    }
            //    Console.WriteLine("Count: " + count);
            //    if (count == 5)
            //    {
            //      Process process = arr.Where(x => x.ProcessName.Equals("mspaint")).FirstOrDefault();
            //       if(process != null) process.Kill();
            //    }
            //    Thread.Sleep(5000);
            //    Console.Clear();
            //} while (true);


        }
    }
}
