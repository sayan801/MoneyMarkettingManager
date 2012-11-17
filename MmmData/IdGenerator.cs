using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SadlData
{
    public static class IdGenerator
    {
        public static string GetAgentUniqueId()
        {
            return "Agent-Bally-"+ DateTime.Now.ToOADate().ToString();
        }

        public static string GetClientUniqueId()
        {
            return "Client-Bally-" + DateTime.Now.ToOADate().ToString();
        }

        public static string GetEmployeeUniqueId()
        {
            return "Employee-Bally-" + DateTime.Now.ToOADate().ToString();
        }
    }
}
