using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    /* Context Implementation.. The Context defines the interface of interest to clients. It also maintains a reference to an instance of a State subclass, which
    represents the current state of the Context.*/
    public class TVContext : IState
    {
        private IState tvState;

        public void setState(IState state)
        {
            this.tvState = state;
        }

        public IState getState()
        {
            return this.tvState;
        }

        public void doAction()
        {
            this.tvState.doAction();
        }
    }
}
