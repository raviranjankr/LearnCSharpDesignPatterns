using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    //State Design Pattern Interface,
    //It will define the method that should be implemented by different concrete states and context class.
    public interface IState
    {
        public void doAction();
    }
}
