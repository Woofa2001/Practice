﻿#pragma checksum "..\..\..\Pages\SubProgramPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CBA4BBBB84FCD13E16ED3A8DE31B7B1E0EE83938CC797F68B91BCD647306E7ED"
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
    /// SubProgramPage
    /// </summary>
    public partial class SubProgramPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition SplitterColumn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition ChangeColumn;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddSubProgram;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CopySubProgram;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditSubProgram;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteSubProgram;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AreasFilterComboBox;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AreasFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridSub;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProgramsComboBox;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\Pages\SubProgramPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Area1TypeTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Practica WPF;component/pages/subprogrampage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SubProgramPage.xaml"
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
            
            #line 9 "..\..\..\Pages\SubProgramPage.xaml"
            ((Practica_WPF.Pages.SubProgramPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
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
            
            #line 76 "..\..\..\Pages\SubProgramPage.xaml"
            this.AddSubProgram.Click += new System.Windows.RoutedEventHandler(this.CopySubProgram_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CopySubProgram = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Pages\SubProgramPage.xaml"
            this.CopySubProgram.Click += new System.Windows.RoutedEventHandler(this.CopySubProgram_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EditSubProgram = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\Pages\SubProgramPage.xaml"
            this.EditSubProgram.Click += new System.Windows.RoutedEventHandler(this.CopySubProgram_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteSubProgram = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Pages\SubProgramPage.xaml"
            this.DeleteSubProgram.Click += new System.Windows.RoutedEventHandler(this.DeleteSubProgram_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AreasFilterComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 108 "..\..\..\Pages\SubProgramPage.xaml"
            this.AreasFilterComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AreasFilterComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AreasFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 125 "..\..\..\Pages\SubProgramPage.xaml"
            this.AreasFilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.AreasFilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DataGridSub = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            
            #line 174 "..\..\..\Pages\SubProgramPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseEdChangeClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ProgramsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.Area1TypeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            
            #line 199 "..\..\..\Pages\SubProgramPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CommitButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

