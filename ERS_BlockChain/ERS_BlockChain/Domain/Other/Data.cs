using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Domain.Other
{
	public class Data
	{
		public int ClientID { get; set; }
		public string Message { get; set; }
		public DateTime DateOfCreation { get; }

		public Data() { }
		public Data(int clientID, string message)
		{
			ClientID = clientID;
			Message = message;
			DateOfCreation = DateTime.Now;
		}

		public override string ToString()
		{
			return string.Format("Client {0} sent \"{1}\" at {2}", ClientID, Message, DateOfCreation);
		}
	}
}
