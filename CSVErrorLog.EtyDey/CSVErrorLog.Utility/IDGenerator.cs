using System;

namespace CSVErrorLog.Utility
{
    /// <summary>
    /// This class is for generating Employee ID
    /// </summary>
    public class IDGenerator
    {
        public static int NewID()
        {
            Random newID = new Random();
            return newID.Next(100000, 999999);
        }
    }
}
