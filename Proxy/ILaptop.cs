using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    // The is Service Interfac which declares the interface of the Service.
    // The proxy must follow this interface to be able to disguise itself as a service object.
    public interface ILaptop
    {
        void Open();
        void Close();
    }
}
