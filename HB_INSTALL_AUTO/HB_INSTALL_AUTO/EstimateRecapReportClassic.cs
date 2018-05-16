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
    ///The EstimateRecapReportClassic recording.
    /// </summary>
    [TestModule("b0a5975c-5977-4f02-9744-57097a368357", ModuleType.Recording, 1)]
    public partial class EstimateRecapReportClassic : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static EstimateRecapReportClassic instance = new EstimateRecapReportClassic();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EstimateRecapReportClassic()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EstimateRecapReportClassic Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.ReportTab' at Center.", repo.HeavyBidApp.Tabs.ReportTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.ReportTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.Report.ButtonSummaryReports' at Center.", repo.HeavyBidApp.Buttons.Report.ButtonSummaryReportsInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.Report.ButtonSummaryReports.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HeavyBidApp.HBMultiDocumentInterface.Reports.SummaryReports.EstimateRecapClassic' at Center.", repo.HeavyBidApp.HBMultiDocumentInterface.Reports.SummaryReports.EstimateRecapClassicInfo, new RecordItemIndex(2));
            repo.HeavyBidApp.HBMultiDocumentInterface.Reports.SummaryReports.EstimateRecapClassic.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HBReportViewers.PrintPreview'.", repo.HBReportViewers.PrintPreview.SelfInfo, new RecordItemIndex(4));
            Host.Current.CloseApplication(repo.HBReportViewers.PrintPreview.Self, 1000);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
