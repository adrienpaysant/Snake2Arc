﻿#pragma checksum "..\..\GameWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87C95C3409B62C9F40518EFAF21236E85D36DF9C809C44D55DC388171C1C938D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Snake2Arc;
using System;
using System.ComponentModel;
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


namespace Snake2Arc {
    
    
    /// <summary>
    /// GameWindow
    /// </summary>
    public partial class GameWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox mainViewBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock scoreBoard;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox viewBoxCanvas;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas paintCanvas;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border mainMenu;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border leaderBoard;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border addNewScore;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox playerNameAdded;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_add_new_score;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border gameOver1Player;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock score;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border pauseMenu;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border optionMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/Snake2Arc;component/gamewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GameWindow.xaml"
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
            this.mainViewBox = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 2:
            this.scoreBoard = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.viewBoxCanvas = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 4:
            this.paintCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.mainMenu = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            
            #line 38 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Play_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 39 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Play_Double_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 40 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_LeaderBoard_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 41 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Options_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 42 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnCloseClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.leaderBoard = ((System.Windows.Controls.Border)(target));
            return;
            case 12:
            
            #line 58 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_return_menu_click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.addNewScore = ((System.Windows.Controls.Border)(target));
            return;
            case 14:
            this.playerNameAdded = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.button_add_new_score = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\GameWindow.xaml"
            this.button_add_new_score.Click += new System.Windows.RoutedEventHandler(this.Add_new_score);
            
            #line default
            #line hidden
            return;
            case 16:
            this.gameOver1Player = ((System.Windows.Controls.Border)(target));
            return;
            case 17:
            this.score = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 18:
            
            #line 72 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_return_menu_click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.pauseMenu = ((System.Windows.Controls.Border)(target));
            return;
            case 20:
            
            #line 78 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_resume_click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 79 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_leave_click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.optionMenu = ((System.Windows.Controls.Border)(target));
            return;
            case 23:
            
            #line 87 "..\..\GameWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_return_menu_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

