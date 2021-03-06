﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 08.12.2011
 * Time: 9:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomationTestForms
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Description of WinFormsMaximized.
    /// </summary>
    public partial class WinFormsMaximized : WinFormsForm // Form
    {
//        public WinFormsMaximized(
//            System.Windows.Automation.ControlType controlType,
//            int controlDelay)
//        {
//            this.ControlType = controlType;
//            this.ControlDelay = controlDelay;
//            //  // The InitializeComponent() call is required for Windows Forms designer support.
//            // 
//            InitializeComponent();
//            
//            //  // TODO: Add constructor code after the InitializeComponent() call.
//            // 
//        }

        public WinFormsMaximized(
            System.Windows.Automation.ControlType controlType,
            int controlDelay) : base ("WinFormsMaximized", "WinFormsMaximized", controlType, controlDelay)
        {
            base.ChildForm = this;
        }
        
        public WinFormsMaximized(
            System.Windows.Automation.ControlType controlType,
            string controlName,
            string controlAutomationId,
            int controlDelay) : base ("WinFormsMaximized", "WinFormsMaximized", controlType, controlName, controlAutomationId, controlDelay)
        {
            base.ChildForm = this;
        }
        
        public WinFormsMaximized(
            ControlToForm[] controls) : base ("WinFormsMaximized", "WinFormsMaximized", controls)
        {
            base.ChildForm = this;
        }        
    }
}
