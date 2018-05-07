﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace HB_INSTALL_AUTO
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BackupSystem recording.
    /// </summary>
    [TestModule("9989c876-1438-4146-908f-573b9db14d53", ModuleType.Recording, 1)]
    public partial class BackupSystem : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static BackupSystem instance = new BackupSystem();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BackupSystem()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BackupSystem Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.FileTab' at Center.", repo.HeavyBidTabs.FileTabInfo, new RecordItemIndex(0));
            repo.HeavyBidTabs.FileTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.ButtonBackupEstimate' at Center.", repo.HeavyBidTabs.ButtonBackupEstimateInfo, new RecordItemIndex(1));
            repo.HeavyBidTabs.ButtonBackupEstimate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBButtonDropdownOptions.System' at Center.", repo.HBButtonDropdownOptions.SystemInfo, new RecordItemIndex(2));
            repo.HBButtonDropdownOptions.System.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BackupEstimate.ButtonFinish' at Center.", repo.BackupEstimate.ButtonFinishInfo, new RecordItemIndex(3));
            repo.BackupEstimate.ButtonFinish.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HCSSBackupExists.ButtonYes' at Center.", repo.HCSSBackupExists.ButtonYesInfo, new RecordItemIndex(4));
                repo.HCSSBackupExists.ButtonYes.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
