﻿#pragma checksum "..\..\..\Windows\DierInfoWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "384339EB6B37CA836D58B10028A0A150"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Asiel;
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


namespace Asiel {
    
    
    /// <summary>
    /// DierInfoWindow
    /// </summary>
    public partial class DierInfoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Windows\DierInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNaam;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Windows\DierInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateUitgelaten;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\DierInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtInfo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Windows\DierInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBijwerken;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Windows\DierInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDierType;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Windows\DierInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtGeslacht;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\DierInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbPrijs;
        
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
            System.Uri resourceLocater = new System.Uri("/Asiel;component/windows/dierinfowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\DierInfoWindow.xaml"
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
            this.TxtNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DateUitgelaten = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.TxtInfo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnBijwerken = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Windows\DierInfoWindow.xaml"
            this.BtnBijwerken.Click += new System.Windows.RoutedEventHandler(this.BtnBijwerken_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtDierType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxtGeslacht = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TbPrijs = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

