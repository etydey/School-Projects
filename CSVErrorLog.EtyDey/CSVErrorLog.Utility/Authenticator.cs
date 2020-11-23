using System;
using System.Collections.Generic;
using System.IO;

namespace CSVErrorLog.Utility
{
    /// <summary>
    /// Username and Password authentication class
    /// </summary>
    public class Authenticator
    {
        /// <summary>
        /// Constant Variable for path
        /// </summary>
        private const string _path = @"C:\CSVErrorLog.EtyDey\authorize.dat";


        /// <summary>
        /// Authenticate User ID and password for login with this method
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Boolean Value (True or False)
        /// </returns>
        public static bool Authenticate(string userName, string password)
        {
            bool authenticated = false;
            List<string> fileUser = new List<string>();
            List<string> filePass = new List<string>();

            FileStream stream = new FileStream(@"C:\CSVErrorLog.EtyDey\authorize.dat", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            try
            {
                do
                {
                    fileUser.Add(reader.ReadString());
                    filePass.Add(reader.ReadString());
                }
                while (reader.PeekChar() != -1);
            }
            catch (Exception ex)
            {
                ErrorLogger.Log(ex.Message);
            }
            finally
            {
                reader.Close();
            }


            for (int i = 0; i < fileUser.Count; i++)
            {
                if (fileUser[i] == userName && filePass[i] == password)
                {
                    authenticated = true;
                }

            }
            

            if(authenticated==false)
            {
                ErrorLogger.Log(userName + "(" + DateTime.Today.ToLongDateString() + ")" + "-Invalid Username or Password!");

            }

            return authenticated;

        }

    }
}
