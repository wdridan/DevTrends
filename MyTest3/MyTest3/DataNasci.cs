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
    ///The DataNasci recording.
    /// </summary>
    [TestModule("2004ee32-42a4-4084-af5b-43bdaaca2fe7", ModuleType.Recording, 1)]
    public partial class DataNasci : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest3Repository repository.
        /// </summary>
        public static MyTest3Repository repo = MyTest3Repository.Instance;

        static DataNasci instance = new DataNasci();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DataNasci()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DataNasci Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DateOfBirthInput' at 109;22.", repo.ApplicationUnderTest.DateOfBirthInputInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.DateOfBirthInput.Click("109;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthContainer'.", repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthContainerInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthContainerInfo, "Valid", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthContainer'.", repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthContainerInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthContainerInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (SafeClass='react-datepicker__month-container') on item 'ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthContainer'.", repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthContainerInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthContainerInfo, "SafeClass", "react-datepicker__month-container");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerYearSelect' at 43;8.", repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerYearSelectInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerYearSelect.Click("43;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1991' on item 'ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerYearSelect'.", repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerYearSelectInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerYearSelect.Element.SetAttributeValue("TagValue", "1991");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthSelect' at Center.", repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthSelectInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthSelect.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '5' on item 'ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthSelect'.", repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthSelectInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.ReactDatepickerMonthSelect.Element.SetAttributeValue("TagValue", "5");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ReactDatepickerMonthContainer1.DivTag14' at 11;12.", repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.DivTag14Info, new RecordItemIndex(9));
            repo.ApplicationUnderTest.ReactDatepickerMonthContainer1.DivTag14.Click("11;12");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}