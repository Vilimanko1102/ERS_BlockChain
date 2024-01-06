using ERS_BlockChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Application.Miner
{
	internal interface IValidationHandler
	{
		void Validate(BlockEntity block, int POWComplexity);
	}
}
