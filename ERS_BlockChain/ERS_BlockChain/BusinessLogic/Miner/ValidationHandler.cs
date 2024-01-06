using ERS_BlockChain.Application.Block.Interfaces;
using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.BusinessLogic.Block;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using ERS_BlockChain.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class ValidationHandler : IValidationHandler
	{
		private static readonly ITargetStringBuilder targetStringBuilder = new TargetStringBuilder();
		private static readonly IDataAppender dataAppender = new DataAppender();
		private static readonly IBlockIDSetter blockIDSetter = new BlockIDSetter(new HashGenerator(dataAppender));
		private static readonly object mutex = new object();
		public void Validate(BlockEntity block, int POWComplexity)
		{
			BlockEntity copy = new BlockEntity(block);
			dataAppender.Block = copy;

			Console.WriteLine("Validation started.");
			do
			{	
				copy.Nonce++;
				blockIDSetter.SetBlockID();

			} while (ConversionUtil.HexadecimalToBinary(copy.SelfID).Substring(0, POWComplexity) != targetStringBuilder.GetTargetString(POWComplexity));

			lock (mutex)
			{
				if (!copy.Validated)
				{
					block.SelfID = copy.SelfID;
					BlockChainSingleton.Instance.BlockChain.AddLast(block);
					Console.WriteLine("Validacija za blok je zavrsena.");
					block.Validated = true;

				}
			}
		}
	}
}
