using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{    
    // Interface having Color Name, Theme class will have to implement it for their purposes.
    interface ITheme
    {
        string GetColor();
    }
}
