using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p005
{
    internal class Admin
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool issuperadmin, string section)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }
        public void ShowAdminAndSection()
        {
            Console.WriteLine($"IsSuperAdmin: {IsSuperAdmin}, Section: {Section}");
        }

        static void Main(string[] args)
        {
        }
    }
}
