﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 7/19/2012
 * Time: 10:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSX.Commands
{
    using System;
    using System.Management.Automation;
    using OpenQA.Selenium;
    
    /// <summary>
    /// Description of ReadSeWebElementDisplayedCommand.
    /// </summary>
    [Cmdlet(VerbsCommunications.Read, "SeWebElementDisplayed")]
    [OutputType(typeof(bool))]
    public class ReadSeWebElementDisplayedCommand : WebElementCmdletBase
    {
        public ReadSeWebElementDisplayedCommand()
        {
        }
        
        protected override void ProcessRecord()
        {
            this.checkInputWebElementOnly(this.InputObject);
            
            SeReadWebElementDisplayedCommand command =
                new SeReadWebElementDisplayedCommand(this);
            command.Execute();
            //SeHelper.GetWebElementIsDisplayed(this, ((IWebElement[])this.InputObject));
        }
    }
}
