﻿#pragma checksum "..\..\..\InCommon\MessageToClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83210B02D8CDF07E2921D08223A37CB8580F46AA7B6B82220FF99426D8208E6A"
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
    /// MessageToClient_MainRepairer
    /// </summary>
    public partial class MessageToClient_MainRepairer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\InCommon\MessageToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_to;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\InCommon\MessageToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_subject;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\InCommon\MessageToClient.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ServiceProcess;component/incommon/messagetoclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\InCommon\MessageToClient.xaml"
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
            
            #line 14 "..\..\..\InCommon\MessageToClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Profile);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\InCommon\MessageToClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClientRequests);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\..\InCommon\MessageToClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_RequestsInProgress);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 17 "..\..\..\InCommon\MessageToClient.xaml"
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
            
            #line 28 "..\..\..\InCommon\MessageToClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_SendMessage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

