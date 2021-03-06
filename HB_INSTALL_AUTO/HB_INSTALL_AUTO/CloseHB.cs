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
    ///The CloseHB recording.
    /// </summary>
    [TestModule("6cca3ba7-1b96-4f77-b89a-fddfeaed7c5d", ModuleType.Recording, 1)]
    public partial class CloseHB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static CloseHB instance = new CloseHB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseHB()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseHB Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HeavyBidApp'.", repo.HeavyBidApp.SelfInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.HeavyBidApp.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ExitHeavyBid.ButtonYes'", repo.ExitHeavyBid.ButtonYesInfo, new ActionTimeout(10000), new RecordItemIndex(1));
            repo.ExitHeavyBid.ButtonYesInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExitHeavyBid.ButtonYes' at Center.", repo.ExitHeavyBid.ButtonYesInfo, new RecordItemIndex(2));
            repo.ExitHeavyBid.ButtonYes.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
