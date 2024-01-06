using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class MainThreadPauseHandler : IMainThreadPauseHandler
	{
		public void Pause()
		{
			while (Condition()) ;
		}

		private bool Condition()
		{
			foreach (MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
			{
				if (miner.MinerThread.ThreadState == ThreadState.Stopped)
					return false;
			}
			return true;
		}
	}
}
