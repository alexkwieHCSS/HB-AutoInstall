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
    ///The CostPriceReport recording.
    /// </summary>
    [TestModule("276e2e51-5f83-459a-ae17-244029f13f9f", ModuleType.Recording, 1)]
    public partial class CostPriceReport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static CostPriceReport instance = new CostPriceReport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CostPriceReport()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CostPriceReport Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.ReportTab' at Center.", repo.HeavyBidTabs.ReportTabInfo, new RecordItemIndex(0));
            repo.HeavyBidTabs.ReportTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.ButtonSummaryReports' at Center.", repo.HeavyBidTabs.ButtonSummaryReportsInfo, new RecordItemIndex(1));
            repo.HeavyBidTabs.ButtonSummaryReports.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HBMultiDocumentInterface.CostPriceReport' at Center.", repo.HBMultiDocumentInterface.CostPriceReportInfo, new RecordItemIndex(2));
            repo.HBMultiDocumentInterface.CostPriceReport.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportPlusViewer.ButtonClosePreview' at Center.", repo.HBReportPlusViewer.ButtonClosePreviewInfo, new RecordItemIndex(4));
            repo.HBReportPlusViewer.ButtonClosePreview.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
