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
	internal class ValidationCompleteHandler : IValidationCompleteHandler
	{
		private static readonly IThreadStopper threadStopper = new ThreadStopper();
		private static readonly IBitcoinAssigner bitcoinAssigner = new BitcoinAssigner();
		private static readonly IBlockChainUpdateHandler blockChainUpdateHandler = new BlockChainUpdateHandler();
		private static readonly IThreadRefreshHandler threadRefreshHandler = new ThreadRefreshHandler();
		public void Handle()
		{
			foreach (MinerEntity miner in SmartContractSingleton.Instance.AllMiners)
			{
				if (miner.MinerThread.ThreadState == ThreadState.Stopped)
				{
                    Console.WriteLine("Miner sa idjem " + miner.MinerId + " je validirao blok pa se njemu dodeljuje odedjena kolicina bitcoina.");
                    threadStopper.StopRunningThreads(miner.MinerThread);
					bitcoinAssigner.Award(miner);
					blockChainUpdateHandler.Update();
					SmartContractSingleton.Instance.PendingDataToValidate.Clear();
					threadRefreshHandler.Refresh();
					return;
				}
			}
		}
	}
}
