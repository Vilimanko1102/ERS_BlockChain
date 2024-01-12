using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Other;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Client
{

	public class ValidationPreparementaHandler : IValidationPreparementHandler
	{
		public BlockEntity PrepareForValidation()
		{
			List<Data> blockData = new List<Data>(SmartContractSingleton.Instance.PendingDataToValidate);
			return SmartContractSingleton.Instance.BlockCreator.InitializeBlock(blockData);
		}
	}
}