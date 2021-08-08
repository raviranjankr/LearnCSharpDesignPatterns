using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
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
