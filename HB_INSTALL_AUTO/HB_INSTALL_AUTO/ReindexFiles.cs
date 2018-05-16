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
    ///The ReindexFiles recording.
    /// </summary>
    [TestModule("f248ff38-1a5d-46a7-b8f1-436a46ab7a69", ModuleType.Recording, 1)]
    public partial class ReindexFiles : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static ReindexFiles instance = new ReindexFiles();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReindexFiles()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReindexFiles Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.ToolsTab' at Center.", repo.HeavyBidApp.Tabs.ToolsTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.ToolsTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.Tools.ReindexFilesButton' at Center.", repo.HeavyBidApp.Buttons.Tools.ReindexFilesButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.Tools.ReindexFilesButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'ReindexScreen.CurrentEstimateCheckbox'.", repo.ReindexScreen.CurrentEstimateCheckboxInfo, new RecordItemIndex(2));
            repo.ReindexScreen.CurrentEstimateCheckbox.Element.SetAttributeValue("Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'ReindexScreen.SystemFilesCheckbox'.", repo.ReindexScreen.SystemFilesCheckboxInfo, new RecordItemIndex(3));
            repo.ReindexScreen.SystemFilesCheckbox.Element.SetAttributeValue("Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReindexScreen.ButtonOk' at Center.", repo.ReindexScreen.ButtonOkInfo, new RecordItemIndex(4));
            repo.ReindexScreen.ButtonOk.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ReindexWarningScreen.ButtonOk' at Center.", repo.ReindexWarningScreen.ButtonOkInfo, new RecordItemIndex(5));
                repo.ReindexWarningScreen.ButtonOk.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(6));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}'.", new RecordItemIndex(7));
            Keyboard.Press("{Escape}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
