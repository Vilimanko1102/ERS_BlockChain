using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Client
{
	public class ClientRegisterHandler : IClientRegisterHandler
	{
		private readonly IClientRegisterDialogHandler clientRegisterDialogHandler = new ClientRegisterDialogHandler();
		public void Handle()
		{
			int id = clientRegisterDialogHandler.Handle();
			if(id < 0) { return; }
			SmartContractSingleton.Instance.AllClients.Add(new ClientEntity(id));
            Console.WriteLine("Novi klijent sa idjem " + id + " uspesno registrovan.");
        }

		public ClientRegisterHandler(IClientRegisterDialogHandler clientRegisterDialogHandler) 
		{
			this.clientRegisterDialogHandler = clientRegisterDialogHandler;
		}

		public ClientRegisterHandler() { }
	}
}
