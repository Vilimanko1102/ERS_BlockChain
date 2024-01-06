using ERS_BlockChain.Application.Miner;
using ERS_BlockChain.Domain.Entities;
using ERS_BlockChain.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERS_BlockChain.BusinessLogic.Miner
{
	internal class ThreadStopper : IThreadStopper
	{
		public void StopRunningThreads(Thread thread)
		{
			foreach (MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
			{
				if (!miner.MinerThread.Name.Equals(thread.Name))
				{
					miner.MinerThread.Abort();
				}
			}
		}
	}
}
