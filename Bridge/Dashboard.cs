using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    // Different Dashbaord class implementing IWebDashboard.
    // Theme of Admin Dashboard and UserDashboard can be same or different as per defined theme. 
    class AdminDashboard : IWebDashboard
    {
        protected ITheme theme;

        public AdminDashboard(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"Color of Admin Dashboard : {theme.GetColor()}";
        }
    }

    class UserDashboard : IWebDashboard
    {
        protected ITheme theme;

        public UserDashboard(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"Color of User Dasboard : {theme.GetColor()}";
        }
    }
}
