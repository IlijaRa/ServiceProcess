﻿#pragma checksum "..\..\..\Repairer\Homepage-Repairer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "65EB0D0B3DC626E38BD2930225527FE88518E775D22AD2EAC88A5BC6E23DA06A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ServiceProcess;
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


namespace ServiceProcess {
    
    
    /// <summary>
    /// Homepage_Repairer
    /// </summary>
    public partial class Homepage_Repairer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Repairer\Homepage-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_name;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Repairer\Homepage-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_surname;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Repairer\Homepage-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_email;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Repairer\Homepage-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_longevity;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Repairer\Homepage-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_birthday;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Repairer\Homepage-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_role;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Repairer\Homepage-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_working_on;
        
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
            System.Uri resourceLocater = new System.Uri("/ServiceProcess;component/repairer/homepage-repairer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Repairer\Homepage-Repairer.xaml"
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
            
            #line 18 "..\..\..\Repairer\Homepage-Repairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_FindClient);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\..\Repairer\Homepage-Repairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_WriteReport);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_surname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tb_longevity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tb_birthday = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tb_role = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.dg_working_on = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            
            #line 40 "..\..\..\Repairer\Homepage-Repairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_GenerateBill);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

