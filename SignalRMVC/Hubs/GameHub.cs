using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.IO;

namespace SignalRMVC.Hubs
{
	public class GameHub : Hub
	{
		public void Send(string name)
		{
			// Call the test method to update clients.
			Clients.All.test(name);
            //File.AppendAllText("C:\\Users\\colli_000\\Desktop\\test.txt", name);
        }

        public void Loaner(string name)
        {

        }

        public void Pass(string name)
        {

        }

        public void Pickup(string name)
        {

        }
    }
}