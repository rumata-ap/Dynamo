﻿#pragma checksum "Views\Core\WorkspaceView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212848FE90467B08929A753E9297D0606BA11D1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dynamo.Controls;
using Dynamo.UI.Controls;
using Dynamo.ViewModels;
using Dynamo.Views;
using Dynamo.Wpf.Properties;
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


namespace Dynamo.Views {
    
    
    /// <summary>
    /// WorkspaceView
    /// </summary>
    public partial class WorkspaceView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 128 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid outerCanvas;
        
        #line default
        #line hidden
        
        
        #line 137 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Dynamo.Controls.InfiniteGridView infiniteGridView;
        
        #line default
        #line hidden
        
        
        #line 148 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Dynamo.Controls.ZoomBorder zoomBorder;
        
        #line default
        #line hidden
        
        
        #line 161 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl WorkspaceElements;
        
        #line default
        #line hidden
        
        
        #line 205 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas selectionCanvas;
        
        #line default
        #line hidden
        
        
        #line 208 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle selectionBox;
        
        #line default
        #line hidden
        
        
        #line 215 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel viewControlPanel;
        
        #line default
        #line hidden
        
        
        #line 221 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel statusBarPanel;
        
        #line default
        #line hidden
        
        
        #line 330 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup InCanvasSearchBar;
        
        #line default
        #line hidden
        
        
        #line 339 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup ContextMenuPopup;
        
        #line default
        #line hidden
        
        
        #line 348 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Dynamo.Controls.ParentMenuItem WorkspaceLacingMenu;
        
        #line default
        #line hidden
        
        
        #line 412 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Dynamo.Controls.ParentMenuItem Align;
        
        #line default
        #line hidden
        
        
        #line 471 "Views\Core\WorkspaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Publish;
        
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
            System.Uri resourceLocater = new System.Uri("/DynamoCoreWpf;component/views/core/workspaceview.xaml", System.UriKind.Relative);
            
            #line 1 "Views\Core\WorkspaceView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 14 "Views\Core\WorkspaceView.xaml"
            ((Dynamo.Views.WorkspaceView)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 15 "Views\Core\WorkspaceView.xaml"
            ((Dynamo.Views.WorkspaceView)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnPreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 16 "Views\Core\WorkspaceView.xaml"
            ((Dynamo.Views.WorkspaceView)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseRelease);
            
            #line default
            #line hidden
            
            #line 17 "Views\Core\WorkspaceView.xaml"
            ((Dynamo.Views.WorkspaceView)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.OnMouseMove);
            
            #line default
            #line hidden
            
            #line 20 "Views\Core\WorkspaceView.xaml"
            ((Dynamo.Views.WorkspaceView)(target)).Drop += new System.Windows.DragEventHandler(this.OnWorkspaceDrop);
            
            #line default
            #line hidden
            return;
            case 3:
            this.outerCanvas = ((System.Windows.Controls.Grid)(target));
            
            #line 130 "Views\Core\WorkspaceView.xaml"
            this.outerCanvas.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnCanvasClicked);
            
            #line default
            #line hidden
            
            #line 131 "Views\Core\WorkspaceView.xaml"
            this.outerCanvas.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnCanvasMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.infiniteGridView = ((Dynamo.Controls.InfiniteGridView)(target));
            return;
            case 5:
            this.zoomBorder = ((Dynamo.Controls.ZoomBorder)(target));
            return;
            case 6:
            this.WorkspaceElements = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 7:
            this.selectionCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 8:
            this.selectionBox = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.viewControlPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            this.statusBarPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.InCanvasSearchBar = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 12:
            this.ContextMenuPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            
            #line 340 "Views\Core\WorkspaceView.xaml"
            this.ContextMenuPopup.Opened += new System.EventHandler(this.OnContextMenuOpened);
            
            #line default
            #line hidden
            return;
            case 13:
            this.WorkspaceLacingMenu = ((Dynamo.Controls.ParentMenuItem)(target));
            return;
            case 14:
            this.Align = ((Dynamo.Controls.ParentMenuItem)(target));
            return;
            case 15:
            
            #line 468 "Views\Core\WorkspaceView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.WorkspacePropertyEditClick);
            
            #line default
            #line hidden
            return;
            case 16:
            this.Publish = ((System.Windows.Controls.MenuItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewKeyDownEvent;
            
            #line 105 "Views\Core\WorkspaceView.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyEventHandler(this.OnInCanvasSearchContextMenuKeyDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseUpEvent;
            
            #line 107 "Views\Core\WorkspaceView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.OnInCanvasSearchContextMenuMouseUp);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseDownEvent;
            
            #line 109 "Views\Core\WorkspaceView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.OnInCanvasSearchContextMenuMouseDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}
