﻿#pragma checksum "..\..\AddEmployeeForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43D06470BB647D44B98AECB5FFBF67EEACC2919D377D9CC364C67E8E3D8EBB69"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Lesson5;
using Lesson5_Wpf001.Control;
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


namespace Lesson5 {
    
    
    /// <summary>
    /// AddEmployeeForm
    /// </summary>
    public partial class AddEmployeeForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AddEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox addDepartmentComboBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addFIOTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addMailTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Lesson5_Wpf001.Control.GenderControl userGenderControls;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker addBirthdayDatePicker;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button yesButtonForm;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button noButtonForm;
        
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
            System.Uri resourceLocater = new System.Uri("/Lesson5;component/addemployeeform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEmployeeForm.xaml"
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
            this.addDepartmentComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.addFIOTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.addMailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.userGenderControls = ((Lesson5_Wpf001.Control.GenderControl)(target));
            return;
            case 5:
            this.addBirthdayDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.yesButtonForm = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AddEmployeeForm.xaml"
            this.yesButtonForm.Click += new System.Windows.RoutedEventHandler(this.yesButtonForm_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.noButtonForm = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\AddEmployeeForm.xaml"
            this.noButtonForm.Click += new System.Windows.RoutedEventHandler(this.noButtonForm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

