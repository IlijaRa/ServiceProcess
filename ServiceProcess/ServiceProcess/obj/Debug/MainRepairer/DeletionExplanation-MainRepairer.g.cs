﻿#pragma checksum "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A6E195C33F5EA4A93A6C5AEFEE8C52508E363F05C080B0F8C354116C2525F1A8"
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
    /// DeletionExplanation
    /// </summary>
    public partial class DeletionExplanation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_to;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_subject;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_message;
        
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
            System.Uri resourceLocater = new System.Uri("/ServiceProcess;component/mainrepairer/deletionexplanation-mainrepairer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
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
            
            #line 14 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Profile);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClientRequests);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_RequestsInProgress);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 17 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_FinishedRequests);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_to = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tb_subject = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tb_message = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 28 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Send);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 29 "..\..\..\MainRepairer\DeletionExplanation-MainRepairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_GoBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

