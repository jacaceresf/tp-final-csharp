﻿#pragma checksum "..\..\w_Marca.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC455853B10BDC519786C4D6E36B7AD2F1FD69875C40E4CBF7E955B6519625CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MiAuto0KmWPF;
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


namespace MiAuto0KmWPF {
    
    
    /// <summary>
    /// w_Marca
    /// </summary>
    public partial class w_Marca : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\w_Marca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\w_Marca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\w_Marca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\w_Marca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgMarcas;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\w_Marca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLimpiar;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\w_Marca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\w_Marca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\w_Marca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
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
            System.Uri resourceLocater = new System.Uri("/MiAuto0KmWPF;component/w_marca.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\w_Marca.xaml"
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
            
            #line 8 "..\..\w_Marca.xaml"
            ((MiAuto0KmWPF.w_Marca)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dgMarcas = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\w_Marca.xaml"
            this.dgMarcas.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgMarcas_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 32 "..\..\w_Marca.xaml"
            this.dgMarcas.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgMarcas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnLimpiar = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\w_Marca.xaml"
            this.btnLimpiar.Click += new System.Windows.RoutedEventHandler(this.btnLimpiar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\w_Marca.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\w_Marca.xaml"
            this.btnModificar.Click += new System.Windows.RoutedEventHandler(this.btnModificar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\w_Marca.xaml"
            this.btnGuardar.Click += new System.Windows.RoutedEventHandler(this.btnGuardar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

