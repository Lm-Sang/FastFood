using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Config
{
    class Session
    {
        public static void SetSession(int userId, string userName, string userRole)
        {
            UserId = userId;
            UserName = userName;
            UserRole = userRole;
        }

        public static void ClearSession()
        {
            UserId = -1;
            UserName = string.Empty;
            UserRole = string.Empty;
        }

        public static int UserId { get; set; } = -1;
        public static string UserName { get; set; } = string.Empty;
        public static string UserRole { get; set; } = string.Empty;
    }
}
