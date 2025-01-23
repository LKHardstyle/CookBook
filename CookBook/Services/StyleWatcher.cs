using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class StyleWatcher
    {
        private static volatile StyleWatcher _instance;
        private static readonly object _instanceLock = new object();
        private BackgroundWorker _styleCheckWorker;
        public event Action<int> onStyleChanged;
        public static int CurrentStyle { get; set; }
        public static StyleWatcher Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new StyleWatcher();
                        }
                    }
                }
                return _instance;
            }
        }
        private StyleWatcher()
        {
            _styleCheckWorker = new BackgroundWorker();
            _styleCheckWorker.DoWork += StyleCheckWorker_DoWork;
            _styleCheckWorker.RunWorkerAsync();
        }

        private void StyleCheckWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            int lastStyle = CurrentStyle;

            while (true)
            {
                int newstyle = CurrentStyle;

                if (newstyle != lastStyle)
                {
                    StyleChanged(newstyle);

                    lastStyle = newstyle;
                }
                Thread.Sleep(20);
            }
        }

        private void StyleChanged(int style)
        {
            if (onStyleChanged != null)
                onStyleChanged.Invoke(style);
        }
    }
}
