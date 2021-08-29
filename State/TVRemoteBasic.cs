using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    // This is context class. It has a state variable that it instantiates in an initial state.
    public class TVRemoteBasic
    {
		private String state = "";

		public void setState(String state)
		{
			this.state = state;
		}

		public void doAction()
		{
			if (state.Equals("ON"))
			{
				Console.WriteLine("TV is turned ON");
			}
			else if (state.Equals("OFF"))
			{
				Console.WriteLine("TV is turned OFF");
			}
		}		
	}
}
