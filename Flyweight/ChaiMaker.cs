using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class GaramChai
    {
    }
    public class ChaiMaker
    {
        private Dictionary<string, GaramChai> dTeaAvailable = new Dictionary<string, GaramChai>();

        public GaramChai Make(string preference)
        {
            if (!dTeaAvailable.ContainsKey(preference))
            {
                dTeaAvailable[preference] = new GaramChai();
            }

            return dTeaAvailable[preference];
        }
    }
}
