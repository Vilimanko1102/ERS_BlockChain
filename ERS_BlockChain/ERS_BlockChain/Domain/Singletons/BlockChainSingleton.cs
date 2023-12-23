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
		}



		public LinkedList<BlockEntity> BlockChain { get; set; }

	}
}
