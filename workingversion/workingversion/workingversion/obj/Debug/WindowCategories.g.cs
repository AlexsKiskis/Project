﻿#pragma checksum "..\..\WindowCategories.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D915FF0706F7A2A11F2BF8ED53BD019A47E9A5FC16A9F22B91ED17ADAFC2F96F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using workingversion;


namespace workingversion {
    
    
    /// <summary>
    /// WindowCategories
    /// </summary>
    public partial class WindowCategories : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 97 "..\..\WindowCategories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid brow;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\WindowCategories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ToolBar;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\WindowCategories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MinButton;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\WindowCategories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MaxButton;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\WindowCategories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image NormalButton;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\WindowCategories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ExitButton;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\WindowCategories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LogoContainer;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\WindowCategories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid border0;
        
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
            System.Uri resourceLocater = new System.Uri("/workingversion;component/windowcategories.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowCategories.xaml"
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
            this.brow = ((System.Windows.Controls.Grid)(target));
            
            #line 97 "..\..\WindowCategories.xaml"
            this.brow.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ToolBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ToolBar = ((System.Windows.Controls.Grid)(target));
            
            #line 101 "..\..\WindowCategories.xaml"
            this.ToolBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ToolBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MinButton = ((System.Windows.Controls.Image)(target));
            
            #line 105 "..\..\WindowCategories.xaml"
            this.MinButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MinButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MaxButton = ((System.Windows.Controls.Image)(target));
            
            #line 120 "..\..\WindowCategories.xaml"
            this.MaxButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MaxButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NormalButton = ((System.Windows.Controls.Image)(target));
            
            #line 136 "..\..\WindowCategories.xaml"
            this.NormalButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NormalButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ExitButton = ((System.Windows.Controls.Image)(target));
            
            #line 151 "..\..\WindowCategories.xaml"
            this.ExitButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ExitButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LogoContainer = ((System.Windows.Controls.Grid)(target));
            
            #line 171 "..\..\WindowCategories.xaml"
            this.LogoContainer.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.LogoContainer_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.border0 = ((System.Windows.Controls.Grid)(target));
            
            #line 178 "..\..\WindowCategories.xaml"
            this.border0.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ToolBar_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

