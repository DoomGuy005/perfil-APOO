﻿#pragma checksum "..\..\..\Visão\Jogo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BF6634888398C6B5E758E4AC0783B3C7F7BD8FAB"
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


namespace Perfil_Marvel.Visão {
    
    
    /// <summary>
    /// JogoWindow
    /// </summary>
    public partial class JogoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Visão\Jogo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVoltar;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Visão\Jogo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pJ1;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Visão\Jogo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pJ2;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Visão\Jogo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pJ3;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Visão\Jogo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pJ4;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Visão\Jogo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lJogadorVez;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Visão\Jogo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPalpite;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Visão\Jogo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDica;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Visão\Jogo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDica;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Visão\Jogo.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Perfil_Marvel;component/vis%c3%a3o/jogo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Visão\Jogo.xaml"
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
            this.btnVoltar = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Visão\Jogo.xaml"
            this.btnVoltar.Click += new System.Windows.RoutedEventHandler(this.btnVoltar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pJ1 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.pJ2 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.pJ3 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.pJ4 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lJogadorVez = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btnPalpite = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Visão\Jogo.xaml"
            this.btnPalpite.Click += new System.Windows.RoutedEventHandler(this.btnPalpite_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnDica = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\Visão\Jogo.xaml"
            this.btnDica.Click += new System.Windows.RoutedEventHandler(this.btnDica_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtDica = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtPalpite = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

