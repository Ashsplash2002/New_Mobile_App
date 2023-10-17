using System;
using System.Collections.Generic;
using System.Text;

namespace PilotChecklist_v1.DataAccess
{
    internal class DatabaseOperations
    {
        public string ConnectionString()
        {
            string server = "10.0.0.102";
            string database = "ProjectDB";

            string username = "admin";
            string password = "John3:16";

            return $"Server={server};Database={database};User Id={username};Password={password};";
        }
    }
}
