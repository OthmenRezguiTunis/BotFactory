﻿#pragma checksum "..\..\..\Pages\FactoryTest.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2689EB9624C5F92988DCAA52D23802EF8352249E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using BotFactory.Pages;
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


namespace BotFactory.Pages {
    
    
    /// <summary>
    /// FactoryTest
    /// </summary>
    public partial class FactoryTest : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\..\Pages\FactoryTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView StorageList;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Pages\FactoryTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ModelsList;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Pages\FactoryTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UnitName;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\Pages\FactoryTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddUnitToQueue;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Pages\FactoryTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame UnitFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/BotFactory;component/pages/factorytest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\FactoryTest.xaml"
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
            this.StorageList = ((System.Windows.Controls.ListView)(target));
            
            #line 68 "..\..\..\Pages\FactoryTest.xaml"
            this.StorageList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.StorageList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ModelsList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 97 "..\..\..\Pages\FactoryTest.xaml"
            this.ModelsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ModelsList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UnitName = ((System.Windows.Controls.TextBox)(target));
            
            #line 135 "..\..\..\Pages\FactoryTest.xaml"
            this.UnitName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.UnitName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddUnitToQueue = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\..\Pages\FactoryTest.xaml"
            this.AddUnitToQueue.Click += new System.Windows.RoutedEventHandler(this.AddUnitToQueue_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UnitFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

