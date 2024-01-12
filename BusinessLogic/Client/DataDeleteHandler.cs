using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Client
{
	public class DataDeleteHandler : IDataDeleteHandler
	{
		public List<Data> DataToDelete { get; set; }

		public void Delete(ClientEntity client)
		{
			foreach (Data data in DataToDelete)
			{
				client.DataToSend.Remove(data);
			}
		}

		public DataDeleteHandler()
		{
			DataToDelete = new List<Data>();
		}
	}
}
