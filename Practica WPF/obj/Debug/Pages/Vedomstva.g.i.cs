﻿#pragma checksum "..\..\..\Pages\Vedomstva.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0AAFB2D418813E796F9D1B869567D963CFA05C35B61CA86122530B3B75211F2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica_WPF.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Practica_WPF.Pages {
    
    
    /// <summary>
    /// Vedomstva
    /// </summary>
    public partial class Vedomstva : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition SplitterColumn;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition ChangeColumn;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddSubProgram;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CopySubProgram;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditSubProgram;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteSubProgram;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AreasFilterComboBox;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AreasFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridVedomstvo;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\Pages\Vedomstva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AreaTypeTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Practica WPF;component/pages/vedomstva.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Vedomstva.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\Pages\Vedomstva.xaml"
            ((Practica_WPF.Pages.Vedomstva)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SplitterColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.ChangeColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 4:
            this.AddSubProgram = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Pages\Vedomstva.xaml"
            this.AddSubProgram.Click += new System.Windows.RoutedEventHandler(this.ShowButtonVedomstva);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CopySubProgram = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\Pages\Vedomstva.xaml"
            this.CopySubProgram.Click += new System.Windows.RoutedEventHandler(this.ShowButtonVedomstva);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EditSubProgram = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\Pages\Vedomstva.xaml"
            this.EditSubProgram.Click += new System.Windows.RoutedEventHandler(this.ShowButtonVedomstva);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteSubProgram = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\Pages\Vedomstva.xaml"
            this.DeleteSubProgram.Click += new System.Windows.RoutedEventHandler(this.DeleteButtonVedomstva);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AreasFilterComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 107 "..\..\..\Pages\Vedomstva.xaml"
            this.AreasFilterComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.VedomstvaFilterComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AreasFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 124 "..\..\..\Pages\Vedomstva.xaml"
            this.AreasFilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.VedomstvaFilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DataGridVedomstvo = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            
            #line 164 "..\..\..\Pages\Vedomstva.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseEdChangeClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.AreaTypeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 174 "..\..\..\Pages\Vedomstva.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CommitButtonVedomstva);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
