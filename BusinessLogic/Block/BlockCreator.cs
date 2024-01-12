using ERS_BlockChain.Application.Block.Interfaces;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Block
{
	public class BlockCreator : IBlockCreator
	{
		IBlockPreviousIDSetter blockPreviousIDSetter = new BlockPreviousIDSetter();
		public BlockEntity InitializeBlock(List<Data> data)
		{
			BlockEntity block = new BlockEntity(data);
			IBlockIDSetter blockIDSetter = new BlockIDSetter(new HashGenerator(new DataAppender(block)));
			blockIDSetter.SetBlockID();
			blockPreviousIDSetter.SetPreviousID(block);
			return block;
		}
	}
}
