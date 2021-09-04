using System;

namespace Bridge
{  

    class Program
    {
        static void Main(string[] args)
        {
            DarkTheme darkTheme = new DarkTheme();
            LightTheme lightTheme = new LightTheme();

            AdminDashboard  adminDashboard  = new AdminDashboard(darkTheme);
            UserDashboard  userDashboard = new UserDashboard(lightTheme);

            Console.WriteLine(adminDashboard.GetContent()); 
            Console.WriteLine(userDashboard.GetContent()); 

            Console.ReadLine();


            /*Output : 
             * Color of Admin Dashboard : Dark Black
               Color of User Dasboard : White Smoke
             */
        }
    }
}
