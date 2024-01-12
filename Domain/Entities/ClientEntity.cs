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

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append($"Client {ClientID}:\nPodaci u baferu klijenta {ClientID}\n");

			foreach ( Data data in DataToSend )
			{
				sb.Append(data);
			}

			return sb.ToString();
		}

		public int GetId()
		{
			return ClientID;
		}
	}
}
