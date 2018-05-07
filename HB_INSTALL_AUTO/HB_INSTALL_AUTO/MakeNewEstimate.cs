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
    ///The MakeNewEstimate recording.
    /// </summary>
    [TestModule("b5eb13e6-7043-43ab-993a-9a8fcc0c889f", ModuleType.Recording, 1)]
    public partial class MakeNewEstimate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static MakeNewEstimate instance = new MakeNewEstimate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MakeNewEstimate()
        {
            NewEstimateCode = "Estimate-1";
            NewEstimateName = "Test Estimate 1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MakeNewEstimate Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable NewEstimateCode.
        /// </summary>
        [TestVariable("d7f1e071-dfc6-48ea-a9b9-31a0e02b1494")]
        public string NewEstimateCode
        {
            get { return repo.NewEstimateCode; }
            set { repo.NewEstimateCode = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NewEstimateName.
        /// </summary>
        [TestVariable("cf17ed8c-3d08-4ca9-96aa-72ec9ac259ab")]
        public string NewEstimateName
        {
            get { return repo.NewEstimateName; }
            set { repo.NewEstimateName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.FileTab' at Center.", repo.HeavyBidTabs.FileTabInfo, new RecordItemIndex(0));
            repo.HeavyBidTabs.FileTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.ButtonNewEstimate' at Center.", repo.HeavyBidTabs.ButtonNewEstimateInfo, new RecordItemIndex(1));
            repo.HeavyBidTabs.ButtonNewEstimate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBButtonDropdownOptions.NewEstimate' at Center.", repo.HBButtonDropdownOptions.NewEstimateInfo, new RecordItemIndex(2));
            repo.HBButtonDropdownOptions.NewEstimate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewEstimate.EstimateCode' at Center.", repo.NewEstimate.EstimateCodeInfo, new RecordItemIndex(3));
            repo.NewEstimate.EstimateCode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NewEstimateCode' with focus on 'NewEstimate.EstimateCode'.", repo.NewEstimate.EstimateCodeInfo, new RecordItemIndex(4));
            repo.NewEstimate.EstimateCode.PressKeys(NewEstimateCode);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewEstimate.NextButton' at Center.", repo.NewEstimate.NextButtonInfo, new RecordItemIndex(5));
            repo.NewEstimate.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewEstimate.EstimateNameTextBox' at Center.", repo.NewEstimate.EstimateNameTextBoxInfo, new RecordItemIndex(6));
            repo.NewEstimate.EstimateNameTextBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NewEstimateName' with focus on 'NewEstimate.EstimateNameTextBox'.", repo.NewEstimate.EstimateNameTextBoxInfo, new RecordItemIndex(7));
            repo.NewEstimate.EstimateNameTextBox.PressKeys(NewEstimateName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewEstimate.EstimateDescriptionTextBox' at Center.", repo.NewEstimate.EstimateDescriptionTextBoxInfo, new RecordItemIndex(8));
            repo.NewEstimate.EstimateDescriptionTextBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{RShiftKey down}THIS{Space}IS{Space down}A{Space up}{Space}TEST{Space}ESTIMATE{RShiftKey up}' with focus on 'NewEstimate.EstimateDescriptionTextBox'.", repo.NewEstimate.EstimateDescriptionTextBoxInfo, new RecordItemIndex(9));
            repo.NewEstimate.EstimateDescriptionTextBox.PressKeys("{RShiftKey down}THIS{Space}IS{Space down}A{Space up}{Space}TEST{Space}ESTIMATE{RShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewEstimate.NextButton' at Center.", repo.NewEstimate.NextButtonInfo, new RecordItemIndex(10));
            repo.NewEstimate.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewEstimate.FinishButton' at Center.", repo.NewEstimate.FinishButtonInfo, new RecordItemIndex(11));
            repo.NewEstimate.FinishButton.Click();
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}{Escape}'.", new RecordItemIndex(12));
            //Keyboard.Press("{Escape}{Escape}");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
