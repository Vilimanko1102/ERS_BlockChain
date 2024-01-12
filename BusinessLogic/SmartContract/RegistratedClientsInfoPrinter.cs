using ERS_BlockChain.Application.SmartContract;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.SmartContract
{
	public class RegistratedClientsInfoPrinter : IRegistratedClientsInfoPrinter
	{
		public void PrintInfo()
		{
            Console.WriteLine("Svi registrovani klijenti: \n");
            foreach (ClientEntity client in SmartContractSingleton.Instance.AllClients)
			{
				Console.WriteLine(client);
				Console.WriteLine();
            }
		}
	}
}
