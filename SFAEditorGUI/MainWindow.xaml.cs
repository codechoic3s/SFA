using Microsoft.Win32;
using SFA.Elements;
using SFAEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace SFAEditorGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
        private SaveFileDialog CreateFileDialog;

        private string FilePath;
        private bool OpenedFile;

        private App App;
        public MainWindow(App app)
        {
            InitializeComponent();
            App = app;
            InitDialogs();
            App.Editor.SetStringEncoding(Encoding.UTF8);
        }

        private void InitDialogs()
        {
            OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Open SFA.";

            SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Title = "Save SFA.";

            CreateFileDialog = new SaveFileDialog();
            CreateFileDialog.Title = "Create SFA.";
        }

        public void TryLoad(string path, ManagingType mt)
        {
            var state = App.Editor.LoadSFA(path, mt);
            if (!state)
            {
                OpenedFile = false;
                AddLog("Failed allocate SFAStream.");
            }
            else
            {
                OpenedFile = true;
                AddLog("Allocated SFAStream.");
            }
        }

        public void LoadTree()
        {
            var mgr = App.Editor.Manager;
            var header = mgr.Header;

            var hfs = header.Files;
            SFATree.ItemsSource = hfs;
        }

        public void ClearControls()
        {
            SFATree.ItemsSource = null;
            DataAsString.Text = "";
        }

        #region WindowNative

        public void AddLog(string text)
        {
            LogList.Items.Add(text);
        }

        private void OpenBTN_Click(object sender, RoutedEventArgs e)
        {
            bool state = (bool)OpenFileDialog.ShowDialog(this);
            if (!state)
            {
                AddLog("Not selected file to load SFA.");
                return;
            }

            if (!OpenFileDialog.CheckPathExists)
            {
                AddLog("File not exists.");
                return;
            }

            var path = OpenFileDialog.FileName;
            FilePath = path;
            AddLog($"Openning {path}...");
            TryLoad(path, ManagingType.Managed);
            state = App.Editor.Manager.OpenSFA();

            if (!state)
            {
                AddLog("Broken SFA.");
                return;
            }

            LoadTree();
        }

        private void CreateBTN_Click(object sender, RoutedEventArgs e)
        {
            var state = (bool)CreateFileDialog.ShowDialog(this);
            if (!state)
            {
                AddLog("Not selected file to create SFA.");
                return;
            }

            var path = CreateFileDialog.FileName;
            FilePath = path;
            AddLog($"Creating {path}...");
            TryLoad(path, ManagingType.Managed);
            state = App.Editor.Manager.InitNewSFA();
            if (!state)
            {
                AddLog("Failed create SFA.");
                return;
            }
            LoadTree();
        }

        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {
            if (!OpenedFile)
            {
                AddLog("Failed save SFA, not opened.");
                return;
            }
            App.Editor.Manager.CommitChanges();
            AddLog("Changes applied.");
        }

        private void SaveAsBTN_Click(object sender, RoutedEventArgs e)
        {
            if (!OpenedFile)
            {
                AddLog("Failed save SFA, not opened.");
                return;
            }

            var state = SaveFileDialog.ShowDialog(this);
            if (!(bool)state)
            {
                AddLog("Not selected file path to save SFA.");
                return;
            }

            AddLog("Not implemented!!!.");
        }

        private void UnloadBTN_Click(object sender, RoutedEventArgs e)
        {
            bool state = App.Editor.UnloadSFA();
            if (!state)
            {
                AddLog("Failed unload SFA file.");
                return;
            }
            ClearControls();
            AddLog("Unloaded SFA file.");
        }

        private void CreateEntry_Click(object sender, RoutedEventArgs e)
        {
            if (!OpenedFile)
            {
                AddLog("Failed create EntryFile in SFA file, not opened.");
                return;
            }
            App.Editor.Manager.AddManagedFile(new ManagedFile(EntryName.Text, EntryPath.Text, new byte[] { }));
            LoadTree();
        }

        private void RemoveEntry_Click(object sender, RoutedEventArgs e)
        {
            if (!OpenedFile)
            {
                AddLog("Failed remove EntryFile in SFA file, not opened.");
                return;
            }

            var item = SFATree.SelectedItem;
            if (item is null)
            {
                AddLog("Failed remove EntryFile in SFA file, not selected entry.");
                return;
            }
            App.Editor.Manager.RemoveFile((HeaderFile)item);
            LoadTree();
        }

        private void SFATree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var nw = e.NewValue;
            if (nw is HeaderFile hf)
            {
                var state = App.Editor.Manager.GetStorageFile(hf, out StorageFile sf);
                if (!state)
                {
                    AddLog("Failed get StorageFile from SFA, unknown entry.");
                    return;
                }
                DataAsString.Text = App.Editor.Encoding.GetString(sf.Data);
            }
            else
            {
                AddLog("Failed get StorageFile from SFA, undefined type.");
                return;
            }
        }

        private void SaveString_Click(object sender, RoutedEventArgs e)
        {
            var si = SFATree.SelectedItem;
            if (si is HeaderFile hf)
            {
                var data = App.Editor.Encoding.GetBytes(DataAsString.Text);
                var sf = new StorageFile(data);
                bool state = App.Editor.Manager.SetFile(hf, sf);
                if (!state)
                    AddLog($"Failed update StorageFile in SFA {hf.Name} ({hf.Path}).");
            }
            else
            {
                AddLog("Failed save StorageFile in SFA, undefined type.");
            }
        }
        #endregion

    }
}
