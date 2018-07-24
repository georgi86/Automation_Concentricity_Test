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
using UtilityFunctions;


namespace ConcentricityBasler1inch
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Action recording.
    /// </summary>
    [TestModule("0ad3780b-a18b-4966-89f2-022cc1f618e0", ModuleType.Recording, 1)]
    public partial class Action : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ConcentricityBasler1inchRepository repository.
        /// </summary>
        public static ConcentricityBasler1inchRepository repo = ConcentricityBasler1inchRepository.Instance;

        static Action instance = new Action();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Action()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Action Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            string strConcentricityResoltsPath = "D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\concentricity.STA";                    //////// DELETE FILE ////////////////
            System.IO.File.Delete(strConcentricityResoltsPath);       

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 701;8.", repo.SnapXUntitled.SnapXUntitledInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.SnapXUntitled.Click("701;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
            Delay.Duration(500, false);
            
            // Alt button
            Report.Log(ReportLevel.Info, "Keyboard", "Alt button\r\nKey sequence '{LMenu}'.", new RecordItemIndex(2));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            // F button
            Report.Log(ReportLevel.Info, "Keyboard", "F button\r\nKey sequence 'f'.", new RecordItemIndex(3));
            Keyboard.Press("f");
            Delay.Milliseconds(0);
            
            // O button
            Report.Log(ReportLevel.Info, "Keyboard", "O button\r\nKey sequence 'o'.", new RecordItemIndex(4));
            Keyboard.Press("o");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OpenSnapXRoutine.Text1148' at 203;6.", repo.OpenSnapXRoutine.Text1148Info, new RecordItemIndex(5));
            repo.OpenSnapXRoutine.Text1148.DoubleClick("203;6");
            Delay.Milliseconds(200);
            
            // Delete button
            Report.Log(ReportLevel.Info, "Keyboard", "Delete button\r\nKey sequence '{Delete}' with focus on 'OpenSnapXRoutine.Text1148'.", repo.OpenSnapXRoutine.Text1148Info, new RecordItemIndex(6));
            repo.OpenSnapXRoutine.Text1148.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Routine\\Concentricity_Basler1.mxy'.", new RecordItemIndex(7));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Routine\\Concentricity_Basler1.mxy");
            Delay.Milliseconds(0);
            
            // Enter button
            Report.Log(ReportLevel.Info, "Keyboard", "Enter button\r\nKey sequence '{Return}' with focus on 'OpenSnapXRoutine.Text1148'.", repo.OpenSnapXRoutine.Text1148Info, new RecordItemIndex(8));
            repo.OpenSnapXRoutine.Text1148.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 701;8.", repo.SnapXUntitled.SnapXUntitledInfo, new RecordItemIndex(9));
            repo.SnapXUntitled.SnapXUntitled.Click("701;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(10));
            Delay.Duration(500, false);
            
            // Alt button
            Report.Log(ReportLevel.Info, "Keyboard", "Alt button\r\nKey sequence '{LMenu}'.", new RecordItemIndex(11));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            // F button
            Report.Log(ReportLevel.Info, "Keyboard", "F button\r\nKey sequence 'f'.", new RecordItemIndex(12));
            Keyboard.Press("f");
            Delay.Milliseconds(0);
            
            // R button
            Report.Log(ReportLevel.Info, "Keyboard", "R button\r\nKey sequence 'r'.", new RecordItemIndex(13));
            Keyboard.Press("r");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.RunRoutineButtonOK' at Center.", repo.SnapXUntitled.RunRoutineButtonOKInfo, new RecordItemIndex(14));
            repo.SnapXUntitled.RunRoutineButtonOK.Click();
            Delay.Milliseconds(200);

            repo.SnapXUntitled.Finish.Focus();
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\concentricity.STA' with arguments '' in normal mode.", new RecordItemIndex(18));
            Host.Local.RunApplication("D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\concentricity.STA", "", "D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports", false);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Maximize() on item 'ConcentricitySTANotepad'.", repo.ConcentricitySTANotepad.SelfInfo, new RecordItemIndex(19));
            repo.ConcentricitySTANotepad.Self.Maximize();
            Delay.Milliseconds(300);

             
            string HardcodedConcentricityResult = "+0.001 \r\n+0.001";

            string ConcentricityResult = ((ConcentricityBasler1inch.ConcentricityBasler1inchRepositoryFolders.ConcentricitySTANotepadAppFolder)repo.ConcentricitySTANotepad.Text15Info.ParentFolder).Text15.TextValue;

            ConcentricityRun.RunConcentricity(HardcodedConcentricityResult, ConcentricityResult); 

            Delay.Milliseconds(1000);


            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'ConcentricitySTANotepad.Text15'.", repo.ConcentricitySTANotepad.Text15Info, new RecordItemIndex(21));
            Host.Current.CloseApplication(repo.ConcentricitySTANotepad.Text15, new Duration(0));
            Delay.Milliseconds(1000);
                       

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at Center.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(16));
            repo.SnapXUntitled.Finish.Click();
            Delay.Milliseconds(200);

            Delay.Duration(10000, false);

            string strSizeAcrossResoltsPath = "D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\sizeacross.STA";
            System.IO.File.Delete(strSizeAcrossResoltsPath);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 701;8.", repo.SnapXUntitled.SnapXUntitledInfo, new RecordItemIndex(22));
            repo.SnapXUntitled.SnapXUntitled.Click("701;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(23));
            Delay.Duration(500, false);
            
            // Alt button
            Report.Log(ReportLevel.Info, "Keyboard", "Alt button\r\nKey sequence '{LMenu}'.", new RecordItemIndex(24));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            // F button
            Report.Log(ReportLevel.Info, "Keyboard", "F button\r\nKey sequence 'f'.", new RecordItemIndex(25));
            Keyboard.Press("f");
            Delay.Milliseconds(0);
            
            // O button
            Report.Log(ReportLevel.Info, "Keyboard", "O button\r\nKey sequence 'o'.", new RecordItemIndex(26));
            Keyboard.Press("o");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OpenSnapXRoutine.Text1148' at 203;6.", repo.OpenSnapXRoutine.Text1148Info, new RecordItemIndex(27));
            repo.OpenSnapXRoutine.Text1148.DoubleClick("203;6");
            Delay.Milliseconds(200);
            
            // Delete button
            Report.Log(ReportLevel.Info, "Keyboard", "Delete button\r\nKey sequence '{Delete}' with focus on 'OpenSnapXRoutine.Text1148'.", repo.OpenSnapXRoutine.Text1148Info, new RecordItemIndex(28));
            repo.OpenSnapXRoutine.Text1148.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Routine\\SizeAcross_Basler1.mxy'.", new RecordItemIndex(29));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Routine\\SizeAcross_Basler1.mxy");
            Delay.Milliseconds(0);
            
            // Enter button
            Report.Log(ReportLevel.Info, "Keyboard", "Enter button\r\nKey sequence '{Return}' with focus on 'OpenSnapXRoutine.Text1148'.", repo.OpenSnapXRoutine.Text1148Info, new RecordItemIndex(30));
            repo.OpenSnapXRoutine.Text1148.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.SnapXUntitled' at 701;8.", repo.SnapXUntitled.SnapXUntitledInfo, new RecordItemIndex(31));
            repo.SnapXUntitled.SnapXUntitled.Click("701;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(32));
            Delay.Duration(500, false);
            
            // Alt button
            Report.Log(ReportLevel.Info, "Keyboard", "Alt button\r\nKey sequence '{LMenu}'.", new RecordItemIndex(33));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            // F button
            Report.Log(ReportLevel.Info, "Keyboard", "F button\r\nKey sequence 'f'.", new RecordItemIndex(34));
            Keyboard.Press("f");
            Delay.Milliseconds(0);
            
            // R button
            Report.Log(ReportLevel.Info, "Keyboard", "R button\r\nKey sequence 'r'.", new RecordItemIndex(35));
            Keyboard.Press("r");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.RunRoutineButtonOK' at Center.", repo.SnapXUntitled.RunRoutineButtonOKInfo, new RecordItemIndex(36));
            repo.SnapXUntitled.RunRoutineButtonOK.Click();
            Delay.Milliseconds(200);

            repo.SnapXUntitled.Finish.Focus();
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\sizeacross.STA' with arguments '' in normal mode.", new RecordItemIndex(39));
            Host.Local.RunApplication("D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\sizeacross.STA", "", "D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports", false);
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Maximize() on item 'SizeacrossSTANotepad'.", repo.SizeacrossSTANotepad.SelfInfo, new RecordItemIndex(40));
            repo.SizeacrossSTANotepad.Self.Maximize();
            Delay.Milliseconds(100);


            string HardcodedSizeAcrossResults = "+5.9866 \r\n+5.9868 \r\n+5.9857 \r\n-0.0004 \r\n-0.0013 \r\n+5.9853 \r\n+24.9973 \r\n-0.0007 \r\n+5.9878 \r\n+50.0009 \r\n-0.0009 \r\n+5.9868 \r\n-0.0007 \r\n-24.9949 \r\n+5.9833 \r\n+49.9973 \r\n-24.9972 \r\n+5.9882 \r\n-0.0023 \r\n-49.9945 \r\n+5.9870 \r\n+24.9951 \r\n-49.9940 \r\n+5.9855 \r\n+49.9933 \r\n-49.9942 \r\n+5.9918 \r\n-0.0002 \r\n+0.0004 \r\n+5.9896 \r\n+25.0001 \r\n+0.0001 \r\n+5.9914 \r\n+50.0018 \r\n+0.0018 \r\n+5.9924 \r\n+0.0001 \r\n-24.9939 \r\n+5.9881 \r\n+49.9984 \r\n-24.9943 \r\n+5.9928 \r\n-0.0007 \r\n-49.9937 \r\n+5.9914 \r\n+24.9973 \r\n-49.9934 \r\n+5.9915 \r\n+49.9953 \r\n-49.9936 \r\n+5.9958 \r\n+0.0003 \r\n+0.0005 \r\n+5.9953 \r\n+25.0010 \r\n-0.0005 \r\n+5.9947 \r\n+50.0020 \r\n+0.0009 \r\n+5.9955 \r\n-0.0009 \r\n-24.9951 \r\n+5.9940 \r\n+49.9996 \r\n-24.9962 \r\n+5.9956 \r\n-0.0014 \r\n-49.9951 \r\n+5.9955 \r\n+24.9986 \r\n-49.9946 \r\n+5.9944 \r\n+49.9983 \r\n-49.9951 \r\n+1.9964 \r\n+13.9972 \r\n-16.9939 \r\n+1.9962 \r\n+22.0037 \r\n+0.0022 \r\n+1.9966 \r\n-0.0001 \r\n+0.0000 \r\n+1.9956 \r\n+11.0015 \r\n-0.0007 \r\n+1.9964 \r\n+22.0039 \r\n+0.0004 \r\n+1.9943 \r\n+0.0000 \r\n-8.0030 \r\n+1.9941 \r\n+11.0006 \r\n-8.0030 \r\n+1.9944 \r\n+22.0023 \r\n-8.0042 \r\n+1.9954 \r\n-0.0025 \r\n-16.0078 \r\n+1.9949 \r\n+10.9991 \r\n-16.0067 \r\n+1.9960 \r\n+22.0016 \r\n-16.0100 \r\n+1.9977 \r\n+0.0003 \r\n-0.0001 \r\n+1.9968 \r\n+11.0018 \r\n-0.0008 \r\n+1.9976 \r\n+22.0043 \r\n+0.0000 \r\n+1.9954 \r\n+0.0009 \r\n-8.0031 \r\n+1.9955 \r\n+11.0009 \r\n-8.0031 \r\n+1.9958 \r\n+22.0031 \r\n-8.0042 \r\n+1.9971 \r\n-0.0014 \r\n-16.0076 \r\n+1.9962 \r\n+10.9997 \r\n-16.0067 \r\n+1.9974 \r\n+22.0021 \r\n-16.0096 \r\n+1.9986 \r\n+0.0009 \r\n-0.0002 \r\n+1.9981 \r\n+11.0023 \r\n-0.0009 \r\n+1.9987 \r\n+22.0043 \r\n+0.0002 \r\n+1.9966 \r\n+0.0015 \r\n-8.0030 \r\n+1.9973 \r\n+11.0009 \r\n-8.0029 \r\n+1.9968 \r\n+22.0031 \r\n-8.0038 \r\n+1.9977 \r\n-0.0009 \r\n-16.0069 \r\n+1.9973 \r\n+11.0000 \r\n-16.0060 \r\n+1.9982 \r\n+22.0023 \r\n-16.0090 \r\n+5.9908 \r\n+1.9965 \r\n+22.0039 \r\n+50.0009 \r\n-0.0007 \r\n+22.0043 \r\n-16.0100";

            string SizeAcrossResult = ((ConcentricityBasler1inch.ConcentricityBasler1inchRepositoryFolders.SizeacrossSTANotepadAppFolder)repo.SizeacrossSTANotepad.Text15Info.ParentFolder).Text15.TextValue;

            SizeAcrossRun.RunSize(HardcodedSizeAcrossResults, SizeAcrossResult);

            Delay.Milliseconds(1000);


            //Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='+5.9883 \r\n+19.7109 \r\n+25.6414 \r\n+5.9853 \r\n+50.0021 \r\n+0.0205 \r\n+5.9897 \r\n-0.0007 \r\n+0.0018 \r\n+5.9843 \r\n+25.0009 \r\n+0.0013 \r\n+5.9856 \r\n+50.0025 \r\n-0.0002 \r\n+5.9855 \r\n+0.0006 \r\n-24.9951 \r\n+5.9851 \r\n+49.9987 \r\n-24.9953 \r\n+5.9874 \r\n+0.0008 \r\n-49.9949 \r\n+5.9853 \r\n+25.0005 \r\n-49.9938 \r\n+5.9850 \r\n+49.9976 \r\n-49.9944 \r\n+5.9924 \r\n+0.0009 \r\n+0.0004 \r\n+5.9911 \r\n+25.0015 \r\n+0.0009 \r\n+5.9919 \r\n+50.0024 \r\n+0.0007 \r\n+5.9920 \r\n+0.0006 \r\n-24.9951 \r\n+5.9921 \r\n+50.0032 \r\n-24.9913 \r\n+5.9932 \r\n-0.0021 \r\n-49.9949 \r\n+5.9916 \r\n+24.9994 \r\n-49.9934 \r\n+5.9917 \r\n+49.9987 \r\n-49.9943 \r\n+5.9961 \r\n-0.0021 \r\n+0.0007 \r\n+5.9954 \r\n+25.0019 \r\n+0.0025 \r\n+5.9949 \r\n+50.0032 \r\n+0.0011 \r\n+5.9953 \r\n-0.0004 \r\n-24.9951 \r\n+5.9943 \r\n+50.0002 \r\n-24.9950 \r\n+5.9953 \r\n-0.0010 \r\n-49.9947 \r\n+5.9955 \r\n+24.9993 \r\n-49.9935 \r\n+5.9944 \r\n+49.9986 \r\n-49.9946 \r\n+1.9966 \r\n+14.0027 \r\n-17.0024 \r\n+1.9958 \r\n+21.9993 \r\n+0.0035 \r\n+1.9962 \r\n-0.0001 \r\n+0.0000 \r\n+1.9955 \r\n+10.9993 \r\n+0.0000 \r\n+1.9960 \r\n+21.9994 \r\n+0.0000 \r\n+1.9943 \r\n-0.0006 \r\n-7.9970 \r\n+1.9938 \r\n+10.9982 \r\n-7.9978 \r\n+1.9934 \r\n+21.9979 \r\n-7.9985 \r\n+1.9959 \r\n-0.0034 \r\n-15.9975 \r\n+1.9942 \r\n+10.9950 \r\n-15.9959 \r\n+1.9924 \r\n+21.9967 \r\n-15.9741 \r\n+1.9977 \r\n+0.0003 \r\n+0.0000 \r\n+1.9970 \r\n+10.9990 \r\n-0.0002 \r\n+1.9973 \r\n+21.9985 \r\n-0.0003 \r\n+1.9957 \r\n-0.0003 \r\n-7.9962 \r\n+1.9955 \r\n+10.9976 \r\n-7.9975 \r\n+1.9946 \r\n+21.9972 \r\n-7.9982 \r\n+1.9973 \r\n-0.0035 \r\n-15.9966 \r\n+1.9964 \r\n+10.9954 \r\n-15.9947 \r\n+1.9937 \r\n+21.9960 \r\n-15.9728 \r\n+1.9985 \r\n+0.0000 \r\n+0.0005 \r\n+1.9983 \r\n+10.9993 \r\n+0.0005 \r\n+1.9983 \r\n+21.9987 \r\n+0.0001 \r\n+1.9968 \r\n-0.0006 \r\n-7.9964 \r\n+1.9968 \r\n+10.9975 \r\n-7.9972 \r\n+1.9959 \r\n+21.9968 \r\n-7.9979 \r\n+1.9984 \r\n-0.0035 \r\n-15.9962 \r\n+1.9977 \r\n+10.9952 \r\n-15.9944 \r\n+1.9947 \r\n+21.9959 \r\n-15.9729 \r\n+5.9910 \r\n+1.9960 \r\n+21.9994 \r\n+50.0025 \r\n+0.0018 \r\n+21.9994 \r\n-15.9975 \r\n') on item 'SizeacrossSTANotepad.Text15'.", repo.SizeacrossSTANotepad.Text15Info, new RecordItemIndex(41));
                            
            

            Delay.Milliseconds(1000);


            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'SizeacrossSTANotepad.Text15'.", repo.SizeacrossSTANotepad.Text15Info, new RecordItemIndex(42));
            Host.Current.CloseApplication(repo.SizeacrossSTANotepad.Text15, new Duration(0));
            Delay.Milliseconds(1000);


            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at Center.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(38));
            repo.SnapXUntitled.Finish.Click();
            Delay.Milliseconds(200);

        }

    }

}
