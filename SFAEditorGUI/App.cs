using SFAEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SFAEditorGUI
{
    public sealed class App
    {
        public MainWindow MainWindow;
        public Editor Editor;

        private Thread MWThread;

        public void Start()
        {
            MWThread = new Thread(MWWork);
            MWThread.SetApartmentState(ApartmentState.STA); // winapi
            MWThread.Start();
        }

        private void MWWork()
        {
            Editor = new Editor();
            MainWindow = new MainWindow(this);
            MainWindow.ShowDialog();
        }
    }
}
