using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCpart
{
    public static class GlobalParams
    {
        static String username = "DefaultUserName";
        static String password = "DefaultPassword";
        public static String UserName { get { return username; } }
        public static String Password { get { return password; } }
    }
}
