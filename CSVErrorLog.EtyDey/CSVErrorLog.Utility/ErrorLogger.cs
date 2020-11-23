using System;
using System.IO;

namespace CSVErrorLog.Utility
{
    /// <summary>
    /// This class is for logging errors
    /// </summary>
    public class ErrorLogger
    {
        /// <summary>
        /// Constant Variable for path
        /// </summary>
        private const string _path = @"C:\CSVErrorLog.EtyDey\ErrorLog.CSV";


        /// <summary>
        /// Method for logging errors
        /// </summary>
        /// <param name="errorMessage"></param>
        /// 
        public static void Log(string errorMessage)
        {
            StreamWriter writer = new StreamWriter(_path, true);
            try
            {
                writer.WriteLine(errorMessage);
            }
            catch (Exception ex)
            {
              
            }
            finally
            {
                writer.Close();
            }
        }


        /// <summary>
        /// Method to display errors
        /// </summary>
        /// <returns>
        /// All errors in a string array
        /// </returns>
        public static string[] DisplayErrors()
        {
            string[] errors = null;
            try
            {
                errors = File.ReadAllLines(_path);
            }
            catch (Exception ex)
            {
                
            }

            return errors;
        }
    }
}
