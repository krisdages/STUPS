﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 9/3/2012
 * Time: 11:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TMX
{
    
    using System;
    using System.Management.Automation;
    
    /// <summary>
    /// Description of TestBucketCmdletBase.
    /// </summary>
    public class TestBucketCmdletBase : TestStructureCmdletBase //DatabaseCmdletBase
    {
        public TestBucketCmdletBase()
        {
        }
        
        #region Parameters
        [Parameter(Mandatory = false)]
        public string[] BucketName { get; set; }
        
        [Parameter(Mandatory = false)]
        public IDatabase InputObject { get; set; }
        #endregion Parameters
        
        protected bool checkDatabaseInput(IDatabase database)
        {
            bool result = false;
            
            
            
            result = true;
            
            return result;
        }
    }
}
