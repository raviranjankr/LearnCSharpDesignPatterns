using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class LaptopWithNoLogin:ILaptop
    {
        public void Open()
        {
            Console.WriteLine("Laptop is Opening");
        }
        public void Close()
        {
            Console.WriteLine("Laptop is Closing");
        }        
    }
}
