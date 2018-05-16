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
    ///The UserLicense recording.
    /// </summary>
    [TestModule("8696c80c-f1ad-4df9-8250-1402ceac9fad", ModuleType.Recording, 1)]
    public partial class UserLicense : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static UserLicense instance = new UserLicense();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserLicense()
        {
            YearVersion = "2018.1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UserLicense Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable YearVersion.
        /// </summary>
        [TestVariable("04c9b932-c3bc-478e-be8e-cc2deb04f216")]
        public string YearVersion
        {
            get { return repo.YearVersion; }
            set { repo.YearVersion = value; }
        }

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

            // B.3
            Report.Log(ReportLevel.Info, "Validation", "B.3\r\nValidating AttributeRegex (Text~'[HeavyBid][Setup]') on item 'HeavyBidServerSetup.Titlebar'.", repo.HeavyBidServerSetup.TitlebarInfo, new RecordItemIndex(0));
            Validate.AttributeRegex(repo.HeavyBidServerSetup.TitlebarInfo, "Text", new Regex("[HeavyBid][Setup]"));
            Delay.Milliseconds(0);
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~$YearVersion) on item 'HeavyBidServerSetup.Titlebar'.", repo.HeavyBidServerSetup.TitlebarInfo, new RecordItemIndex(1));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TitlebarInfo, "Text", new Regex(YearVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            // B.4
            Report.Log(ReportLevel.Info, "Validation", "B.4\r\nValidating AttributeContains (AccessibleState>'Unavailable') on item 'HeavyBidServerSetup.Buttons.ButtonNext'.", repo.HeavyBidServerSetup.Buttons.ButtonNextInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.HeavyBidServerSetup.Buttons.ButtonNextInfo, "AccessibleState", "Unavailable");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'HeavyBidServerSetup.IAcceptTheTermsInTheLicenseAgreem'", repo.HeavyBidServerSetup.IAcceptTheTermsInTheLicenseAgreemInfo, new ActionTimeout(60000), new RecordItemIndex(3));
            repo.HeavyBidServerSetup.IAcceptTheTermsInTheLicenseAgreemInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.IAcceptTheTermsInTheLicenseAgreem' at Center.", repo.HeavyBidServerSetup.IAcceptTheTermsInTheLicenseAgreemInfo, new RecordItemIndex(4));
            repo.HeavyBidServerSetup.IAcceptTheTermsInTheLicenseAgreem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'HeavyBidServerSetup.Buttons.ButtonNext'", repo.HeavyBidServerSetup.Buttons.ButtonNextInfo, new ActionTimeout(60000), new RecordItemIndex(5));
            repo.HeavyBidServerSetup.Buttons.ButtonNextInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.Buttons.ButtonNext' at Center.", repo.HeavyBidServerSetup.Buttons.ButtonNextInfo, new RecordItemIndex(6));
            repo.HeavyBidServerSetup.Buttons.ButtonNext.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
