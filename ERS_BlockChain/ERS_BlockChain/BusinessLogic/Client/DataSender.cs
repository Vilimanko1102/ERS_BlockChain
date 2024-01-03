using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Client
{
	public class DataSender : IDataSender
	{
		private const int MAX_VELICINA_BLOKA = 2;

		private static readonly IGetClientIDDialogHandler getClientIDDialogHandler = new GetClientIDDialogHandler();
		private static readonly FindClientByIDQuery findClientByIDQuery = new FindClientByIDQuery();
		private static readonly IDataDeleteHandler dataDeleteHandler = new DataDeleteHandler();
		public bool SendData()
		{
			int id = getClientIDDialogHandler.GetClientID();
			if (id < 0) { return false; }

			ClientEntity client = findClientByIDQuery.Find(id);

			foreach (Data data in client.DataToSend)
			{
				if (SmartContractSingleton.Instance.PendingDataToValidate.Count < MAX_VELICINA_BLOKA)
				{
					SmartContractSingleton.Instance.PendingDataToValidate.Add(data);
					dataDeleteHandler.DataToDelete.Add(data);
				}
				else
				{
					Console.WriteLine("Blok je popunjen i spreman je za slanje na validaciju.");
					dataDeleteHandler.Delete(client);
					return true;
				}
			}
			dataDeleteHandler.Delete(client);
			return false;
		}
	}
}

