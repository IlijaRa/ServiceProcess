﻿#pragma checksum "..\..\..\Repairer\SendNotification-Repairer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9CB64EAB1CB5BF70620F9F7981C22E36F5E27CA17668A7FCC40A91709EC2AC9F"
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
    /// SendNotification_Repairer
    /// </summary>
    public partial class SendNotification_Repairer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Repairer\SendNotification-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_to;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Repairer\SendNotification-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_subject;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Repairer\SendNotification-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_message;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Repairer\SendNotification-Repairer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_choose_bill;
        
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
            System.Uri resourceLocater = new System.Uri("/ServiceProcess;component/repairer/sendnotification-repairer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Repairer\SendNotification-Repairer.xaml"
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
            
            #line 14 "..\..\..\Repairer\SendNotification-Repairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Profile);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\Repairer\SendNotification-Repairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_FindClient);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_to = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_subject = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_message = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 26 "..\..\..\Repairer\SendNotification-Repairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Send);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 27 "..\..\..\Repairer\SendNotification-Repairer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_GoBack);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cb_choose_bill = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

