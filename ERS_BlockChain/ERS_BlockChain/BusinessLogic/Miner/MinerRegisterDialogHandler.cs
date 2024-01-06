using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class MinerRegisterDialogHandler : IMinerRegisterDialogHandler
	{
		public int Handle()
		{
			int id = -1;

			Console.WriteLine("Unesite ID minera: ");
			try
			{

				id = int.Parse(Console.ReadLine());
				foreach (MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
				{
					if (miner.MinerId == id)
					{
						Console.WriteLine("Ne mozete registrovati minera koji vec postoji u sistemu.");
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
