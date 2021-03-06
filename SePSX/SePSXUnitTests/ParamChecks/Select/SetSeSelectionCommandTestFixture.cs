﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 2012-08-03
 * Time: 05:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSXUnitTests.CheckCmdletParameters
{
    using System;
    using SePSX; using MbUnit.Framework;
    using OpenQA.Selenium;
    //using OpenQA.Selenium.Support.UI;
    
    /// <summary>
    /// Description of SetSeSelectionCommand.
    /// </summary>
    [TestFixture]
    public class SetSeSelectionCommand_ParamCheck
    {
        public SetSeSelectionCommand_ParamCheck()
        {
        }
        
        [SetUp]
        public void PrepareRunspace()
        {
            MiddleLevelCode.PrepareRunspaceForParamChecks();
        }
        
        [TearDown]
        public void DisposeRunspace()
        {
            // MiddleLevelCode.DisposeRunspace(); // 20121226
        }
        
//        [Test]
//        [Category("Fast")]
//        public void InputObject_NoParameters() // this should not work
//        {
//            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters(
//                "Set-SeSelection -InputObject $null;");
//        }
        
        [Test]
        [Category("Fast")]
        public void SetSeSelection_InputObject_Index()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Set-SeSelection -InputObject $null -Index 1;");
        }
        
        [Test]
        [Category("Fast")]
        public void SetSeSelection_InputObject_Value()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Set-SeSelection -InputObject $null -Value 'aaa';");
        }
        
        [Test]
        [Category("Fast")]
        public void SetSeSelection_InputObject_VisibleText()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Set-SeSelection -InputObject $null -VisibleText 'bbb';");
        }
        
        [Test]
        [Category("Fast")]
        public void SetSeSelection_InputObject_All()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Set-SeSelection -InputObject $null -All;");
        }
        
        [Test]
        [Category("Fast")]
        public void SetSeSelection_InputObject_Index_Deselect()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Set-SeSelection -InputObject $null -Index 1 -Deselect;");
        }
        
        [Test]
        [Category("Fast")]
        public void SetSeSelection_InputObject_Value_Deselect()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Set-SeSelection -InputObject $null -Value 'aaa' -Deselect;");
        }
        
        [Test]
        [Category("Fast")]
        public void SetSeSelection_InputObject_VisibleText_Deselect()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Set-SeSelection -InputObject $null -VisibleText 'bbb' -Deselect;");
        }
        
        [Test]
        [Category("Fast")]
        public void SetSeSelection_InputObject_All_Deselect()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Set-SeSelection -InputObject $null -All -Deselect;");
        }
        
        [Test]
        [Category("Fast")]
        public void SetSeSelection_NoInputObject_Index()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Set-SeSelection -Index 1;");
        }
    }
}
