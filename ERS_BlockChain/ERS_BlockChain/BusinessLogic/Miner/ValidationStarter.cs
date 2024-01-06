using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Exceptions;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class ValidationStarter : IValidationStarter
	{
		public void StartValidation(BlockEntity block)
		{
			if(SmartContractSingleton.Instance.AllMiners.Count == 0)
			{
				throw new NoMinersToValidateException("Nema registrovanih majnera pa je validacija nemoguca.");
            }

			foreach(MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
			{
				miner.CurrentlyValidatingBlock = block;
				miner.MinerThread.Start();
			}
		}
	}
}
