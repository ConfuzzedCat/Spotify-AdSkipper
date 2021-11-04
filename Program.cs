using System.Diagnostics;
using System;
using System.Threading;
namespace Spotify_AdSkipper
{
    class Program
    {
        static void Main(string[] args)
        {
            string _title;
            string _path;
            Process[] processes = Process.GetProcessesByName("spotify");
            while(true) 
            {
                processes = Process.GetProcessesByName("spotify");
                foreach (Process process in processes) {
                    _title = process.MainWindowTitle;
                    _path = process.MainModule.FileName;
                    Console.WriteLine(_title);
                    Console.WriteLine(process.MainModule.FileName);
                    if (!String.IsNullOrEmpty(_title)) {
                        if (_title.ToLower() == "advertisement") {
                            process.CloseMainWindow();
                            process.Close();
                            Process.Start(_path);
                        }
                    } 
                }
                Thread.Sleep(6000);                
            }
        }
    }
}
