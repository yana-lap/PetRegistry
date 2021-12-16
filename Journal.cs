using System;
using System.Collections.Generic;
using System.Text;

namespace PetRegistry
{
    static class Journal
    {
        public static void CommitSystemChangeInfo(DateTime date, string typeOfChange, string userID)
        {
            string query = @"insert into Journal (OperationType, UserId, LogDate) 
values ('" + typeOfChange + "', " + userID  + ", '" + date.ToString("yyyy-MM-dd") + "')";
            Database.ExecuteNonQuery(query);
        }
    }
}
