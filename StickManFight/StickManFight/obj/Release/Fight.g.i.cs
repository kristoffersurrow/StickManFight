﻿#pragma checksum "..\..\Fight.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0A9F6800463D51F77F2CD5AA9869C998374F64EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StickManFight;
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


namespace StickManFight {
    
    
    /// <summary>
    /// Fight
    /// </summary>
    public partial class Fight : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Header;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle HPbg1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle HPbg2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle HP1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle HP2;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn2;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image FighterImg1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image FighterImg2;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Fight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OverviewButton;
        
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
            System.Uri resourceLocater = new System.Uri("/StickManFight;component/fight.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Fight.xaml"
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
            this.Header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.HPbg1 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.HPbg2 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.HP1 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.HP2 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.Btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Fight.xaml"
            this.Btn1.Click += new System.Windows.RoutedEventHandler(this.Attack1Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Btn2 = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Fight.xaml"
            this.Btn2.Click += new System.Windows.RoutedEventHandler(this.Attack2Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FighterImg1 = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.FighterImg2 = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.OverviewButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Fight.xaml"
            this.OverviewButton.Click += new System.Windows.RoutedEventHandler(this.OverviewButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
