using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{    
    class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark Black";
        }
    } 
    class LightTheme : ITheme
    {
        public string GetColor()
        {
            return "White Smoke";
        }
    }
}
