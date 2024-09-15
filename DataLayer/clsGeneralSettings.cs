using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

namespace DataLayer
{
    internal class clsGeneralSettings
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public static void Add_ERROR_ToEventLog(string Message="")
        {
            string SourceName = "Sales Man Helper";
            
            
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
                EventLog.WriteEntry(SourceName, Message, EventLogEntryType.Error);
            
            

            
            
            
        }

    }
}
