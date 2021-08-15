using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class LaptopWithLogin
    {
        private ILaptop laptop;

        public LaptopWithLogin(ILaptop ilaptop)
        {
            laptop = ilaptop ?? throw new ArgumentNullException("laptop", "laptop can not be null");
        }

        public void Open(string password)
        {
            if (Authenticate(password))
            {
                laptop.Open();
            }
            else
            {
                Console.WriteLine("Invalid Try.");
            }
        }

        private bool Authenticate(string password)
        {
            return password == "abc@123";
        }

        public void Close()
        {
            laptop.Close();
        }
    }
}
