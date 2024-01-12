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
	internal class BlockChainResetHandler : IBlockChainResetHandler
	{
		public void Reset()
		{
			if(SmartContractSingleton.Instance.AllMiners.Count == 0)
			{
				BlockChainSingleton.Instance.BlockChain.Clear();
				BlockEntity.NumOfBlocks = 0;
			}
			
		}
	}
}
