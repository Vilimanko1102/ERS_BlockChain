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
	internal class BlockChainUpdateHandler : IBlockChainUpdateHandler
	{
		public void Update()
		{
			foreach (MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
			{
				miner.BlockChainCopy = BlockChainSingleton.Instance;
			}
		}
	}
}
