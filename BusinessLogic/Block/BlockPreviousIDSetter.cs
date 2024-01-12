using ERS_BlockChain.Application.Block.Interfaces;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Block
{
	internal class BlockPreviousIDSetter : IBlockPreviousIDSetter
	{
		public void SetPreviousID(BlockEntity block)
		{
			if(BlockEntity.NumOfBlocks == 1)
			{
				block.PreviousID = "///";
			}
			else
			{
				block.PreviousID = BlockChainSingleton.Instance.BlockChain.Last.Value.SelfID;
			}
		}
	}
}
