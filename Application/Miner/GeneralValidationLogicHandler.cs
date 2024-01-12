using ERS_BlockChain.Application.Client;
using ERS_BlockChain.Application.Miner.Interfaces;
using ERS_BlockChain.BusinessLogic.Client;
using ERS_BlockChain.BusinessLogic.Miner;
using ERS_BlockChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_BlockChain.Application.Miner
{
	internal class GeneralValidationLogicHandler : IGeneralValidationLogicHandler
	{
		private static readonly IValidationPreparementHandler validationPreparementHandler = new ValidationPreparementaHandler();
		private static readonly IValidationStarter validationStarter = new ValidationStarter();
		private static readonly IValidationCompleteHandler validationCompleteHandler = new ValidationCompleteHandler();
		private static readonly IMainThreadPauseHandler mainThreadPauseHandler = new MainThreadPauseHandler();
		private static readonly IDataSender dataSender = new DataSender();
		public void HandleValidationLogic()
		{
			if (dataSender.SendData())
			{
				BlockEntity blockToValidate = validationPreparementHandler.PrepareForValidation();
				validationStarter.StartValidation(blockToValidate);
				mainThreadPauseHandler.Pause();
				validationCompleteHandler.Handle();
			}
		}
	}
}
