﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 2/23/2012
 * Time: 3:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation.Commands
{
    using System;
    using System.Management.Automation;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Description of InvokeUIAWizardCommand.
    /// </summary>
    [Cmdlet(VerbsLifecycle.Invoke, "UIAWizard")]
    public class InvokeUIAWizardCommand : WizardRunCmdletBase
    {
        public InvokeUIAWizardCommand()
        {
        }
        
        #region Parameters
//        [Parameter(Mandatory = false)]
//        internal new Wizard InputObject { get; set; }
//        
//        // 20130317
//        [Parameter(Mandatory = false)]
//        public SwitchParameter Automatic { get; set; }
//        
//        // 20130317
//        [Parameter(Mandatory = false)]
//        public SwitchParameter ForwardDirection { get; set; }
        #endregion Parameters
        
        protected override void BeginProcessing()
        {
            if (null != this.Parameters && 0 < this.Parameters.Length) {

                foreach (Hashtable parametersTable in this.Parameters) {

                    Dictionary<string, object> dict =
                        this.ConvertHashtableToDictionary(parametersTable);

                    this.ParametersDictionaries.Add(dict);
                }
            }

        	UIAInvokeWizardCommand command =
        		new UIAInvokeWizardCommand(this);
        	command.Execute();
        }
    }
}
