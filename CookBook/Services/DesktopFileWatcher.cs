/* Singleton Service */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class DesktopFileWatcher
    {
        private static volatile DesktopFileWatcher _instance;
        private static readonly object _lock = new object();
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
        private DesktopFileWatcher() 
        {
            
        }
    }
}
