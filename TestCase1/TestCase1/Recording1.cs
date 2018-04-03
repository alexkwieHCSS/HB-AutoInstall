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

namespace TestCase1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("c6b74992-9f58-43cb-b7e9-2a17964c09e8", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestCase1Repository repository.
        /// </summary>
        public static TestCase1Repository repo = TestCase1Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://accessuh.uh.edu/login.php' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://accessuh.uh.edu/login.php", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AccessUHUniversityOfHoustonGoogl.Element1250396752' at 823;385.", repo.AccessUHUniversityOfHoustonGoogl.Element1250396752Info, new RecordItemIndex(1));
            repo.AccessUHUniversityOfHoustonGoogl.Element1250396752.Click("823;385");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'atjonakw{Tab}stra8{RShiftKey down}GARBAGE!{RShiftKey up}{Return}' with focus on 'AccessUHUniversityOfHoustonGoogl'.", repo.AccessUHUniversityOfHoustonGoogl.SelfInfo, new RecordItemIndex(2));
            repo.AccessUHUniversityOfHoustonGoogl.Self.PressKeys("atjonakw{Tab}stra8{RShiftKey down}GARBAGE!{RShiftKey up}{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AccessUHUniversityOfHoustonGoogl.Element1250396752' at 888;588.", repo.AccessUHUniversityOfHoustonGoogl.Element1250396752Info, new RecordItemIndex(3));
            repo.AccessUHUniversityOfHoustonGoogl.Element1250396752.Click("888;588");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\HeavyBid\\BIN\\HEAVYBID.exe' with arguments ' HeavySING' in normal mode.", new RecordItemIndex(4));
            Host.Local.RunApplication("C:\\HeavyBid\\BIN\\HEAVYBID.exe", " HeavySING", "C:\\HeavyBid\\BIN\\", false);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
