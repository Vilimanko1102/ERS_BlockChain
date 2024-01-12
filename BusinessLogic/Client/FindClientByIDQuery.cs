using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Application.SmartContract;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Client
{
	public class FindClientByIDQuery : IFindClientByID
	{
		public ClientEntity Find(int id)
		{
			ClientEntity setToReturn = null;

            foreach (ClientEntity client in SmartContractSingleton.Instance.AllClients)
			{
				if(client.ClientID == id)
				{
					setToReturn = client;
				}
			}

			return setToReturn;
		}
	}
}
