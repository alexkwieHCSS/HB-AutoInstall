/*
 * Created by Ranorex
 * User: alex.kwie
 * Date: 5/16/2018
 * Time: 11:33 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace HB_INSTALL_AUTO
{
    /// <summary>
    /// Description of CheckShowRibbon.
    /// </summary>
    [TestModule("56567AE5-7CEC-47E0-92FD-9AB10CD77CCD", ModuleType.UserCode, 1)]
    public class CheckShowRibbon : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckShowRibbon()
        {
        	
        	var repo = HB_INSTALL_AUTORepository.Instance;
          //  var showRibbonBar = repo.HBButtonDropdownOptions.ShowRibbonBar;
            
            // Do not delete - a parameterless constructor is required!
            if(Validate.Attribute(repo.HBButtonDropdownOptions.ShowRibbonBar, "Checked", false, "Ribbon has been checked", false))            
            	{         	
            		repo.HBButtonDropdownOptions.ShowRibbonBar.Click();
            	}
            else
	            {
            		repo.HeavyBidApp.HCSSIcon.Click();
	            }
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
