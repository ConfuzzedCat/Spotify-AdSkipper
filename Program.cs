using System.Diagnostics;
using System;
using System.Threading;
namespace Spotify_Ad
{
    class Program
    {
        static void Main(string[] args)
        {
            string _title;
            string _name;
            int _id;
            string _path;
            Process[] processes = Process.GetProcessesByName("spotify");
            while(true) 
            {
                processes = Process.GetProcessesByName("spotify");

                foreach (Process process in processes) {
                    _title = process.MainWindowTitle;
                    _name = process.ProcessName;
                    _id = process.Id;
                    _path = process.MainModule.FileName;
                    Console.WriteLine(_title);
                    Console.WriteLine(_name);
                    Console.WriteLine(_id);
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
