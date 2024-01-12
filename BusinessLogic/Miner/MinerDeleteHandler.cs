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
	internal class MinerDeleteHandler : IMinerDeleteHandler
	{
		private static readonly IGetMinerIDDialogHandler getMinerIDDialogHandler = new GetMinerIDDialogHandler();
		private static readonly IBlockChainResetHandler blockChainResetHandler = new BlockChainResetHandler();
		public void RemoveMiner()
		{
			int id = getMinerIDDialogHandler.GetMinerID();
			if(id < 0) { return; }

			foreach(MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
			{
				if(id == miner.MinerId)
				{
					SmartContractSingleton.Instance.AllMiners.Remove(miner);
                    Console.WriteLine("Miner sa idjem " + id + " uklonjen iz sistema.");
                    return;
				}
			}
		}
	}
}
