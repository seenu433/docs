﻿#pragma checksum "..\..\Pane1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "33D99D78945F163D9B8BA8FBDCCB8D4FB8832FFD4EE0B58B5B2A6705F21B3F75"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace ButtonAlign {
    
    
    /// <summary>
    /// Pane1
    /// </summary>
    public partial class Pane1 : System.Windows.Controls.Canvas, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn2;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn3;
        
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
            System.Uri resourceLocater = new System.Uri("/ButtonAlign;component/pane1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Pane1.xaml"
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
            this.btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Pane1.xaml"
            this.btn1.Click += new System.Windows.RoutedEventHandler(this.OnClick1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn2 = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Pane1.xaml"
            this.btn2.Click += new System.Windows.RoutedEventHandler(this.OnClick2);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn3 = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Pane1.xaml"
            this.btn3.Click += new System.Windows.RoutedEventHandler(this.OnClick3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

