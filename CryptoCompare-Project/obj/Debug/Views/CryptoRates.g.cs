﻿#pragma checksum "..\..\..\Views\CryptoRates.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "246B208AA68A88F6325F60758CB4721C8F2FED881AA62873D6CC45D23B6AC3EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ScottPlot;
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


namespace CryptoCompare_Project.Views {
    
    
    /// <summary>
    /// CryptoRates
    /// </summary>
    public partial class CryptoRates : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\Views\CryptoRates.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Crypto1;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\CryptoRates.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Crypto2;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Views\CryptoRates.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Period;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\CryptoRates.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ScottPlot.WpfPlot WpfPlot1;
        
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
            System.Uri resourceLocater = new System.Uri("/CryptoCompare_Project;component/views/cryptorates.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CryptoRates.xaml"
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
            this.Crypto1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 63 "..\..\..\Views\CryptoRates.xaml"
            this.Crypto1.DropDownClosed += new System.EventHandler(this.Crypto1_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Crypto2 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 77 "..\..\..\Views\CryptoRates.xaml"
            this.Crypto2.DropDownClosed += new System.EventHandler(this.Crypto2_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Period = ((System.Windows.Controls.ComboBox)(target));
            
            #line 91 "..\..\..\Views\CryptoRates.xaml"
            this.Period.DropDownClosed += new System.EventHandler(this.Period_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WpfPlot1 = ((ScottPlot.WpfPlot)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

