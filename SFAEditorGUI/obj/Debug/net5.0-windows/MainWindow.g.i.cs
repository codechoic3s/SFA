﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F645D8BD24166FA0ED6F90C7CFAA42538C0768E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SFAEditorGUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfHexaEditor;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace SFAEditorGUI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LogList;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid WorkspaceGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid HierarchyManagingGrid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToolBarPanel HToolBar;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateEntry;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveEntry;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EntryName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EntryPath;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView SFATree;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl EditorsTabs;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem RawTab;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RawTabGrid;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RawEditorGrid;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfHexaEditor.HexEditor RawEditor;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToolBarPanel RawToolBar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveRaw;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddRangeBytes;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveRangeBytes;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.LongUpDown RawStreamIndex;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.LongUpDown RawStreamCount;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem StringTab;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid StringTabGrid;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DataAsString;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToolBarPanel StringEditorToolBar;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveString;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToolBarPanel Toolbar;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenBTN;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateBTN;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBTN;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveAsBTN;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UnloadBTN;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SFAEditorGUI;V1.0.125.0;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.LogList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.WorkspaceGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.HierarchyManagingGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.HToolBar = ((System.Windows.Controls.Primitives.ToolBarPanel)(target));
            return;
            case 6:
            this.CreateEntry = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\MainWindow.xaml"
            this.CreateEntry.Click += new System.Windows.RoutedEventHandler(this.CreateEntry_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RemoveEntry = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\MainWindow.xaml"
            this.RemoveEntry.Click += new System.Windows.RoutedEventHandler(this.RemoveEntry_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EntryName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.EntryPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.SFATree = ((System.Windows.Controls.TreeView)(target));
            
            #line 38 "..\..\..\MainWindow.xaml"
            this.SFATree.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.SFATree_SelectedItemChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EditorsTabs = ((System.Windows.Controls.TabControl)(target));
            return;
            case 12:
            this.RawTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 13:
            this.RawTabGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            this.RawEditorGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 15:
            this.RawEditor = ((WpfHexaEditor.HexEditor)(target));
            return;
            case 16:
            this.RawToolBar = ((System.Windows.Controls.Primitives.ToolBarPanel)(target));
            return;
            case 17:
            this.SaveRaw = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\MainWindow.xaml"
            this.SaveRaw.Click += new System.Windows.RoutedEventHandler(this.SaveRaw_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.AddRangeBytes = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\MainWindow.xaml"
            this.AddRangeBytes.Click += new System.Windows.RoutedEventHandler(this.AddRangeBytes_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.RemoveRangeBytes = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.RemoveRangeBytes.Click += new System.Windows.RoutedEventHandler(this.RemoveRangeBytes_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.RawStreamIndex = ((Xceed.Wpf.Toolkit.LongUpDown)(target));
            return;
            case 21:
            this.RawStreamCount = ((Xceed.Wpf.Toolkit.LongUpDown)(target));
            return;
            case 22:
            this.StringTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 23:
            this.StringTabGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 24:
            this.DataAsString = ((System.Windows.Controls.TextBox)(target));
            return;
            case 25:
            this.StringEditorToolBar = ((System.Windows.Controls.Primitives.ToolBarPanel)(target));
            return;
            case 26:
            this.SaveString = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\MainWindow.xaml"
            this.SaveString.Click += new System.Windows.RoutedEventHandler(this.SaveString_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            this.Toolbar = ((System.Windows.Controls.Primitives.ToolBarPanel)(target));
            return;
            case 28:
            this.OpenBTN = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\MainWindow.xaml"
            this.OpenBTN.Click += new System.Windows.RoutedEventHandler(this.OpenBTN_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.CreateBTN = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\MainWindow.xaml"
            this.CreateBTN.Click += new System.Windows.RoutedEventHandler(this.CreateBTN_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            this.SaveBTN = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\MainWindow.xaml"
            this.SaveBTN.Click += new System.Windows.RoutedEventHandler(this.SaveBTN_Click);
            
            #line default
            #line hidden
            return;
            case 31:
            this.SaveAsBTN = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\MainWindow.xaml"
            this.SaveAsBTN.Click += new System.Windows.RoutedEventHandler(this.SaveAsBTN_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            this.UnloadBTN = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\MainWindow.xaml"
            this.UnloadBTN.Click += new System.Windows.RoutedEventHandler(this.UnloadBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

