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
    ///The UninstallCrystal recording.
    /// </summary>
    [TestModule("ae8f2f05-5ac9-49af-81aa-e73092f6bb8d", ModuleType.Recording, 1)]
    public partial class UninstallCrystal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static UninstallCrystal instance = new UninstallCrystal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UninstallCrystal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UninstallCrystal Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'ProgramsAndFeatures.SearchEditBox'", repo.ProgramsAndFeatures.SearchEditBoxInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.ProgramsAndFeatures.SearchEditBoxInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProgramsAndFeatures.SearchEditBox' at Center.", repo.ProgramsAndFeatures.SearchEditBoxInfo, new RecordItemIndex(1));
            repo.ProgramsAndFeatures.SearchEditBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'hcss{Space}integration' with focus on 'ProgramsAndFeatures.SearchEditBox'.", repo.ProgramsAndFeatures.SearchEditBoxInfo, new RecordItemIndex(2));
            repo.ProgramsAndFeatures.SearchEditBox.PressKeys("hcss{Space}integration");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegration'", repo.ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegrationInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegrationInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegration' at Center.", repo.ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegrationInfo, new RecordItemIndex(4));
            repo.ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegration.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ProgramsAndFeatures.Buttons.ButtonUninstall'", repo.ProgramsAndFeatures.Buttons.ButtonUninstallInfo, new ActionTimeout(10000), new RecordItemIndex(5));
            repo.ProgramsAndFeatures.Buttons.ButtonUninstallInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProgramsAndFeatures.Buttons.ButtonUninstall' at Center.", repo.ProgramsAndFeatures.Buttons.ButtonUninstallInfo, new RecordItemIndex(6));
            repo.ProgramsAndFeatures.Buttons.ButtonUninstall.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ProgramsAndFeatures.Buttons.ButtonYes'", repo.ProgramsAndFeatures.Buttons.ButtonYesInfo, new ActionTimeout(10000), new RecordItemIndex(7));
            repo.ProgramsAndFeatures.Buttons.ButtonYesInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProgramsAndFeatures.Buttons.ButtonYes' at Center.", repo.ProgramsAndFeatures.Buttons.ButtonYesInfo, new RecordItemIndex(8));
            repo.ProgramsAndFeatures.Buttons.ButtonYes.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
