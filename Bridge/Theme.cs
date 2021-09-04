using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{    
    // Different Theme classes implementing ITheme interface. 
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
