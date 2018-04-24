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
    ///The VerifyServerVersion recording.
    /// </summary>
    [TestModule("c5579e1d-5544-40dc-acf8-545f36cf39c7", ModuleType.Recording, 1)]
    public partial class VerifyServerVersion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static VerifyServerVersion instance = new VerifyServerVersion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyServerVersion()
        {
            YearVersion = "2018.1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyServerVersion Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable YearVersion.
        /// </summary>
        [TestVariable("4cfee93d-6933-4e82-a63f-0994032a6d7d")]
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'HeavyBidServerSetup'", repo.HeavyBidServerSetup.SelfInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.HeavyBidServerSetup.SelfInfo.WaitForExists(30000);
            
            // B.3
            Report.Log(ReportLevel.Info, "Validation", "B.3\r\nValidating AttributeRegEx (Text~'[HeavyBid][Setup]') on item 'HeavyBidServerSetup.ServerInstallTitle'.", repo.HeavyBidServerSetup.ServerInstallTitleInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.HeavyBidServerSetup.ServerInstallTitleInfo, "Text", new Regex("[HeavyBid][Setup]"));
            Delay.Milliseconds(0);
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegEx (Text~$YearVersion) on item 'HeavyBidServerSetup.ServerInstallTitle'.", repo.HeavyBidServerSetup.ServerInstallTitleInfo, new RecordItemIndex(2));
                Validate.Attribute(repo.HeavyBidServerSetup.ServerInstallTitleInfo, "Text", new Regex(YearVersion), Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegEx (Text~$YearVersion) on item 'HeavyBidServerSetup.WelcomeSetupText'.", repo.HeavyBidServerSetup.WelcomeSetupTextInfo, new RecordItemIndex(3));
                Validate.Attribute(repo.HeavyBidServerSetup.WelcomeSetupTextInfo, "Text", new Regex(YearVersion), Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegEx (Text~$YearVersion) on item 'HeavyBidServerSetup.SetupText'.", repo.HeavyBidServerSetup.SetupTextInfo, new RecordItemIndex(4));
                Validate.Attribute(repo.HeavyBidServerSetup.SetupTextInfo, "Text", new Regex(YearVersion), Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'HeavyBidServerSetup.ButtonNext'", repo.HeavyBidServerSetup.ButtonNextInfo, new ActionTimeout(60000), new RecordItemIndex(5));
            repo.HeavyBidServerSetup.ButtonNextInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.ButtonNext' at Center.", repo.HeavyBidServerSetup.ButtonNextInfo, new RecordItemIndex(6));
            repo.HeavyBidServerSetup.ButtonNext.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
