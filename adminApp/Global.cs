using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adminApp
{
    internal static class Global
    {
        public static IdentityUser User;
        public static string RoleName;

        public static IEnumerable<IdentityUser> AllAdmins;
        public static IEnumerable<IdentityUser> AllTechnicicans;
        public static IEnumerable<IdentityUser> AllManagers;
        public static IEnumerable<IdentityUser> AllUsers;
        public static IEnumerable<IdentityUser> AllCustomers;
    }
}
    