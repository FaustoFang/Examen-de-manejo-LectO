﻿#pragma checksum "..\..\..\Pages\Pag Terminar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8DAA5C8FD5F31262CB085BC183462FE8805CA96D44546B2F7EF35DD07D3299CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Examen_de_manejo_LectO.Pages;
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


namespace Examen_de_manejo_LectO.Pages {
    
    
    /// <summary>
    /// Pag_Terminar
    /// </summary>
    public partial class Pag_Terminar : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\Pages\Pag Terminar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreApellido;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\Pag Terminar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDocumento;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Pages\Pag Terminar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolverAtras;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Pages\Pag Terminar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTerminar;
        
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
            System.Uri resourceLocater = new System.Uri("/Examen de manejo LectO;component/pages/pag%20terminar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Pag Terminar.xaml"
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
            this.txtNombreApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtDocumento = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnVolverAtras = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\Pages\Pag Terminar.xaml"
            this.btnVolverAtras.Click += new System.Windows.RoutedEventHandler(this.btnVolverAtras_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnTerminar = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\Pages\Pag Terminar.xaml"
            this.btnTerminar.Click += new System.Windows.RoutedEventHandler(this.btnTerminar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

