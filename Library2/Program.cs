using Domain.Entities;
using Sec.urityManager;

namespace Presentation
{
    internal static class Program
    {
    
        [STAThread]
        static void Main()
        {
       
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}

//using Domain.Entities;
//using Sec.urityManager;
//using System;
//using System.Collections.Generic;
//using System.Windows.Forms;

//namespace Presentation
//{
//    internal static class Program
//    {
//        [STAThread]
//        static void Main()
//        {
//#if DEBUG
//            // 👇 Fake login for development
//            SignManager.OnlineUser = new User
//            {
//                UserName = "DevAdmin",
//                Person = new Person { FirstName = "Test", LastName = "Admin" },
//                Roles = new List<Role>
//                {
//                    new Role
//                    {
//                        RoleName = "Administrator",
//                        Activities = new List<Activity>
//                        {
//                            new Activity { ActivityName = UserActivity.BorrowManagment },
//                            new Activity { ActivityName = UserActivity.InformationManagment },
//                            new Activity { ActivityName = UserActivity.SecurityManagement },
//                            new Activity { ActivityName = UserActivity.SoftwareManagment }
//                        }
//                    }
//                }
//            };
//#endif

//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new MainForm());
//        }
//    }
//}
