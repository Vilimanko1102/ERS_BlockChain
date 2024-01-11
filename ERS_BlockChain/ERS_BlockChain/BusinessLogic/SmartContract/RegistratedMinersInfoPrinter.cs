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
	internal class RegistratedMinersInfoPrinter : IRegistratedMinersInfoPrinter
	{
		public void PrintInfo()
		{
			Console.WriteLine("Svi registrovani mineri: \n");
			foreach (MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
			{
				Console.WriteLine(miner);
				Console.WriteLine();
			}
		}
	}
}
