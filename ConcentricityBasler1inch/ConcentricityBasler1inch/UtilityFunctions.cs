using System;

using System.Text.RegularExpressions;

namespace UtilityFunctions
{
    public class MathematicsConcentricity
    {
        private static bool IsConcentricityZero(double dConcentricityExpression, double EPSILONE)
        {
            return System.Math.Abs(dConcentricityExpression) < EPSILONE;
        }

        public static bool IsConcentricityEQ(double first, double second, double EPSILONE)
        {
            return IsConcentricityZero(first - second, EPSILONE);
        }
    }


    public class Mathemeatics
    {

        private static bool IsZero(double dExpression, double EPSILONE)
        {
            return System.Math.Abs(dExpression) < EPSILONE;
        }

        public static bool isEQ(double first, double second, double EPSILONE)
        {
            return IsZero(first - second, EPSILONE);
        }

    }

    public class ReportAction
    {
        public static void RunPositiveResult()
        {
            //string Value = "Actual Value is: " + dActualValue;
            Ranorex.Report.Success("Sucessfully Performed ");
        }

        public static void RunNegativeResult(double dActualValue, double dHardcodedValue, int nErrorLine)
        {

            string errLine = "Error on line: " + (nErrorLine + 1);
            Ranorex.Report.Error(errLine);

            string ActualValue = "Actual Value is: " + dActualValue;
            Ranorex.Report.Error(ActualValue);

            string HardcodedValue = "Hardcoded value is: " + dHardcodedValue;
            Ranorex.Report.Error(HardcodedValue);


        }
    }


    public class ConcentricityRun
    {
        public static void RunConcentricity(string iHardcodedInParam, string ResultRoutineInParam)
        {
            string ConcentricityResult = ResultRoutineInParam;
            string[] ReadConcentricityResult = Regex.Split(ConcentricityResult, "[\r\n]+");

            int iNumConcentricityRows = ReadConcentricityResult.Length;

            string HardcodedConcentricityResult = iHardcodedInParam;
            string[] ReadHardcodedConcentricityResult = Regex.Split(HardcodedConcentricityResult, "[\r\n]+");

            int iNumHardcodedRows = ReadHardcodedConcentricityResult.Length;


            //string[] sArrConcentricityResult = new string[iNumConcentricityRows];                         //Array of strings, that contains the Actual results
            //string[] sArrHardcodedConcentricityResults = new string[iNumHardcodedRows];                   //Array of strings, that contains the Hardcoded results

            bool bAllConcentricityResultsOK = true;

            for (int i = 0; i < iNumConcentricityRows; i++)
            {
                double dActualConcentricityValue;
                double dHardcodedConcentricityValue;
                Double.TryParse(ReadConcentricityResult[i], out dActualConcentricityValue);               //Double is object and Try Parse is method in this object. The idea of this method is to convert the given string to value         
                Double.TryParse(ReadHardcodedConcentricityResult[i], out dHardcodedConcentricityValue);

                try
                {
                    if (!MathematicsConcentricity.IsConcentricityEQ(dActualConcentricityValue, dHardcodedConcentricityValue, 0.005))
                    {
                        bAllConcentricityResultsOK = false;

                        ReportAction.RunNegativeResult(dActualConcentricityValue, dHardcodedConcentricityValue, i);

                    }
                }
                catch (Exception)
                {                 
                    
                }
            }

            if (bAllConcentricityResultsOK)

              ReportAction.RunPositiveResult();
            
        }
    }


        public class SizeAcrossRun
        {
            public static void RunSize(string iHardcodedInParam, string ResultRoutineInParam)
            {
                string SizeAcrossResult = ResultRoutineInParam;
                //Actual results as read from the file
                string[] ReadSizeAcrossResult = Regex.Split(SizeAcrossResult, "[\r\n]+");

                //Convert the number of rows from string to (int) number 
                int iNumActualRows = ReadSizeAcrossResult.Length;

                string HardcodedSizeAcrossResults = iHardcodedInParam;
                //Hardcoded results as read from the file
                string[] ReadHardcodedSizeAcrossResults = Regex.Split(HardcodedSizeAcrossResults, "[\r\n]+");

                //Convert the number of rows from string to (int) number 
                int nNumHardcodedRows = ReadHardcodedSizeAcrossResults.Length;


            bool bAllSizeAcrossResultsOK = true;

                for (int i = 0; i < iNumActualRows; i++)
                {
                    double dActualSizeAcrossValue;
                    double dHardcodedSizeAcrossValue;
                    Double.TryParse(ReadSizeAcrossResult[i], out dActualSizeAcrossValue);               //Double is object and Try Parse is method in this object. The idea of this method is to convert the given string to value         
                    Double.TryParse(ReadHardcodedSizeAcrossResults[i], out dHardcodedSizeAcrossValue);

                    try
                    {

                        if (!Mathemeatics.isEQ(dActualSizeAcrossValue, dHardcodedSizeAcrossValue, 0.005))
                        {

                        bAllSizeAcrossResultsOK = false;

                        ReportAction.RunNegativeResult(dActualSizeAcrossValue, dHardcodedSizeAcrossValue, i);

                        }
                    }
                    catch (Exception)
                    {

                    }
                if (bAllSizeAcrossResultsOK)

                ReportAction.RunPositiveResult();

            }

            

        }//public static class RunSize
        }//public class SizeAcrossRun
}//namespace UtilityFunctions










