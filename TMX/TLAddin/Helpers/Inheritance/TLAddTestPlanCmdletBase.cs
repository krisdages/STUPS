﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/14/2013
 * Time: 12:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TMX
{
    using System;
    using System.Management.Automation;
    
    /// <summary>
    /// Description of TLAddTestPlanCmdletBase.
    /// </summary>
    public class TLAddTestPlanCmdletBase : TLTestPlanCmdletBase
    {
        public TLAddTestPlanCmdletBase()
        {
        }
        
        #region Parameters
        [Parameter(Mandatory = false,
                   Position = 0,
                   ParameterSetName = "PipelineInput")]
        [Parameter(Mandatory = false,
                   Position = 0,
                   ParameterSetName = "StringInput")]
        [Parameter(Mandatory = false,
                   Position = 0,
                   ParameterSetName = "FromStore")]
        public string TestPlanName { get; set; }
        
        // 20130202
        [Parameter(Mandatory = false,
                   ParameterSetName = "PipelineInput")]
        [Parameter(Mandatory = false,
                   ParameterSetName = "StringInput")]
        [Parameter(Mandatory = false,
                   ParameterSetName = "FromStore")]
        public string Description { get; set; }
        
        [Parameter(Mandatory = false,
                   ParameterSetName = "PipelineInput")]
        [Parameter(Mandatory = false,
                   ParameterSetName = "StringInput")]
        [Parameter(Mandatory = false,
                   ParameterSetName = "FromStore")]
        public SwitchParameter Active { get; set; }
        #endregion Parameters
    }
}
