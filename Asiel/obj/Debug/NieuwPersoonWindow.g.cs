﻿#pragma checksum "..\..\NieuwPersoonWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B1677F37A9FFE82F16023C132D58D3CB"
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
    /// NieuwPersoonWindow
    /// </summary>
    public partial class NieuwPersoonWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\NieuwPersoonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNaam;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\NieuwPersoonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtAchternaam;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\NieuwPersoonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtStraatHuisNr;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\NieuwPersoonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPostcode;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\NieuwPersoonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtWoonplaats;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\NieuwPersoonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtTelefoon;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\NieuwPersoonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpslaan;
        
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
            System.Uri resourceLocater = new System.Uri("/Asiel;component/nieuwpersoonwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NieuwPersoonWindow.xaml"
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
            this.TxtAchternaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtStraatHuisNr = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtPostcode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtWoonplaats = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxtTelefoon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnOpslaan = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\NieuwPersoonWindow.xaml"
            this.btnOpslaan.Click += new System.Windows.RoutedEventHandler(this.btnOpslaan_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
