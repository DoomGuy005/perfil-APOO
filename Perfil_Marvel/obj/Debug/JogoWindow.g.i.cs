﻿#pragma checksum "..\..\JogoWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0927E4E7881541B54AEBA847308A93E8CE7E9AEA"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Perfil_Marvel;
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


namespace Perfil_Marvel {
    
    
    /// <summary>
    /// JogoWindow
    /// </summary>
    public partial class JogoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\JogoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pJ1;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\JogoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pJ2;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\JogoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pJ3;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\JogoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pJ4;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\JogoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lJogadorVez;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\JogoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPalpite;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\JogoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDica;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\JogoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDica;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\JogoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPalpite;
        
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
            System.Uri resourceLocater = new System.Uri("/Perfil_Marvel;component/jogowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\JogoWindow.xaml"
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
            this.pJ1 = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.pJ2 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.pJ3 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.pJ4 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lJogadorVez = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnPalpite = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\JogoWindow.xaml"
            this.btnPalpite.Click += new System.Windows.RoutedEventHandler(this.btnPalpite_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDica = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\JogoWindow.xaml"
            this.btnDica.Click += new System.Windows.RoutedEventHandler(this.btnDica_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtDica = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtPalpite = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
