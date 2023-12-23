using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Domain.Entities
{
	public class ClientEntity : IEntity<int>
	{
		public int ClientID { get; set; }
		public List<Data> DataToSend { get; set; }

		public ClientEntity() { }

		public ClientEntity(int clientID)
		{
			ClientID = clientID;
			DataToSend = new List<Data>();
		}

		public int GetId()
		{
			return ClientID;
		}
	}
}
