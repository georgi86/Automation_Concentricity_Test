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
        
        
        ///////////////////////////////////////////////////////////////////////
        

        private static bool IsConcentricityZero(double dConcentricityExpression, double EPSILONE)
        {
            return System.Math.Abs(dConcentricityExpression) < EPSILONE;
        }

        private static bool IsConcentricityEQ(double first, double second, double EPSILONE)
        {
            return IsConcentricityZero(first - second, EPSILONE);
        }
        
      
        ///////////////////////////////////////////////////////////////////////
      

        private static bool IsZero(double dExpression, double EPSILONE)
        {
            return System.Math.Abs(dExpression) < EPSILONE;
        }

        private static bool isEQ(double first, double second, double EPSILONE)
        {
            return IsZero(first - second, EPSILONE);
        }

        //////////////////////////////////////////////////////////////////////////


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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for item 'SnapXUntitled.Finish' to exist.", repo.SnapXUntitled.FinishInfo, new ActionTimeout(60000), new RecordItemIndex(15));
            repo.SnapXUntitled.FinishInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at Center.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(16));
            repo.SnapXUntitled.Finish.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(17));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\concentricity.STA' with arguments '' in normal mode.", new RecordItemIndex(18));
            Host.Local.RunApplication("D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\concentricity.STA", "", "D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports", false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Maximize() on item 'ConcentricitySTANotepad'.", repo.ConcentricitySTANotepad.SelfInfo, new RecordItemIndex(19));
            repo.ConcentricitySTANotepad.Self.Maximize();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='+0.0044 \r\n+0.0058 \r\n') on item 'ConcentricitySTANotepad.Text15'.", repo.ConcentricitySTANotepad.Text15Info, new RecordItemIndex(20));
            //Validate.Attribute(repo.ConcentricitySTANotepad.Text15Info, "WindowText", "+0.0044 \r\n+0.0058 \r\n", Validate.DefaultMessage, false);
            Delay.Milliseconds(200);


            string ConcentricityResult = ((ConcentricityBasler1inch.ConcentricityBasler1inchRepositoryFolders.ConcentricitySTANotepadAppFolder)repo.ConcentricitySTANotepad.Text15Info.ParentFolder).Text15.TextValue;

            string[] ReadConcentricityResult = Regex.Split(ConcentricityResult, "[\r\n]+");

            int iNumConcentricityRows = ReadConcentricityResult.Length;

            string HardcodedConcentricityResult = "+0.0044 \r\n+0.0058 \r\n";

            string[] ReadHardcodedConcentricityResult = Regex.Split(HardcodedConcentricityResult, "[\r\n]+");

            int iNumHardcodedRows = ReadHardcodedConcentricityResult.Length;


            //string[] sArrConcentricityResult = new string[iNumConcentricityRows];                         //Array of strings, that contains the Actual results
            //string[] sArrHardcodedConcentricityResults = new string[iNumHardcodedRows];                   //Array of strings, that contains the Hardcoded results
            

            for (int i = 0; i < iNumConcentricityRows; i++)
            {
                double dActualConcentricityValue;
                double dHardcodedConcentricityValue;
                Double.TryParse(ReadConcentricityResult[i], out dActualConcentricityValue);               //Double is object and Try Parse is method in this object. The idea of this method is to convert the given string to value         
                Double.TryParse(ReadHardcodedConcentricityResult[i], out dHardcodedConcentricityValue);
                if (!IsConcentricityEQ(dActualConcentricityValue, dHardcodedConcentricityValue, 0.002))
                {
                    string errLine = "Error on line: " + (i + 1);
                    Ranorex.Report.Error("Validation", errLine);
                    errLine = "Actual value is " + dActualConcentricityValue;
                    Ranorex.Report.Error("Actual Value is ", errLine);
                    errLine = "Hardcoded value is " + dHardcodedConcentricityValue;
                    Ranorex.Report.Error("Expected Value is ", errLine);
                }
            }


            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'ConcentricitySTANotepad.Text15'.", repo.ConcentricitySTANotepad.Text15Info, new RecordItemIndex(21));
            Host.Current.CloseApplication(repo.ConcentricitySTANotepad.Text15, new Duration(0));
            Delay.Milliseconds(0);
            
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
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 40s.", new RecordItemIndex(37));
            Delay.Duration(35000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at Center.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(38));
            repo.SnapXUntitled.Finish.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\sizeacross.STA' with arguments '' in normal mode.", new RecordItemIndex(39));
            Host.Local.RunApplication("D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports\\sizeacross.STA", "", "D:\\Joro\\GIT_Automations\\AutomationConcentricity\\Reports", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Maximize() on item 'SizeacrossSTANotepad'.", repo.SizeacrossSTANotepad.SelfInfo, new RecordItemIndex(40));
            repo.SizeacrossSTANotepad.Self.Maximize();
            Delay.Milliseconds(100);
            
            
            Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='+5.9883 \r\n+19.7109 \r\n+25.6414 \r\n+5.9853 \r\n+50.0021 \r\n+0.0205 \r\n+5.9897 \r\n-0.0007 \r\n+0.0018 \r\n+5.9843 \r\n+25.0009 \r\n+0.0013 \r\n+5.9856 \r\n+50.0025 \r\n-0.0002 \r\n+5.9855 \r\n+0.0006 \r\n-24.9951 \r\n+5.9851 \r\n+49.9987 \r\n-24.9953 \r\n+5.9874 \r\n+0.0008 \r\n-49.9949 \r\n+5.9853 \r\n+25.0005 \r\n-49.9938 \r\n+5.9850 \r\n+49.9976 \r\n-49.9944 \r\n+5.9924 \r\n+0.0009 \r\n+0.0004 \r\n+5.9911 \r\n+25.0015 \r\n+0.0009 \r\n+5.9919 \r\n+50.0024 \r\n+0.0007 \r\n+5.9920 \r\n+0.0006 \r\n-24.9951 \r\n+5.9921 \r\n+50.0032 \r\n-24.9913 \r\n+5.9932 \r\n-0.0021 \r\n-49.9949 \r\n+5.9916 \r\n+24.9994 \r\n-49.9934 \r\n+5.9917 \r\n+49.9987 \r\n-49.9943 \r\n+5.9961 \r\n-0.0021 \r\n+0.0007 \r\n+5.9954 \r\n+25.0019 \r\n+0.0025 \r\n+5.9949 \r\n+50.0032 \r\n+0.0011 \r\n+5.9953 \r\n-0.0004 \r\n-24.9951 \r\n+5.9943 \r\n+50.0002 \r\n-24.9950 \r\n+5.9953 \r\n-0.0010 \r\n-49.9947 \r\n+5.9955 \r\n+24.9993 \r\n-49.9935 \r\n+5.9944 \r\n+49.9986 \r\n-49.9946 \r\n+1.9966 \r\n+14.0027 \r\n-17.0024 \r\n+1.9958 \r\n+21.9993 \r\n+0.0035 \r\n+1.9962 \r\n-0.0001 \r\n+0.0000 \r\n+1.9955 \r\n+10.9993 \r\n+0.0000 \r\n+1.9960 \r\n+21.9994 \r\n+0.0000 \r\n+1.9943 \r\n-0.0006 \r\n-7.9970 \r\n+1.9938 \r\n+10.9982 \r\n-7.9978 \r\n+1.9934 \r\n+21.9979 \r\n-7.9985 \r\n+1.9959 \r\n-0.0034 \r\n-15.9975 \r\n+1.9942 \r\n+10.9950 \r\n-15.9959 \r\n+1.9924 \r\n+21.9967 \r\n-15.9741 \r\n+1.9977 \r\n+0.0003 \r\n+0.0000 \r\n+1.9970 \r\n+10.9990 \r\n-0.0002 \r\n+1.9973 \r\n+21.9985 \r\n-0.0003 \r\n+1.9957 \r\n-0.0003 \r\n-7.9962 \r\n+1.9955 \r\n+10.9976 \r\n-7.9975 \r\n+1.9946 \r\n+21.9972 \r\n-7.9982 \r\n+1.9973 \r\n-0.0035 \r\n-15.9966 \r\n+1.9964 \r\n+10.9954 \r\n-15.9947 \r\n+1.9937 \r\n+21.9960 \r\n-15.9728 \r\n+1.9985 \r\n+0.0000 \r\n+0.0005 \r\n+1.9983 \r\n+10.9993 \r\n+0.0005 \r\n+1.9983 \r\n+21.9987 \r\n+0.0001 \r\n+1.9968 \r\n-0.0006 \r\n-7.9964 \r\n+1.9968 \r\n+10.9975 \r\n-7.9972 \r\n+1.9959 \r\n+21.9968 \r\n-7.9979 \r\n+1.9984 \r\n-0.0035 \r\n-15.9962 \r\n+1.9977 \r\n+10.9952 \r\n-15.9944 \r\n+1.9947 \r\n+21.9959 \r\n-15.9729 \r\n+5.9910 \r\n+1.9960 \r\n+21.9994 \r\n+50.0025 \r\n+0.0018 \r\n+21.9994 \r\n-15.9975 \r\n') on item 'SizeacrossSTANotepad.Text15'.", repo.SizeacrossSTANotepad.Text15Info, new RecordItemIndex(41));
            //Validate.Attribute(repo.SizeacrossSTANotepad.Text15Info, "WindowText", "+5.9883 \r\n+19.7109 \r\n+25.6414 \r\n+5.9853 \r\n+50.0021 \r\n+0.0205 \r\n+5.9897 \r\n-0.0007 \r\n+0.0018 \r\n+5.9843 \r\n+25.0009 \r\n+0.0013 \r\n+5.9856 \r\n+50.0025 \r\n-0.0002 \r\n+5.9855 \r\n+0.0006 \r\n-24.9951 \r\n+5.9851 \r\n+49.9987 \r\n-24.9953 \r\n+5.9874 \r\n+0.0008 \r\n-49.9949 \r\n+5.9853 \r\n+25.0005 \r\n-49.9938 \r\n+5.9850 \r\n+49.9976 \r\n-49.9944 \r\n+5.9924 \r\n+0.0009 \r\n+0.0004 \r\n+5.9911 \r\n+25.0015 \r\n+0.0009 \r\n+5.9919 \r\n+50.0024 \r\n+0.0007 \r\n+5.9920 \r\n+0.0006 \r\n-24.9951 \r\n+5.9921 \r\n+50.0032 \r\n-24.9913 \r\n+5.9932 \r\n-0.0021 \r\n-49.9949 \r\n+5.9916 \r\n+24.9994 \r\n-49.9934 \r\n+5.9917 \r\n+49.9987 \r\n-49.9943 \r\n+5.9961 \r\n-0.0021 \r\n+0.0007 \r\n+5.9954 \r\n+25.0019 \r\n+0.0025 \r\n+5.9949 \r\n+50.0032 \r\n+0.0011 \r\n+5.9953 \r\n-0.0004 \r\n-24.9951 \r\n+5.9943 \r\n+50.0002 \r\n-24.9950 \r\n+5.9953 \r\n-0.0010 \r\n-49.9947 \r\n+5.9955 \r\n+24.9993 \r\n-49.9935 \r\n+5.9944 \r\n+49.9986 \r\n-49.9946 \r\n+1.9966 \r\n+14.0027 \r\n-17.0024 \r\n+1.9958 \r\n+21.9993 \r\n+0.0035 \r\n+1.9962 \r\n-0.0001 \r\n+0.0000 \r\n+1.9955 \r\n+10.9993 \r\n+0.0000 \r\n+1.9960 \r\n+21.9994 \r\n+0.0000 \r\n+1.9943 \r\n-0.0006 \r\n-7.9970 \r\n+1.9938 \r\n+10.9982 \r\n-7.9978 \r\n+1.9934 \r\n+21.9979 \r\n-7.9985 \r\n+1.9959 \r\n-0.0034 \r\n-15.9975 \r\n+1.9942 \r\n+10.9950 \r\n-15.9959 \r\n+1.9924 \r\n+21.9967 \r\n-15.9741 \r\n+1.9977 \r\n+0.0003 \r\n+0.0000 \r\n+1.9970 \r\n+10.9990 \r\n-0.0002 \r\n+1.9973 \r\n+21.9985 \r\n-0.0003 \r\n+1.9957 \r\n-0.0003 \r\n-7.9962 \r\n+1.9955 \r\n+10.9976 \r\n-7.9975 \r\n+1.9946 \r\n+21.9972 \r\n-7.9982 \r\n+1.9973 \r\n-0.0035 \r\n-15.9966 \r\n+1.9964 \r\n+10.9954 \r\n-15.9947 \r\n+1.9937 \r\n+21.9960 \r\n-15.9728 \r\n+1.9985 \r\n+0.0000 \r\n+0.0005 \r\n+1.9983 \r\n+10.9993 \r\n+0.0005 \r\n+1.9983 \r\n+21.9987 \r\n+0.0001 \r\n+1.9968 \r\n-0.0006 \r\n-7.9964 \r\n+1.9968 \r\n+10.9975 \r\n-7.9972 \r\n+1.9959 \r\n+21.9968 \r\n-7.9979 \r\n+1.9984 \r\n-0.0035 \r\n-15.9962 \r\n+1.9977 \r\n+10.9952 \r\n-15.9944 \r\n+1.9947 \r\n+21.9959 \r\n-15.9729 \r\n+5.9910 \r\n+1.9960 \r\n+21.9994 \r\n+50.0025 \r\n+0.0018 \r\n+21.9994 \r\n-15.9975 \r\n", Validate.DefaultMessage, false);
            Delay.Milliseconds(200);
            

            //Take the generated results from the Routine procedure
            string SizeAcrossResult = ((ConcentricityBasler1inch.ConcentricityBasler1inchRepositoryFolders.SizeacrossSTANotepadAppFolder)repo.SizeacrossSTANotepad.Text15Info.ParentFolder).Text15.TextValue;

            //Actual results as read from the file
            string[] ReadSizeAcrossResult = Regex.Split(SizeAcrossResult, "[\r\n]+");

            //Convert the number of rows from string to (int) number 
            int iNumActualRows = ReadSizeAcrossResult.Length;

            //Hardcoded results
            string HardcodedSizeAcrossResults = "+5.9883 \r\n+19.7109 \r\n+25.6414 \r\n+5.9853 \r\n+50.0021 \r\n+0.0205 \r\n+5.9897 \r\n-0.0007 \r\n+0.0018 \r\n+5.9843 \r\n+25.0009 \r\n+0.0013 \r\n+5.9856 \r\n+50.0025 \r\n-0.0002 \r\n+5.9855 \r\n+0.0006 \r\n-24.9951 \r\n+5.9851 \r\n+49.9987 \r\n-24.9953 \r\n+5.9874 \r\n+0.0008 \r\n-49.9949 \r\n+5.9853 \r\n+25.0005 \r\n-49.9938 \r\n+5.9850 \r\n+49.9976 \r\n-49.9944 \r\n+5.9924 \r\n+0.0009 \r\n+0.0004 \r\n+5.9911 \r\n+25.0015 \r\n+0.0009 \r\n+5.9919 \r\n+50.0024 \r\n+0.0007 \r\n+5.9920 \r\n+0.0006 \r\n-24.9951 \r\n+5.9921 \r\n+50.0032 \r\n-24.9913 \r\n+5.9932 \r\n-0.0021 \r\n-49.9949 \r\n+5.9916 \r\n+24.9994 \r\n-49.9934 \r\n+5.9917 \r\n+49.9987 \r\n-49.9943 \r\n+5.9961 \r\n-0.0021 \r\n+0.0007 \r\n+5.9954 \r\n+25.0019 \r\n+0.0025 \r\n+5.9949 \r\n+50.0032 \r\n+0.0011 \r\n+5.9953 \r\n-0.0004 \r\n-24.9951 \r\n+5.9943 \r\n+50.0002 \r\n-24.9950 \r\n+5.9953 \r\n-0.0010 \r\n-49.9947 \r\n+5.9955 \r\n+24.9993 \r\n-49.9935 \r\n+5.9944 \r\n+49.9986 \r\n-49.9946 \r\n+1.9966 \r\n+14.0027 \r\n-17.0024 \r\n+1.9958 \r\n+21.9993 \r\n+0.0035 \r\n+1.9962 \r\n-0.0001 \r\n+0.0000 \r\n+1.9955 \r\n+10.9993 \r\n+0.0000 \r\n+1.9960 \r\n+21.9994 \r\n+0.0000 \r\n+1.9943 \r\n-0.0006 \r\n-7.9970 \r\n+1.9938 \r\n+10.9982 \r\n-7.9978 \r\n+1.9934 \r\n+21.9979 \r\n-7.9985 \r\n+1.9959 \r\n-0.0034 \r\n-15.9975 \r\n+1.9942 \r\n+10.9950 \r\n-15.9959 \r\n+1.9924 \r\n+21.9967 \r\n-15.9741 \r\n+1.9977 \r\n+0.0003 \r\n+0.0000 \r\n+1.9970 \r\n+10.9990 \r\n-0.0002 \r\n+1.9973 \r\n+21.9985 \r\n-0.0003 \r\n+1.9957 \r\n-0.0003 \r\n-7.9962 \r\n+1.9955 \r\n+10.9976 \r\n-7.9975 \r\n+1.9946 \r\n+21.9972 \r\n-7.9982 \r\n+1.9973 \r\n-0.0035 \r\n-15.9966 \r\n+1.9964 \r\n+10.9954 \r\n-15.9947 \r\n+1.9937 \r\n+21.9960 \r\n-15.9728 \r\n+1.9985 \r\n+0.0000 \r\n+0.0005 \r\n+1.9983 \r\n+10.9993 \r\n+0.0005 \r\n+1.9983 \r\n+21.9987 \r\n+0.0001 \r\n+1.9968 \r\n-0.0006 \r\n-7.9964 \r\n+1.9968 \r\n+10.9975 \r\n-7.9972 \r\n+1.9959 \r\n+21.9968 \r\n-7.9979 \r\n+1.9984 \r\n-0.0035 \r\n-15.9962 \r\n+1.9977 \r\n+10.9952 \r\n-15.9944 \r\n+1.9947 \r\n+21.9959 \r\n-15.9729 \r\n+5.9910 \r\n+1.9960 \r\n+21.9994 \r\n+50.0025 \r\n+0.0018 \r\n+21.9994 \r\n-15.9975 \r\n";
            
            //Hardcoded results as read from the file
            string[] ReadHardcodedSizeAcrossResults = Regex.Split(HardcodedSizeAcrossResults, "[\r\n]+");

            //Convert the number of rows from string to (int) number 
            int nNumHardcodedRows = ReadHardcodedSizeAcrossResults.Length;

            //System.Diagnostics.Debug.Assert(iNumActualRows == nNumHardcodedRows, "Total number of entries of actual and hardcoded results differ!!!");
            
            //string[] sArrSizeAcrossResult = new string[iNumActualRows];                   //Array of strings, that contains the Actual results
            //string[] sArrHardcodedSizeAcrossResults = new string[iNumActualRows];         //Array of strings, that contains the Hardcoded results

            for ( int i = 0; i < iNumActualRows; i++)
            {
                double dActualValue;
                double dHardcodedValue;
                Double.TryParse(ReadSizeAcrossResult[i], out dActualValue);               //Double is object and Try Parse is method in this object. The idea of this method is to convert the given string to value         
                Double.TryParse(ReadHardcodedSizeAcrossResults[i], out dHardcodedValue);
                if (!isEQ(dActualValue, dHardcodedValue, 0.005))
                {
                    string errLine = "Error on line: " + (i+1);
                    Ranorex.Report.Error("Validation", errLine);
                    errLine = "Actual value is " + dActualValue;
                    Ranorex.Report.Error("Actual Value is ", errLine);
                    errLine = "Hardcoded value is " + dHardcodedValue;
                    Ranorex.Report.Error("Expected Value is ", errLine);
                }
            }            

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'SizeacrossSTANotepad.Text15'.", repo.SizeacrossSTANotepad.Text15Info, new RecordItemIndex(42));
            Host.Current.CloseApplication(repo.SizeacrossSTANotepad.Text15, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
