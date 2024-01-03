using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Application.SmartContract;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Client
{
	public class ClientDataBufferHandler : IClientDataBufferHandler
	{
		private static readonly FindClientByIDQuery findClientByIDQuery = new FindClientByIDQuery();
		private static readonly IGetClientIDDialogHandler getClientIDDialogHandler = new GetClientIDDialogHandler();
		private static readonly IMessageGetDialogHandler messageGetDialogHandler = new MessageGetDialogHandler();
		
		public void SendToClientDataBuffer()
		{
			int id = getClientIDDialogHandler.GetClientID();
			if(id < 0){ return; }

			ClientEntity client = findClientByIDQuery.Find(id);

			client.DataToSend.Add(new Data(id, messageGetDialogHandler.GetMessage()));
            Console.WriteLine("Poruka ubacena u bafer klijenta " + id + ".");
            Console.WriteLine("Bafer klijenta " + id + " izgleda ovako: ");
			foreach(Data d in client.DataToSend) { Console.WriteLine(d); }
        }
	}
}
