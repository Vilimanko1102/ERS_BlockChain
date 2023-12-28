using ERS_BlockChain.Application.Block.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Block
{
	public class BlockIDSetter : IBlockIDSetter
	{
		public IHashGenerator HashGenerator { get; set; }

		public BlockIDSetter(IHashGenerator hashGenerator)
		{
			HashGenerator = hashGenerator;
		}

		public void SetBlockID()
		{
			HashGenerator.DataAppender.Block.SelfID = HashGenerator.GenerateHash();
		}
	}
}
