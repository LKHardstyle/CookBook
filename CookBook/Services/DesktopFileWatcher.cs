/* Singleton Service */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class DesktopFileWatcher
    {
        private static volatile DesktopFileWatcher _instance;
        private static readonly object _lock = new object();
        private BackgroundWorker _fileCheckWorker;
        public event Action<bool> onFileStatusChange;
        public static bool CurrentFileStatus { get; set; }
        public static DesktopFileWatcher Instance
        {
            get 
            {
                if(_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DesktopFileWatcher();
                        }
                    }
                }
                
                return _instance;
            }
        }

        //More Powerful approach of Factory Method because you can Pass params
        //public static DesktopFileWatcher GetInstance(/*params*/)
        //{
        //    if (_instance == null)
        //    {
        //        lock (_lock)
        //        {
        //            if (_instance == null)
        //            {
        //                _instance = new DesktopFileWatcher();
        //            }
        //        }
        //    }
        //    return _instance;
        //}

        private DesktopFileWatcher() 
        {
            _fileCheckWorker = new BackgroundWorker();
            _fileCheckWorker.DoWork += FileCheckWOrker_DoWork;
            _fileCheckWorker.RunWorkerAsync();
        }

        private void FileCheckWOrker_DoWork(object? sender, DoWorkEventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "ShoppingList.txt");

            CurrentFileStatus = false;

            while (true)
            {
                bool fileExists = File.Exists(filePath);

                if(CurrentFileStatus != fileExists)
                {
                    FileStatusChange(fileExists);

                    CurrentFileStatus = fileExists;
                }                

                Thread.Sleep(1000);
            }
        }

        private void FileStatusChange(bool fileExists)
        {      
            if(onFileStatusChange != null)
                onFileStatusChange.Invoke(fileExists);                                      
        }
    }
}
