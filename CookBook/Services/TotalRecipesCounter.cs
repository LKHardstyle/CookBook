using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class TotalRecipesCounter
    {
        private static volatile TotalRecipesCounter _instance;
        private static readonly object _lock = new object();
        public int PreparedRecipesCounter { get; set; }

        public static TotalRecipesCounter Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if(_instance == null)
                        {
                            _instance = new TotalRecipesCounter();
                        }                        
                    }
                }
                return _instance;
            }            
        }
        private TotalRecipesCounter()
        {
            
        }
    }
}
