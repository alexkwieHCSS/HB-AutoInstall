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
    ///The PlusPivotReportDesigner recording.
    /// </summary>
    [TestModule("32db85bf-e5c7-4fb8-943e-88fe1795e724", ModuleType.Recording, 1)]
    public partial class PlusPivotReportDesigner : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static PlusPivotReportDesigner instance = new PlusPivotReportDesigner();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PlusPivotReportDesigner()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PlusPivotReportDesigner Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.ReportTab' at Center.", repo.HeavyBidTabs.ReportTabInfo, new RecordItemIndex(0));
            //repo.HeavyBidTabs.ReportTab.Click();
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.QueryTab' at Center.", repo.HeavyBidTabs.QueryTabInfo, new RecordItemIndex(1));
            repo.HeavyBidTabs.QueryTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.ButtonPivotReports' at Center.", repo.HeavyBidTabs.ButtonPivotReportsInfo, new RecordItemIndex(2));
            repo.HeavyBidTabs.ButtonPivotReports.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HBMultiDocumentInterface.ReportDesigner' at Center.", repo.HBMultiDocumentInterface.ReportDesignerInfo, new RecordItemIndex(3));
            repo.HBMultiDocumentInterface.ReportDesigner.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(4));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HeavyBidPivotReports.ButtonClose'.", repo.HeavyBidPivotReports.ButtonCloseInfo, new RecordItemIndex(5));
            Host.Current.CloseApplication(repo.HeavyBidPivotReports.ButtonClose, 1000);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
