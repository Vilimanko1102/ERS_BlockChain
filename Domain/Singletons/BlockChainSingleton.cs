using ERS_BlockChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Domain.Singletons
{
	public class BlockChainSingleton
	{
		private static BlockChainSingleton instance = null;

		private BlockChainSingleton()
		{
			BlockChain = new LinkedList<BlockEntity>();
		}

		public static BlockChainSingleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new BlockChainSingleton();
				}
				return instance;
			}
			set { instance = value; }
		}



		public LinkedList<BlockEntity> BlockChain { get; set; }


		public void Add(BlockEntity entity)
		{
			if(!BlockChain.Contains(entity))
			{
				BlockChain.AddLast(entity);
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("TRENUTNO STANJE BLOCKCHAINA: \n\n");
			foreach (BlockEntity block in BlockChain)
			{
				sb.Append(block);
				sb.Append("\n");
			}

			return sb.ToString();
		}

	}
}
