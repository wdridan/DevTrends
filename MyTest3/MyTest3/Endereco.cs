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

namespace MyTest3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Endereco recording.
    /// </summary>
    [TestModule("120d1de8-e5ac-4e36-9a58-108f5a353649", ModuleType.Recording, 1)]
    public partial class Endereco : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest3Repository repository.
        /// </summary>
        public static MyTest3Repository repo = MyTest3Repository.Instance;

        static Endereco instance = new Endereco();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Endereco()
        {
            Adress = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Endereco Instance
        {
            get { return instance; }
        }

#region Variables

        string _Adress;

        /// <summary>
        /// Gets or sets the value of variable Adress.
        /// </summary>
        [TestVariable("5f725cb6-be96-4ad6-ab6d-1ce6c7c13e18")]
        public string Adress
        {
            get { return _Adress; }
            set { _Adress = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CurrentAddress' at 83;17.", repo.ApplicationUnderTest.CurrentAddressInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.CurrentAddress.Click("83;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Adress' with focus on 'ApplicationUnderTest.CurrentAddress'.", repo.ApplicationUnderTest.CurrentAddressInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.CurrentAddress.PressKeys(Adress);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Css1hwfws3' at LowerLeft.", repo.ApplicationUnderTest.Css1hwfws3Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Css1hwfws3.Click(Location.LowerLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Rajasthan' at LowerLeft.", repo.ApplicationUnderTest.RajasthanInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Rajasthan.Click(Location.LowerLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CssTlfeczIndicatorContainer' at LowerLeft.", repo.ApplicationUnderTest.CssTlfeczIndicatorContainerInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.CssTlfeczIndicatorContainer.Click(Location.LowerLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Jaiselmer' at LowerLeft.", repo.ApplicationUnderTest.JaiselmerInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Jaiselmer.Click(Location.LowerLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit' at 34;26.", repo.ApplicationUnderTest.SubmitInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Submit.Click("34;26");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
