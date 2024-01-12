using ERS_BlockChain.Application.Miner.Interfaces;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class GetMinerIDDialogHandler : IGetMinerIDDialogHandler
	{
		public int GetMinerID()
		{
			int id;

			Console.WriteLine("Unesite id minera sa kojim zelite da obavite akciju: ");

			try
			{
				id = int.Parse(Console.ReadLine());
				foreach (MinerEntity client in SmartContractSingleton.Instance.AllMiners)
				{
					if (client.MinerId == id)
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
			Console.WriteLine("Ne postoji miner sa tim idjem u sistemu.");
			return -1;
		}
	}
}
