using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Application.SmartContract;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Client
{
	public class ClientDataBufferHandler : IClientDataBufferHandler
	{
		private readonly IFindClientByID findClientByIDQuery = new FindClientByIDQuery();
		private readonly IGetClientIDDialogHandler getClientIDDialogHandler = new GetClientIDDialogHandler();
		private readonly IMessageGetDialogHandler messageGetDialogHandler = new MessageGetDialogHandler();

		public ClientDataBufferHandler(IFindClientByID findClientByID, IGetClientIDDialogHandler getClientIDDialogHandler, IMessageGetDialogHandler messageGetDialogHandler)
		{
			findClientByIDQuery = findClientByID;
			this.getClientIDDialogHandler = getClientIDDialogHandler;
			this.messageGetDialogHandler = messageGetDialogHandler;
		}

		public ClientDataBufferHandler() { }

		public void SendToClientDataBuffer()
		{
			int id = getClientIDDialogHandler.GetClientID();
			if(id < 0){ return; }

			ClientEntity client = findClientByIDQuery.Find(id);

			client.DataToSend.Add(new Data(id, messageGetDialogHandler.GetMessage()));
            Console.WriteLine("\nPoruka ubacena u bafer klijenta " + id + ".");
            Console.WriteLine("Bafer klijenta " + id + " izgleda ovako: ");
			foreach(Data d in client.DataToSend) { Console.Write(d); }
			
        }

		
	}
}
