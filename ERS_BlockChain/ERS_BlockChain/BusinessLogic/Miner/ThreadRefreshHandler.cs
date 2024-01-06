using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class ThreadRefreshHandler : IThreadRefreshHandler
	{
		private static readonly IValidationHandler validationHandler = new ValidationHandler();
		public void Refresh()
		{
			foreach(MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
			{
				miner.MinerThread = null;
			}

			foreach(MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
			{
				miner.MinerThread = new Thread(() => validationHandler.Validate(miner.CurrentlyValidatingBlock, int.Parse(ConfigurationManager.AppSettings["ComplexityOfPOW"])));
				miner.MinerThread.Name = "Miner " + miner.MinerId;
			}

		}
	}
}
