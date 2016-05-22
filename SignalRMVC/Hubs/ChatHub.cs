using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.IO;

namespace SignalRMVC.Hubs
{
	public class ChatHub : Hub
	{
		public void Send(string name, string message)
		{
			// Call the addNewMessageToPage method to update clients.
			Clients.All.addNewMessageToPage(name, message);
			File.AppendAllText("C:\\Users\\colli_000\\Desktop\\test.txt", name);
		}
	}
}