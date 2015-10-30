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

namespace AC3CalcTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording2 recording.
    /// </summary>
    [TestModule("b0ed384b-13e5-44c0-bdf3-f42b7a19ab58", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AC3CalcTestsRepository repository.
        /// </summary>
        public static AC3CalcTestsRepository repo = AC3CalcTestsRepository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.3")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\FlashDevelop\\Flex3Calc\\bin\\Flex3Calc.swf' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("D:\\FlashDevelop\\Flex3Calc\\bin\\Flex3Calc.swf", "", "D:\\FlashDevelop\\Flex3Calc\\bin", false);
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Flex3CalcSwfGoogleChrome.Element633897488' at 691;131.", repo.Flex3CalcSwfGoogleChrome.Element633897488Info, new RecordItemIndex(1));
            repo.Flex3CalcSwfGoogleChrome.Element633897488.Click("691;131");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Flex3CalcSwfGoogleChrome.Element633897488' at 737;132.", repo.Flex3CalcSwfGoogleChrome.Element633897488Info, new RecordItemIndex(2));
            repo.Flex3CalcSwfGoogleChrome.Element633897488.Click("737;132");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Flex3CalcSwfGoogleChrome.Element633897488' at 655;158.", repo.Flex3CalcSwfGoogleChrome.Element633897488Info, new RecordItemIndex(3));
            repo.Flex3CalcSwfGoogleChrome.Element633897488.Click("655;158");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Flex3CalcSwfGoogleChrome.Element633897488' at 699;217.", repo.Flex3CalcSwfGoogleChrome.Element633897488Info, new RecordItemIndex(4));
            repo.Flex3CalcSwfGoogleChrome.Element633897488.Click("699;217");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=740,Y=62,Width=27,Height=20}) on item 'Flex3CalcSwfGoogleChrome.Element633897488'.", repo.Flex3CalcSwfGoogleChrome.Element633897488Info, new RecordItemIndex(5));
            Validate.ContainsImage(repo.Flex3CalcSwfGoogleChrome.Element633897488Info, Element633897488_Screenshot1, Element633897488_Screenshot1_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage Element633897488_Screenshot1
        { get { return repo.Flex3CalcSwfGoogleChrome.Element633897488Info.GetScreenshot1(new Rectangle(740, 62, 27, 20)); } }

        Imaging.FindOptions Element633897488_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
