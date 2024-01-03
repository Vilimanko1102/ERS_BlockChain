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
	public class ClientRegisterDialogHandler : IClientRegisterDialogHandler
	{
		public int Handle()
		{
			int id = -1;

			Console.WriteLine("Unesite ID klijenta: ");
			try
			{

				id = int.Parse(Console.ReadLine());
				foreach (ClientEntity client in SmartContractSingleton.Instance.AllClients)
				{
					if (client.ClientID == id)
					{
						Console.WriteLine("Ne mozete registrovati klijenta koji vec postoji u sistemu.");
						return -1;
					}
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("Niste uneli validan ID. (morate uneti broj)");
				return -1;
			}

			return id;
		}
	}
}
