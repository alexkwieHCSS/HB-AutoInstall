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
    ///The ConfirmHBInstallFinish recording.
    /// </summary>
    [TestModule("b3a23dda-b9ca-485f-965b-05d9979d93ac", ModuleType.Recording, 1)]
    public partial class ConfirmHBInstallFinish : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static ConfirmHBInstallFinish instance = new ConfirmHBInstallFinish();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfirmHBInstallFinish()
        {
            YearVersion = "2018.1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfirmHBInstallFinish Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable YearVersion.
        /// </summary>
        [TestVariable("ab7f70f2-343b-412f-a8f5-befaf3a689af")]
        public string YearVersion
        {
            get { return repo.YearVersion; }
            set { repo.YearVersion = value; }
        }

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

            // B.3
            Report.Log(ReportLevel.Info, "Validation", "B.3\r\nValidating AttributeRegEx (Text~'[HeavyBid][Setup]') on item 'HeavyBidServerSetup.ServerInstallTitle'.", repo.HeavyBidServerSetup.ServerInstallTitleInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.HeavyBidServerSetup.ServerInstallTitleInfo, "Text", new Regex("[HeavyBid][Setup]"));
            Delay.Milliseconds(0);
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegEx (Text~$YearVersion) on item 'HeavyBidServerSetup.ServerInstallTitle'.", repo.HeavyBidServerSetup.ServerInstallTitleInfo, new RecordItemIndex(1));
                Validate.Attribute(repo.HeavyBidServerSetup.ServerInstallTitleInfo, "Text", new Regex(YearVersion), Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'HeavyBidServerSetup.ButtonInstall'", repo.HeavyBidServerSetup.ButtonInstallInfo, new ActionTimeout(60000), new RecordItemIndex(2));
            repo.HeavyBidServerSetup.ButtonInstallInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.ButtonInstall' at Center.", repo.HeavyBidServerSetup.ButtonInstallInfo, new RecordItemIndex(3));
            repo.HeavyBidServerSetup.ButtonInstall.Click();
            Delay.Milliseconds(200);
            
            // B.10
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.10\r\nValidating AttributeRegEx (Text~'[HeavyBid][Setup]') on item 'HeavyBidServerSetup.ServerInstallTitle'.", repo.HeavyBidServerSetup.ServerInstallTitleInfo, new RecordItemIndex(4));
                Validate.Attribute(repo.HeavyBidServerSetup.ServerInstallTitleInfo, "Text", new Regex("[HeavyBid][Setup]"), Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // B.10
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.10\r\nValidating AttributeRegEx (Text~$YearVersion) on item 'HeavyBidServerSetup.ServerInstallTitle'.", repo.HeavyBidServerSetup.ServerInstallTitleInfo, new RecordItemIndex(5));
                Validate.Attribute(repo.HeavyBidServerSetup.ServerInstallTitleInfo, "Text", new Regex(YearVersion), Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15m to exist. Associated repository item: 'HeavyBidServerSetup.ButtonFinish'", repo.HeavyBidServerSetup.ButtonFinishInfo, new ActionTimeout(900000), new RecordItemIndex(6));
            repo.HeavyBidServerSetup.ButtonFinishInfo.WaitForExists(900000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.ButtonFinish' at Center.", repo.HeavyBidServerSetup.ButtonFinishInfo, new RecordItemIndex(7));
            repo.HeavyBidServerSetup.ButtonFinish.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
