using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.Application.Miner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class CompleteMinerRemovalHandler : ICompleteMinerRemovalHandler
	{
		private static readonly IMinerDeleteHandler minerDeleteHandler = new MinerDeleteHandler();
		private static readonly IBlockChainResetHandler blockChainResetHandler = new BlockChainResetHandler();
		private static readonly IBlockChainUpdateHandler blockChainUpdateHandler = new BlockChainUpdateHandler();
		public void Handle()
		{
			minerDeleteHandler.RemoveMiner();
			blockChainResetHandler.Reset();
			blockChainUpdateHandler.Update();
		}
	}
}
