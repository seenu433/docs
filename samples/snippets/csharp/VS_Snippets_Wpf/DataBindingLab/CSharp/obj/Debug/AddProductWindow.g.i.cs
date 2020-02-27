﻿#pragma checksum "..\..\AddProductWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "159DAD33F2EB20F3626F1F4C145E5C4570AF040C77284E09B3E67EA6F46486D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DataBindingLab;
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


namespace DataBindingLab {
    
    
    /// <summary>
    /// AddProductWindow
    /// </summary>
    public partial class AddProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionEntryForm;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StartPriceEntryForm;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StartDateEntryForm;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryEntryForm;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SpecialFeaturesEntryForm;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ShortPreview;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl LongPreview;
        
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
            System.Uri resourceLocater = new System.Uri("/DataBindingLab;component/addproductwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddProductWindow.xaml"
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
            
            #line 8 "..\..\AddProductWindow.xaml"
            ((DataBindingLab.AddProductWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnInit);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DescriptionEntryForm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.StartPriceEntryForm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.StartDateEntryForm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CategoryEntryForm = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.SpecialFeaturesEntryForm = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Submit = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\AddProductWindow.xaml"
            this.Submit.Click += new System.Windows.RoutedEventHandler(this.SubmitProduct);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ShortPreview = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 9:
            this.LongPreview = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

