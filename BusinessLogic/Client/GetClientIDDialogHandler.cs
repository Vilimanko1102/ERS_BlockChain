using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Client
{
	public class GetClientIDDialogHandler : IGetClientIDDialogHandler
	{
		public int GetClientID()
		{
			int id;

            Console.WriteLine("Unesite id klijenta sa kojim zelite da obavite akciju: ");

			try
			{
				id = int.Parse(Console.ReadLine());
				foreach(ClientEntity client in SmartContractSingleton.Instance.AllClients)
				{
					if(client.ClientID == id)
					{
						return id;
					}
				}
			}
			catch
			{
                Console.WriteLine("Niste uneli validan id.");
				return -1;
            }
            Console.WriteLine("Ne postoji klijent sa tim idjem u sistemu.");
			return -1;

        }
	}
}
